
using System.Runtime.InteropServices;

namespace Assignment4._2
{
    internal class Program
    {
        public class Employee
        {
            protected string name;
            protected int empno;
            protected decimal basic;
            protected short deptno;
            protected static int no = 0;

            public Employee(string name, decimal basic, short deptno)
            {
                this.name = name;
                this.basic = basic;
                this.empno = ++no;
                this.deptno = deptno;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public decimal Basic
            { get { return basic; } set { basic = value; } }
            public short Deptno
            { get { return deptno; } set { deptno = value; } }

            public int Empno
            {
                get { return empno; }
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employee");
            int number = Convert.ToInt32(Console.ReadLine());
            Employee[] emp = new Employee[number];

            decimal max = 0;
            int e = 0;

            for (int i = 0; i < emp.Length; i++)
            {

                Console.WriteLine("Enter the name of employee");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the basic salary of employee");
                decimal basic = Convert.ToDecimal(Console.ReadLine());
                if (basic > max)
                {
                    max = basic;
                    e = i;
                }
                Console.WriteLine("Enter the deptno");
                short deptno = Convert.ToSByte(Console.ReadLine());
                emp[i] = new Employee(name, basic, deptno);
            }
            for (int j = 0; j < emp.Length; j++)
            {
                Console.WriteLine(emp[j].Name + "  " + emp[j].Empno + "  " + emp[j].Deptno + "  " + emp[j].Basic);
            }


            Console.WriteLine("Employee having maximum salary is");
            Console.WriteLine(emp[e].Name + "  " + emp[e].Empno + "  " + emp[e].Deptno + "  " + emp[e].Basic);


            Console.WriteLine("Enter the employee number to be search");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(emp[no - 1].Name + "  " + emp[no - 1].Empno + "  " + emp[no - 1].Deptno + "  " + emp[no - 1].Basic);
        }
    }
}