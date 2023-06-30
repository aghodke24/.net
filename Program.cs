namespace day1assignment
{
    internal class Program
    {
        static void Main()
        {
            
            Employee emp = new Employee();

            Console.WriteLine("Enter Employee Name");
            emp.Name = Console.ReadLine();

            Console.WriteLine("Enter Employee Id");
            emp.Id = Convert.ToInt32(Console.Read());

            Console.WriteLine("Enter Basis Salary");
            emp.Basic = Convert.ToDecimal(Console.Read());

            Console.WriteLine("Enter the Department Number");
            emp.DeptNo = Convert.ToInt16(Console.Read());


            Console.WriteLine("Employee name is : " + emp.Name + " Id is : " + emp.Id + "Basic Salary is :" + emp.Basic + "Depertment Number is :" + emp.DeptNo);

        }
    }

    class Employee
    {
        private int id;
        private string name;
        private decimal basic;
        private short deptNo;

        public int Id
        {
            get
            { return id; 
            }
            set
            {
                if (value > 0)
                    id = value;
                else
                    Console.WriteLine("id should be greater than 0");
            }
        }
        public string Name
        {
            get
            { return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("name should not be null or empty");
                else
                    name = value;
            }

        }

        public decimal Basic
        {
            get
            { return basic;
            }
            set
            {
                if (value > 10000 && value < 25000)
                    basic = value;
                else
                    Console.WriteLine("Basic Salary should be between 10000 & 25000 ");
            }
        }

        public short DeptNo
        {
            get
            { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Departement number must be greater then 0");
            }
        }

    }

}


