using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }

    class EmployeeManager
    {
        public decimal CalculateYearlySalary(Employee emp)
        {
            return emp.Salary * 12;
        }
    }

    class ReportService
    {
        public void GenerateReport(string reportType)
        {


        }
    }

    class NotificationService
    {
        public void SendNotification(string recipient, string message)
        {


        }
    }
}
