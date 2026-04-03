CREATE TABLE employee_payroll
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100),
    Salary FLOAT,
    StartDate DATETIME
);

CREATE TABLE payroll_details
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    EmployeeId INT,
    BasicPay FLOAT,
    Deductions FLOAT,
    TaxablePay FLOAT,
    IncomeTax FLOAT,
    NetPay FLOAT,
    FOREIGN KEY (EmployeeId) REFERENCES employee_payroll(Id)
);