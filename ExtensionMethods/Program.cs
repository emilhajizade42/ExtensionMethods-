using System;

namespace ExtensionMethods.Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var word = "salam";
            var word1 =  word.CustomContains('s');
            var word2 = word.CustomContains("alza");

            Console.WriteLine(word1);
            Console.WriteLine(word2);

            var num = 13 ;
            var num2 = num.IsPrime();

            Console.WriteLine(num2);
        }
    }
}
