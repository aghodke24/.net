namespace day3Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
namespace Assignment3
{

    internal abstract class Employee
    {
        public static int empNo;
        private string name;
        private short deptNo;
        private decimal baseSalary;
        private int empID;

        public Employee(String name, short deptNo = 0, decimal baseSalary = 0)
        {
            this.empID = ++empNo;
            this.name = name;
            this.deptNo = deptNo;
            this.baseSalary = baseSalary;
        }


        public decimal BaseSalary
        {
            get { return baseSalary; }
            set
            {
                if (value > 0 && value > 1000000)
                    baseSalary = value;
                else
                    Console.WriteLine("Enter proper base salary");
            }
        }
        public short DeptNo
        {
            get
            {
                return deptNo;
            }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("valus should be greather than zero");
            }
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 0)
                    name = value;
                else
                    Console.WriteLine("name can't be null");
            }
        }

        public abstract decimal GetNetSalary(decimal basic);



    }

    internal class Manager : Employee
    {
        private string designation;
        public string Designation
        {
            get
            {
                return designation;
            }
            set
            {
                if (value.Length > 0)
                    designation = value;
                else Console.WriteLine("Designation can't be null");
            }
        }

        public Manager(string name, short deptNo, decimal baseSalary, string designation) : base(name, deptNo, baseSalary)
        {
            this.Designation = Designation;
        }

        //Override method
        public override decimal GetNetSalary(decimal basic)
        {
            //Net salary for Manager
            return BaseSalary * (decimal)0.2;
        }
    }

    internal class GeneralManager : Manager
    {
        string Perks { get; set; }

        public GeneralManager(string name, short deptNo, decimal baseSalary, string designation) : base(name, deptNo, baseSalary, designation)
        {
            this.Perks = Perks;
        }
    }

    internal class CEO : Employee
    {
        public CEO(string name, short deptNo = 0, decimal baseSalary = 0) : base(name, deptNo, baseSalary)
        {

        }

        // sealed : this method can't be override further more
        public sealed override decimal GetNetSalary(decimal basic)
        {
            return 2;
        }
    }
    interface IDbFunctions
    {
        public string insert();
        public string update();
        public string delete();
    }
}