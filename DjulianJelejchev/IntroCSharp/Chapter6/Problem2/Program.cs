using System;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
            //  Напишете програма, която отпечатва на конзолата числата от 1 до N, които не се делят едновременно на 3 и 7.
            //Числото N да се чете от стандартния вход.
            // Използвайте for цикъл и оператора % за намиране на остатък при целочислено деление.
            //Едно число num не се дели на 3 и на 7 едновременно, ако(num % (3 * 7) == 0).

            Console.WriteLine("Please enter your number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                else if (i % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine("{0} ", i);
            }

        }
    }
}
