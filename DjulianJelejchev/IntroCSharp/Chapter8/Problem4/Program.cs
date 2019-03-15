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


            / Convert to binary system
            Console.Write("Please, enter a number to convert to binary: ");
            // with 340282366920938000000000000000000000000
            // System.OverflowException: Value was either too large or too small for an Int32.
            int number2Convert = int.Parse(Console.ReadLine());
            int[] binaryNumber = new int[128]; // the default value is 0
            int digitCounter = 127;
            while (number2Convert > 0 && digitCounter > 0)
            {
                binaryNumber[digitCounter] = number2Convert % 2;
                digitCounter--;
                number2Convert /= 2;
                Console.WriteLine(number2Convert);
            }
            foreach (var digit in binaryNumber)
            {
                Console.Write(digit);
            }
            Console.WriteLine();
            Console.WriteLine(Math.Pow(2, 128)); // 3.40282366920938E+38
            // Console.WriteLine("{0,10:N}", Math.Pow(2, 128)); // 340,282,366,920,938,000,000,000,000,000,000,000,000.00
            // Console.WriteLine("{0,10:D}", Math.Pow(2, 128)); // Exception
            Console.WriteLine("{0,10:F0}", Math.Pow(2, 128)); // 340282366920938000000000000000000000000




        }
    }
}
