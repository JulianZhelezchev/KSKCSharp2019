using System;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            // Да се напише if конструкция, която проверява стойността на две целочислени променливи и разменя техните стойности, ако стойността на
            //първата променлива е по - голяма от втората.
            //Погледнете секцията за if конструкции.

            Console.WriteLine("Enter two numbers.");
            Console.Write("Enter first number:");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int secondnumber = int.Parse(Console.ReadLine());
            int biggerNum = firstnumber;
            if ( secondnumber>firstnumber)
            {
                biggerNum = secondnumber;
                Console.WriteLine("The second number is bigger than the first");
            }

          

        }
    }
}
