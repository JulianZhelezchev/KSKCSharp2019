using System;

namespace Problem4
{
    class Program
    {
        static void Main()
        {
//            Да се напише програма, която преобразува десетично число в двоично.
//            Правилото е "делим на 2 и долепяме остатъците в обратен ред".
//За делене с остатък използваме оператора %.Можете да се изхитрите,
//като използвате Convert.ToString(numDecimal, 2).

          
            String number = "100"; 
            int fromBase = 10;
            int toBase = 2;

            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);

            Console.WriteLine(result); // result 1100100


                


        }
    }
}
