using System;

namespace Problem3
{
    class Program
    {
        static void Main()
        {
            //Напишете израз, който да проверява дали третата цифра(отдясно на ляво) на дадено цяло число е 7.
            // Разделете числото на 100 и го запишете в нова променлива. Нея разделете на 10 и вземете остатъкът.Остатъкът от делението на 10 е третата цифра от първоначалното число. Проверете равна ли е на 7.

            int number = 45764;
            bool isSeven = (number / 100) % 10 == 7 ? true : false;
            Console.WriteLine("Third digit of {0} is 7", number, isSeven);

        }
    }
}
