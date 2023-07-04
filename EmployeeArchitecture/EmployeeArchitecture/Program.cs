using System;
using System.Collections.Generic;


namespace EmployeeArchitecture
{
    public delegate void EmployeeLeaveEventHandler(object sender, EmployeeLeaveEventArgs e);

    public class EmployeeLeaveEventArgs:EventArgs
    {
        public string EmployeeName { get; set; }
        public string LeaveReason { get; set; }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
       public string Name { get; set; }

        public string City { get; set; }

        public event EmployeeLeaveEventHandler EmployeeLeave;

        public void TakeLeave(string reason)
        {
            Console.WriteLine("employee{0}is taking leave for {1}",Name,reason);

            if(EmployeeLeave!=null)
            {
                EmployeeLeave(this, new EmployeeLeaveEventArgs() { EmployeeName = Name, LeaveReason = reason });
            }
        }


    }
    public class Company
    {
        private List<Employee> employees = new List<Employee>();

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            emp.EmployeeLeave += new EmployeeLeaveEventHandler(Employee_EmployeeLeave);
        }
        private void Employee_EmployeeLeave(object sender, EmployeeLeaveEventArgs e)
        {
            Console.WriteLine("Employee{0} has taken leave for {1}", e.EmployeeName, e.LeaveReason);
        }

        public void RemoveEmployee(Employee emp)
        {
            employees.Remove(emp);
            emp.EmployeeLeave -= new EmployeeLeaveEventHandler(Employee_EmployeeLeave);
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company()
            {
                CompanyId = 1,
                CompanyName = "Virtus"
            };
            Employee emp = new Employee()
            {
                EmployeeId = 1,
                Name = "Ankit",
                City = "Nagpur"
            };
            company.AddEmployee(emp);
            emp.TakeLeave("Fever");
            company.RemoveEmployee(emp);
            Console.ReadLine();
        }
    }
}