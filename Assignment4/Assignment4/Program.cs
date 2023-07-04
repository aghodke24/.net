namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of cdac batch");
            int size = Convert.ToInt32(Console.ReadLine());
            int[][] cdac = new int[size][];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the number of students in bacth [{i}]");
                int students = Convert.ToInt32(Console.ReadLine());
                cdac[i] = new int[students];
                for (int j = 0; j < students; j++)
                {
                    Console.WriteLine("Enter the marks for student");
                    cdac[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"The Number of students for batch cdac[{i}] is ");
                for (int j = 0; j < cdac[i].Length; j++)
                {
                    Console.WriteLine(cdac[i][j]);
                }
            }
        }
    }
}