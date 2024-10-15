-- Medical store management system
create database MedicalStoreManagementSystem

create table medications(
  medication_id bigint primary key identity,
  medication_name varchar(100),
  medication_category varchar(100),
  medication_price decimal(12,2),
  med_expiry_date date,
  supplier_id varchar(100),
  stock_quantity bigint,
  
  constraints fk_supplier_id foreign key (supplier_id) references suppliers(supplier_id);
);

create table suppliers(
  supplier_id varchar(100) primary key identity,
  supplier_name varchar(100),
  contact_person varchar(100),
  supplier_phone varchar(100),
  supplier_email varchar(100),
  supplier_address varchar(100)
);

create table customers(
  customer_id bigint primary key identity,
  customer_name varchar(100),
  customer_phone varchar(100),
  customer_email varchar(100),
  customer_address varchar(100)
);

create table sales(
  sales_id bigint primary key ,
  customer_id bigint,
  medication_id bigint,
  sales_quantity bigint not null,
  sales_date date,
  total_price decimal(15,2),
  
  constraints fk_customer_id foreign key (customer_id) references customers (customer_id);
  constraints fk_medication_id foreign key (medication_id) references medications (medication_id);
);

create table inventory(
  inventory_id bigint primary key identity,
  medication_id bigint,
  supplier_id varchar(100),
  stock_in bigint,
  stock_out bigint,
  date_added date,
  
  constraints fk_medication_id foreign key (medication_id) references medications (medication_id);
  constraints fk_supplier_id foreign key (supplier_id) references suppliers (supplier_id);
);

CREATE PROCEDURE sp_AddMedication
  @medication_id BIGINT,
  @medication_name VARCHAR(100),
  @medication_category VARCHAR(100),
  @medication_price DECIMAL(12,2),
  @med_expiry_date DATE,
  @supplier_id VARCHAR(100),
  @stock_quantity BIGINT
AS
BEGIN
  INSERT INTO medications (medication_id, medication_name, medication_category, medication_price, med_expiry_date, supplier_id, stock_quantity)
  VALUES (@medication_id, @medication_name, @medication_category, @medication_price, @med_expiry_date, @supplier_id, @stock_quantity);
END;


EXEC sp_AddMedication 6, 'Paracetamol', 'Pain Reliever', 6.99, '2025-07-15', 'SUP006', 120;

CREATE PROCEDURE sp_AddSuppliers
  @supplier_id VARCHAR(100),
  @supplier_name VARCHAR(100),
  @contact_person VARCHAR(100),
  @supplier_phone VARCHAR(100),
  @supplier_email VARCHAR(100),
  @supplier_address VARCHAR(100)
AS
BEGIN
  INSERT INTO suppliers (supplier_id, supplier_name, contact_person, supplier_phone, supplier_email, supplier_address)
  VALUES (@supplier_id, @supplier_name, @contact_person, @supplier_phone, @supplier_email, @supplier_address);
END;

EXEC sp_AddSupplier 'SUP006', 'Global Health Supplies', 'Emma Watson', '678-901-2345', 'emma.watson@globalhealth.com', '808 Supplier St.';

CREATE PROCEDURE sp_AddCustomer
  @customer_id BIGINT,
  @customer_name VARCHAR(100),
  @customer_phone VARCHAR(100),
  @customer_email VARCHAR(100),
  @customer_address VARCHAR(100)
AS
BEGIN
  INSERT INTO customers (customer_id, customer_name, customer_phone, customer_email, customer_address)
  VALUES (@customer_id, @customer_name, @customer_phone, @customer_email, @customer_address);
END;

EXEC AddCustomer 6, 'John Doe', '123-456-7890', 'john.doe@example.com', '909 Customer Blvd.';

CREATE PROCEDURE sp_AddSales
  @sales_id BIGINT,
  @customer_id BIGINT,
  @medication_id BIGINT,
  @sales_quantity BIGINT,
  @sales_date DATE,
  @total_price DECIMAL(15,2)
AS
BEGIN
  INSERT INTO sales (sales_id, customer_id, medication_id, sales_quantity, sales_date, total_price)
  VALUES (@sales_id, @customer_id, @medication_id, @sales_quantity, @sales_date, @total_price);
END;

EXEC sp_AddSales 1, 6, 6, 2, '2024-10-10', 13.98;

CREATE PROCEDURE sp_AddInventory
  @inventory_id BIGINT,
  @medication_id BIGINT,
  @supplier_id VARCHAR(100),
  @stock_in BIGINT,
  @stock_out BIGINT,
  @date_added DATE
AS
BEGIN
  INSERT INTO inventory (inventory_id, medication_id, supplier_id, stock_in, stock_out, date_added)
  VALUES (@inventory_id, @medication_id, @supplier_id, @stock_in, @stock_out, @date_added);
END;

EXEC sp_AddInventory 1, 6, 'SUP006', 100, 0, '2024-10-10';


-- given data are dummy, generated from gpt