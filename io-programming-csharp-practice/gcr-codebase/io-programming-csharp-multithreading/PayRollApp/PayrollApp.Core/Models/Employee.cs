using System;

namespace PayrollApp.Core.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartDate { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }
    }
}