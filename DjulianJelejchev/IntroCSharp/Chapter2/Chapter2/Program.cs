using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {            

            Console.WriteLine(DateTime.Now);

            string name1 = "Exercise 1";
            Console.WriteLine(name1);

            byte firstNum = 97;
            Console.WriteLine(firstNum);

            sbyte secondNum = 112;
            Console.WriteLine(secondNum);

            byte thirdNum = 224;
            Console.WriteLine(thirdNum);

            ushort forthNum = 1990;
            Console.WriteLine(forthNum);

            ushort fifthNum = 52130;
            Console.WriteLine(fifthNum);

            ushort sixthNum = 20000;
            Console.WriteLine(sixthNum);

            uint seventhNum = 4825932;
            Console.WriteLine(seventhNum);

            uint eigthNum = 970700000;
            Console.WriteLine(eigthNum);

            ulong ninthNum = 123456789123456789;
            Console.WriteLine(ninthNum);

            int tenthNum = -1000000;
            Console.WriteLine(tenthNum);

            short eleventhNum = -10000;
            Console.WriteLine(eleventhNum);

            sbyte twelfthNum = -115;
            Console.WriteLine(twelfthNum);

            sbyte thirtenthNum = -44;
            Console.WriteLine(thirtenthNum);


            string name2 = "Exercise 2";
            Console.WriteLine(name2);

            float floatY = 12.345F;
            Console.WriteLine(floatY);

            double mydoublex = 34.567839023;
            Console.WriteLine(mydoublex);

            double mydoubley = 8923.1234857;
            Console.WriteLine(mydoubley);

            decimal decnum = 3456.0911248759565421512566683467M;
            Console.WriteLine(decnum);

            string name3 = "Exercise 3 ";
            Console.WriteLine(name3);

            decimal number1 = 5.25745243896m;
            decimal number2 = 9.8544531763m;
            number1 += number2;
            Console.WriteLine(number1.ToString("#.######"));

            string name4 = "Exercise 4";
            Console.WriteLine(name4);


            int numberInHex; //declare
            numberInHex = 0x100; // initiliaze
            Console.WriteLine(numberInHex);

            int intValue2 = 0x100;
            Console.WriteLine(intValue2);

            int decn, q, dn = 0, m, l;
            int tmp;
            int s;

            Console.Write("\n\n");
            Console.Write("Convert a number in decimal to hexadecimal:\n");
            Console.Write("---------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input  any Decimal number:");
            decn = Convert.ToInt32(Console.ReadLine());
            q = decn;
            for (l = q; l > 0; l = l / 16)
            {
                tmp = l % 16;
                if (tmp < 10)
                    tmp = tmp + 48;
                else
                    tmp = tmp + 55;
                dn = dn * 100 + tmp;
            }
            Console.Write("\nThe equivalent Hexadecimal Number : ");
            for (m = dn; m > 0; m = m / 100)
            {
                s = m % 100;
                Console.Write("{0}", (char)s);
            }
            Console.Write("\n\n");

            // Store integer 256
            int intValue = 256;
            // Convert integer 256 as a hex in a string variable
            string hexValue = intValue.ToString("X");
            // Convert the hex string back to the number
            int intAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);

        }
    }
}
