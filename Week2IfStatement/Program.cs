using System;
using System.Threading.Tasks.Dataflow;

namespace Week2IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1;
            int N2;
           

            Console.WriteLine("Write first number.");
            string Num1 = Console.ReadLine();
            N1 = Int32.Parse(Num1);

            if (N1 < 0)
                Console.WriteLine("This number is negative.");
            else if (N1 > 0)
                Console.WriteLine("This number is positive.");
            else Console.WriteLine("This number is 0.");
                   
            



                
        }
    }
}
