using System;

namespace ConsoleApp1
{
    class Program
    {
        // Напишете метод, който при подадено име отпечатва на конзолата  "Hello, <name>!" (например "Hello, Peter!")
        // Напишете програма, която тества дали този метод работи правилно.
        // Използвайте метод с параметър string

        static void Main(string[] args)
        {
            Console.Write("Please enter your name:");
            SayHello(Console.ReadLine());
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello,{0}!", name);
        }

        

    }
}
