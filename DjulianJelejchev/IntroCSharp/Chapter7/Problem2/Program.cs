using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Да се напише програма, която чете два масива от конзолата и прове­рява дали са еднакви.
            // Два масива са еднакви, когато имат еднаква дължина и стойностите на елементите в тях съответно съвпадат.Второто условие можете да проверите с for цикъл.

          Console.WriteLine("Please enter the length of the FIRST Array:");
            int f = int.Parse(Console.ReadLine());
            int[] firstArr = new int[f];

            Console.WriteLine("Please enter the length of the SECOND Array:");
            int s = int.Parse(Console.ReadLine());
            int[] secondArr = new int[s];

            if (firstArr.Length != secondArr.Length)
            {
                Console.WriteLine("Error! The FIRST Array length and the SECOND Array length are not equal. Please try again and enter EQUAL array lengths");
            }

            for (int i = 0; i <= firstArr.Length - 1; i++)
            {
                Console.WriteLine("Please enter the {0} number of FIRST array", i);
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= secondArr.Length - 1; i++)
            {
                Console.WriteLine("Please enter the {0} number of SECOND array", i);
                secondArr[i] = int.Parse(Console.ReadLine());
            }

            bool areEqual = true;
            for (int i = 0; i < secondArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    areEqual = false;
                    break;
                }
            }

            Console.WriteLine("The two arrays are equal: {0}", areEqual);
        }

    }
}
