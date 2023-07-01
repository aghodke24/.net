using System.Transactions;

namespace Assignments2
{
    internal class Program
    {
        static void Main()
        {
            StudentDetails.Student s = new StudentDetails.Student("Ankit", 100, 56324);
            StudentDetails.Student s1 = new StudentDetails.Student("Adwait", 201, 10024);
            s.Display();
            Console.WriteLine(s1.GetNetSalary(56324));
            s1.Display();
        }
    }
}
//add class dept
namespace StudentDetails
{
    /* internal class Depertment
     {
         public int DeptNo { get; set; }

         static void Main(string[] args)
         {
             Depertment depert = new Depertment();
             Console.WriteLine("Enter dept no");
             depert.DeptNo = Convert.ToInt32(Console.ReadLine());
         }
     }*/
    internal class Student
    {
        public static int empNo;
        private string name;
        private short deptNo;
        private decimal baseSalary;
        private int empID;

        public Student(String name, short deptNo = 0, decimal baseSalary = 0)
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

        public decimal GetNetSalary(decimal basic)
        {
            return basic * (decimal)1.6;
        }

        public void Display()
        {
            Console.WriteLine(this.empID + " " + this.Name + " " + this.DeptNo + " " + this.BaseSalary);
        }
    }
}


