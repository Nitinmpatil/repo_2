using System;

namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do
            //{
            //    Console.WriteLine("1. New File");
            //    Console.WriteLine("2. Open File");
            //    Console.WriteLine("3. Save File");
            //    Console.WriteLine("4. Save As File");
            //    Console.WriteLine("5. Exit");

            //    int option = Convert.ToInt32(Console.ReadLine());

            //    if(option >= 1 && option <=5)
            //    {
            //        Console.WriteLine("Correct Option");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Choose a correct option");
            //    }
            //}while(true);

            //Console.ReadKey();
            //Console.WriteLine();
            int x = 100;
            do
            {
                Console.WriteLine("X is: {0}", x);
                x = x - 1;
            } while (x > 0);
        }
    }
}
