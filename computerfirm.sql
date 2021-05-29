CREATE TABLE Position
(
  Salary INT NOT NULL,
  Responsibilities VARCHAR(250) NOT NULL,
  Requirements VARCHAR(250) NOT NULL,
  Job_title VARCHAR(250) NOT NULL,
  Position_ID INT NOT NULL,
  PRIMARY KEY (Position_ID)
);

CREATE TABLE Types_Component
(
  Type_ID INT NOT NULL,
  Type_title VARCHAR(250) NOT NULL,
  Type_description VARCHAR(250) NOT NULL,
  PRIMARY KEY (Type_ID)
);

CREATE TABLE Customer
(
  Customer_ID INT NOT NULL,
  Customer_Full_name VARCHAR(250) NOT NULL,
  Customer_Address VARCHAR(250) NOT NULL,
  Customer_Phone_number VARCHAR(250) NOT NULL,
  PRIMARY KEY (Customer_ID)
);

CREATE TABLE Services
(
  Service_ID INT NOT NULL,
  Service_title VARCHAR(250) NOT NULL,
  Service_description VARCHAR(250) NOT NULL,
  Service_cost INT NOT NULL,
  PRIMARY KEY (Service_ID)
);

CREATE TABLE Employee
(
  Employee_ID INT NOT NULL,
  Employee_Full_name VARCHAR(250) NOT NULL,
  Employee_Age VARCHAR(250) NOT NULL,
  Employee_Gender VARCHAR(250) NOT NULL,
  Employee_Address VARCHAR(250) NOT NULL,
  Employee_Phone_number VARCHAR(250) NOT NULL,
  Employee_Passport VARCHAR(250) NOT NULL,
  Position_ID INT NOT NULL,
  PRIMARY KEY (Employee_ID),
  FOREIGN KEY (Position_ID) REFERENCES Position(Position_ID)
);

CREATE TABLE Component
(
  Component_Manufacturer VARCHAR(250) NOT NULL,
  Component_ID INT NOT NULL,
  Component_Mark VARCHAR(250) NOT NULL,
  Component_Country_Manufacturer VARCHAR(250) NOT NULL,
  Component_Date INT NOT NULL,
  Component_Discription VARCHAR(250) NOT NULL,
  Component_Cost VARCHAR(250) NOT NULL,
  Component_Characteristics VARCHAR(250) NOT NULL,
  Component_Term_warranty INT NOT NULL,
  Type_ID INT NOT NULL,
  PRIMARY KEY (Component_ID),
  FOREIGN KEY (Type_ID) REFERENCES Types_Component(Type_ID)
);

CREATE TABLE Orders
(
  Order_Execution_Date INT NOT NULL,
  Order_Execution_mark VARCHAR(250) NOT NULL,
  Order_Mark_of_payment VARCHAR(250) NOT NULL,
  Order_Prepaid_Share VARCHAR(250) NOT NULL,
  Order_Order_date INT NOT NULL,
  Order_General_Warranty_Duration INT NOT NULL,
  Total_cost INT NOT NULL,
  Order_ID INT NOT NULL,
  Component_ID_1 INT NOT NULL,
  Component_ID_2 INT NOT NULL,
  Component_ID_3 INT NOT NULL,
  Customer_ID INT NOT NULL,
  Employee_ID INT NOT NULL,
  Service_ID_1 INT NOT NULL,
  Service_ID_2 INT NOT NULL,
  Service_ID_3 INT NOT NULL,
  PRIMARY KEY (Order_ID),
  FOREIGN KEY (Component_ID_1) REFERENCES Services(Service_ID),
  FOREIGN KEY (Component_ID_2) REFERENCES Services(Service_ID),
  FOREIGN KEY (Component_ID_3) REFERENCES Services(Service_ID),
  FOREIGN KEY (Customer_ID) REFERENCES Customer(Customer_ID),
  FOREIGN KEY (Employee_ID) REFERENCES Employee(Employee_ID),
  FOREIGN KEY (Service_ID_1) REFERENCES Component(Component_ID),
  FOREIGN KEY (Service_ID_2) REFERENCES Component(Component_ID),
  FOREIGN KEY (Service_ID_3) REFERENCES Component(Component_ID)
);