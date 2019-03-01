using System;

namespace Problem1
{
    class Program
    {
        static void Main()
        {


            // 1.Напишете израз, който да проверява дали дадено цяло число е четно или нечетно.

// Вземете остатъкът от деленето на числото на 2 и проверете дали е 0 или 1(съответно числото е четно или нечетно).Използвайте оператора % за пресмятане на остатък от целочислено деление.

            
                int number = 23;
                bool even = number % 2 == 0 ? true : false;
                Console.WriteLine("{0} is even? {1}", number, even);
            
        }
    }
}
