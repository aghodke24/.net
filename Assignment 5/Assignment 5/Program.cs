using System.Collections;

namespace Assignment_5
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
        static void Main1(string[] args)
        {
            Hashtable obj = new Hashtable();
            Console.WriteLine("Enter the number of employee");
            int n = Convert.ToInt32(Console.ReadLine());
            decimal max = 0;
            int e = 0;
            for (int i = 0; i < n; i++)
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
                obj.Add(i, new Employee(name, basic, deptno));
            }


            foreach (Employee emp in obj)
            {
                Console.WriteLine(emp.Name + "  " + emp.Empno + "  " + emp.Basic + "  " + emp.Deptno);
            }
        }
        static void Main()
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

            List<Employee> list = new ArrayList<Employee>();
            list.AddRange(emp);
            //foreach (Employee emp1 in list)
            //{
            //    Console.WriteLine(emp1.Name + "  " + emp1.Empno + "  " + emp1.Basic + "  " + emp1.Deptno);
            //}

            Employee[] emp2 = new Employee[emp.Length];
            emp2 = list.ToArray();
            foreach (Employee e1 in emp2)
            {
                Console.WriteLine(e1.Name + "  " + e1.Empno + "  " + e1.Basic + "  " + e1.Deptno);
            }
        }
    }
}