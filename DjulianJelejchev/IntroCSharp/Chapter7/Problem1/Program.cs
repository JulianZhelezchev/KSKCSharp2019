using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която създава масив с 20 елемента от целочислен тип и инициализира всеки от елементите със стойност равна на индекса на елемента умножен по 5.
            //Елементите на масива да се изведат на конзолата.
            //Използвайте масив int[] и for цикъл.

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.Write("Output: ");

            for (int index = 0; index < array.Length; index++)

            {

                //Multiply the number by 5

                array[index] = 5 * array[index];

                //Print the number

                Console.Write(array[index] + " ");

            }
        }
    }
}
