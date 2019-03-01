using System;

namespace Problem2
{
    class Program
    {
        static void Main()
        {
           // 2.Напишете булев израз, който да проверява дали дадено цяло число се дели на 5 и на 7 без остатък.

// Ползвайте логическо "И"(оператора &&) и операцията % за остатък при деление.Можете да решите задачата и чрез само една проверка – за деление на 35(помислете защо).


                int number = 36;
                bool divisible = number % 35 == 0 ? true : false;
                Console.WriteLine("{0} is divisible by both 5 and 7? {1}", number, divisible);
            
        }
    }
}
