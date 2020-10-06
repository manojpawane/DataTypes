using System;

namespace DataTypes
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            //testing the sample code
            //testing 
            int ch = 0;
            do
            {
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplication");
                Console.WriteLine("5. Exit..");
                ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1: Console.WriteLine("Add");
                        break;
                    case 2:
                        Console.WriteLine("Substraction");
                        break;
                    case 3:
                        Console.WriteLine("Divsion");
                        break;
                    case 4:
                        Console.WriteLine("Multiplication");
                        break;
                }
            }
            while (ch != 5);
            
        }
    }
}
