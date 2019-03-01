using System;
class Program
{
   static void Main()
   {
        //  Напишете програма, която чете от конзолата поредица от цели числа и отпечатва най-малкото и най-голямото от тях.
        // Първо прочетете броя числа, примерно в променлива n.След това въведете n числа последователно с един for цикъл.                                                                                                                                                                  
        //Докато въвеждате всяко следващо число запазвайте в две променливи най - малкото и най - голямото число до момента.

        int lowest = 0, highest = 0, input;

        Console.Write("Enter the amount of numbers : ");
        int lenght = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Enter number: ");
            input = Int32.Parse(Console.ReadLine());
            if (i == 0) lowest = highest = input;
            else
            {
                if (lowest > input) lowest = input;
                if (highest < input) highest = input;
            }
        }
        Console.WriteLine("Lowest - {0}, Highest - {1}", lowest, highest);





    }




}

