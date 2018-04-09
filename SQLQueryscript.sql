--create database  Shop_Billing_08042018
USE Shop_Billing_08042018
--------------------------------------------------------------------------------------------------
                           ---MOBILE SHOP INVAISE BILL---
--------------------------------------USER MASTER-------------------------------------------------

CREATE TABLE TBL_A_USER
(
  USER_ID INT IDENTITY(1,1),
  NAME VARCHAR(25),
  MOBILE_NUMBER VARCHAR(10),
  USER_NAME VARCHAR(30) UNIQUE,
  PASSWORD VARCHAR(20),  
  CREATED_DATE DATETIME DEFAULT GETDATE(),
  CREATED_BY INT
)

-------------------------------------USER ROLE------------------------------------------------------

CREATE TABLE TBL_A_USER_ROLE
(
  ID INT IDENTITY(1,1),
  USER_ID INT,
  USER_ACCESS VARCHAR(10),
  CREATED_DATE DATETIME DEFAULT GETDATE(),
  CREATED_BY INT
)

--------------------------------------PRODUCT MASTER-------------------------------------------------

CREATE TABLE TBL_PRODUCT_MASTER
(
 PRODUCT_ID INT IDENTITY(1,1),
 PRODUCT_NAME VARCHAR(100),
 AMOUNT MONEY,
 CREATED_DATE DATETIME DEFAULT GETDATE(),
 CREATED_BY INT
)

-----------------------------------BILLING TABLE----------------------------------------------------
CREATE TABLE TBL_BILLING
(
  BILL_NO INT IDENTITY(1000,1),
  CUSTOMER_NAME VARCHAR(50),
  CUSTOMER_MOBILE_NO VARCHAR(10),
  PRODUCT_ID INT,
  QUANTITY INT,
  TOTAL_AMOUNT MONEY,
  CREATED_DATE DATETIME DEFAULT GETDATE(),
  CREATED_BY INT
)
-----------------------------------------------------------------------------------------------------