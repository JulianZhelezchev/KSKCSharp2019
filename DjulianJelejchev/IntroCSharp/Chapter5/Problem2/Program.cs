using System;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("You can enter  0 or any positive or any negative number and I will tell you whether the result of their multiplication will be a positive or a negative number or zero.");
            Console.Write(" Please,enter the first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write(" Please, enter the second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write(" Please, enter the third number: ");
            int c = Int32.Parse(Console.ReadLine());

            if (a < 0 & b < 0 & c < 0)
            {
                Console.WriteLine("The sign is -");
            }
            else if (a < 0 & b > 0 & c > 0)
            {
                Console.WriteLine("The sign is - ");
            }
            else if (c < 0 & a > 0 & b > 0)
            {
                Console.WriteLine("The sign is -");
            }

            else if (b < 0& c > 0 & a > 0)
            {
                Console.WriteLine("The sign is - ");
            }

            else if (a > 0 & b > 0 & c > 0)
            {
                Console.WriteLine("The sign is + ");
            }
            else if (a <0 & b <0 & c>0)

            {
                Console.WriteLine("The sign is + ");
            }
            else if (b <0 & c<0 & a>0)
            {
                Console.WriteLine("The sign is + ");
            }

            else if (c<0 & a<0 & b>0)
            {
                Console.WriteLine("The sign is + ");
            }

            else if (a>=0 & b>=0 & c>=0)
               Console.WriteLine("The result is zero");








        }
    }
}