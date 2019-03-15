using System;

namespace Problem2
{
    class Program
    {   //Създайте метод GetMax() с два целочислени (int) параметъра, който ръща по-голямото от двете числа.
        // Напишете програма, която прочита три цели числа от конзолата и отпечатва най - голямото от тях, използвайки метода GetMax().
        // Използвайте свойството Max(a, b, c) = Max(Max(a, b), c).
       
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Insert 3 numbers to compare them:");

        //    int a = int.Parse(Console.ReadLine());
        //    int b = int.Parse(Console.ReadLine());

        //    int c = int.Parse(Console.ReadLine());

        //    Console.Write("The bigest of three is: ");
        //    Console.WriteLine(GetMax(GetMax(a, b), c));
        //}
        //static int GetMax(int a, int b)
        //{
        //    return a > b ? a : b;
        //}

        //{
        static int a;

        static void GetMax(int first, int second)
        {
            if (first > second) a = first;
            else a = second;
        }

        static void 
            Main(string[] args)
        {
            Console.Write("Enter first number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            GetMax(a, b);
            GetMax(a, c);
           

            Console.WriteLine("Biggest number is {0}", a);
        }
    }
}
