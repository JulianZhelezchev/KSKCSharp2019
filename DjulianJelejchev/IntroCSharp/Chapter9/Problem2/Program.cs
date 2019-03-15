using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Създайте метод GetMax() с два целочислени (int) параметъра, който ръща по-голямото от двете числа.
           // Напишете програма, която прочита три цели числа от конзолата и отпечатва най - голямото от тях, използвайки метода GetMax().
           // Използвайте свойството Max(a, b, c) = Max(Max(a, b), c).
            Console.Write("Please enter the first number:");
            int firstnum = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number:");
            int secondnum = int.Parse(Console.ReadLine());
            Console.Write("Please enter the third number:");
            int thirdnum = int.Parse(Console.ReadLine());
           

            GetMax(firstnum,secondnum,thirdnum);
        }
        static void GetMax(int number1, int number2, int number3)
        {
            
            
            if (number1 > number2&& number1>number3 )
            {
                Console.WriteLine("The first number is the biggest of all");

            }
            else if (number2 >number1&& number2> number3 )
            {
                Console.WriteLine("The second number is the biggest of all");

            }
            else if (number3 > number2 && number3 > number2)
            {
                Console.WriteLine("The third number is the biggest of all");
            }


        }



    }
}
     
    

