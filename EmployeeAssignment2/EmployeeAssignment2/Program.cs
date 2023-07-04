namespace EmployeeAssignment2
{
    internal class Program
    {
        class Employee
        {
            private string name;
            private int empno;
            private static int employee_id = 0;
            private double basic;
            private short deptNo;
            public Employee(string name, double basic, short deptno)
            {
                this.empno = ++employee_id;
                this.Name = name;
                this.Basic = basic;
                this.DeptNo = deptno;

            }

            public string Name
            {
                set
                {
                    if (value == null)
                    {
                        Console.WriteLine("name cannot be blanked");
                        Environment.Exit(1);
                    }
                    else
                    {
                        name = value;
                    }
                }
                get { return name; }

            }

            public int Empno
            {

                get
                {
                    return empno;
                }
            }

            public double Basic
            {
                set
                {
                    if (value > 0 && value < 100000)
                        basic = value;
                    else
                        Console.WriteLine("Invalid Basic salary");
                }
                get
                {
                    return basic;
                }
            }

            public short DeptNo
            {
                set
                {
                    if (value > 0 && value < 100)
                        deptNo = value;
                    else
                        Console.WriteLine("Invalid dept no");
                }
                get { return deptNo; }
            }

            public string toString(Employee emp)
            {
                return ("Employee    " + emp.name + " EmpNo " + Empno + "     Salary  " + emp.Basic + "      Dept  " + emp.DeptNo + "       Salary   " + emp.GetNetSalary());
            }

            public double GetNetSalary()
            {
                return this.basic * 1.4;
            }


        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(null, 10000.0, 1);
            Employee emp2 = new Employee("Ankit", 20000.0, 2);
            double salary = emp1.GetNetSalary();
            Console.WriteLine(salary.ToString());
            Console.WriteLine(emp1.toString(emp1));
            Console.WriteLine(emp2.toString(emp2));
            Console.WriteLine(emp2.Empno);
        }
    }
}