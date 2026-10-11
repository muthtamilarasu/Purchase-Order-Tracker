CREATE TABLE Suppliers
(
    SupplierID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName VARCHAR(100) NOT NULL UNIQUE,
    IsDeleted BIT NOT NULL DEFAULT 0
);

CREATE TABLE PurchaseOrderStatus
(
    StatusID INT IDENTITY(1,1) PRIMARY KEY,
    StatusName VARCHAR(30) NOT NULL UNIQUE
);

INSERT INTO PurchaseOrderStatus (StatusName)
VALUES ('Pending'), ('Approved'), ('Cancelled');

CREATE TABLE PurchaseOrders
(
    PurchaseOrderID INT IDENTITY(1,1) PRIMARY KEY,
    PONumber VARCHAR(30) NOT NULL,
    PODate DATE NOT NULL,
    SupplierID INT NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    StatusID INT NOT NULL,
    Remarks VARCHAR(250) NULL,
    IsDeleted BIT NOT NULL DEFAULT 0,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_PurchaseOrders_Supplier
        FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID),

    CONSTRAINT FK_PurchaseOrders_Status
        FOREIGN KEY (StatusID) REFERENCES PurchaseOrderStatus(StatusID),

    CONSTRAINT CK_PurchaseOrders_Amount
        CHECK (Amount > 0)
);

CREATE UNIQUE NONCLUSTERED INDEX IX_PurchaseOrders_PONumber_Active
ON PurchaseOrders(PONumber)
WHERE IsDeleted = 0;

INSERT INTO Suppliers (SupplierName)
VALUES
    ('ABC Textiles'),
    ('Star Suppliers');

GO

-- =============================================
-- STORED PROCEDURES
-- =============================================

CREATE OR ALTER PROCEDURE sp_GetSuppliers
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        SupplierID,
        SupplierName
    FROM Suppliers
    WHERE IsDeleted = 0
    ORDER BY SupplierName;
END;
GO

CREATE OR ALTER PROCEDURE sp_GetPurchaseOrderStatus
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        StatusID,
        StatusName
    FROM PurchaseOrderStatus
    ORDER BY StatusName;
END;
GO

CREATE OR ALTER PROCEDURE sp_SavePurchaseOrder
    @PONumber VARCHAR(30),
    @PODate DATE,
    @SupplierID INT,
    @Amount DECIMAL(18,2),
    @StatusID INT,
    @Remarks VARCHAR(250) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS
    (
        SELECT 1
        FROM PurchaseOrders
        WHERE PONumber = @PONumber
          AND IsDeleted = 0
    )
    BEGIN
        RAISERROR('PO Number already exists.', 16, 1);
        RETURN;
    END;

    INSERT INTO PurchaseOrders
    (
        PONumber,
        PODate,
        SupplierID,
        Amount,
        StatusID,
        Remarks
    )
    VALUES
    (
        @PONumber,
        @PODate,
        @SupplierID,
        @Amount,
        @StatusID,
        @Remarks
    );
END;
GO

CREATE OR ALTER PROCEDURE sp_GetPurchaseOrders
    @FromDate DATE = NULL,
    @ToDate DATE = NULL,
    @SupplierID INT = 0,
    @StatusID INT = 0
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        PO.PurchaseOrderID,
        PO.PONumber,
        PO.PODate,
        PO.SupplierID,
        S.SupplierName,
        PO.Amount,
        PO.StatusID,
        PS.StatusName,
        PO.Remarks
    FROM PurchaseOrders PO
    INNER JOIN Suppliers S
        ON S.SupplierID = PO.SupplierID
    INNER JOIN PurchaseOrderStatus PS
        ON PS.StatusID = PO.StatusID
    WHERE PO.IsDeleted = 0
      AND (@FromDate IS NULL OR PO.PODate >= @FromDate)
      AND (@ToDate IS NULL OR PO.PODate <= @ToDate)
      AND (@SupplierID = 0 OR PO.SupplierID = @SupplierID)
      AND (@StatusID = 0 OR PO.StatusID = @StatusID)
    ORDER BY PO.PODate DESC, PO.PurchaseOrderID DESC;
END;
GO

CREATE OR ALTER PROCEDURE sp_UpdatePurchaseOrder
    @PurchaseOrderID INT,
    @PONumber VARCHAR(30),
    @PODate DATE,
    @SupplierID INT,
    @Amount DECIMAL(18,2),
    @StatusID INT,
    @Remarks VARCHAR(250) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS
    (
        SELECT 1
        FROM PurchaseOrders
        WHERE PONumber = @PONumber
          AND PurchaseOrderID <> @PurchaseOrderID
          AND IsDeleted = 0
    )
    BEGIN
        RAISERROR('PO Number already exists.', 16, 1);
        RETURN;
    END;

    UPDATE PurchaseOrders
    SET
        PONumber = @PONumber,
        PODate = @PODate,
        SupplierID = @SupplierID,
        Amount = @Amount,
        StatusID = @StatusID,
        Remarks = @Remarks
    WHERE PurchaseOrderID = @PurchaseOrderID
      AND IsDeleted = 0;
END;
GO

CREATE OR ALTER PROCEDURE sp_DeletePurchaseOrder
    @PurchaseOrderID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE PurchaseOrders
    SET IsDeleted = 1
    WHERE PurchaseOrderID = @PurchaseOrderID
      AND IsDeleted = 0;
END;
GO

CREATE OR ALTER PROCEDURE sp_GetPurchaseOrderKPICounts
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        COUNT(*) AS TotalPO,

        ISNULL(SUM
        (
            CASE
                WHEN PS.StatusName = 'Pending' THEN 1
                ELSE 0
            END
        ), 0) AS PendingCount,

        ISNULL(SUM
        (
            CASE
                WHEN PS.StatusName = 'Approved' THEN 1
                ELSE 0
            END
        ), 0) AS ApprovedCount,

        ISNULL(SUM
        (
            CASE
                WHEN PS.StatusName = 'Cancelled' THEN 1
                ELSE 0
            END
        ), 0) AS CancelledCount

    FROM PurchaseOrders PO
    INNER JOIN PurchaseOrderStatus PS
        ON PS.StatusID = PO.StatusID
    WHERE PO.IsDeleted = 0;
END;
GO