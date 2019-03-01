using System;

namespace Problem1

{
    class Program
    {
        static void Main()
        {
            // Напишете програма, която отпечатва на конзолата числата от 1 до N. 
            //Числото N трябва да се чете от стандартния вход.
            // 1.Използвайте for цикъл.


            Console.Write("Enter n = ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)

            {

                Console.WriteLine(i);

            }





        }
    }



    

}
