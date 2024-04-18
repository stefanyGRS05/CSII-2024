using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 22;

            // TODO: The switch statement
            switch (theVal)
            {
                case 1:
                    Console.WriteLine("theVal is 1");
                    break;
                case 2:
                    Console.WriteLine("theVal is 2");
                    break;
                case 3:
                    Console.WriteLine("theVal is 3");
                    break;
                default:
                    Console.WriteLine("theVal is not 1, 2, or 3");
                    break;
            }

        }
    }
}
