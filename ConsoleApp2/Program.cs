using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("the longest word is:");
            Console.WriteLine(a.MyfunctionA("Ada Lovelace wrote the first algorithm designed for processing by an Analytical Engine."));
        }

        public MyFunctionA(string input)
        {
            string[] words = input.Split('');
            int wordArrayLength = words.Length;
            int[] wordsLength = new int[wordArrayLength];
            int x = 0;
        }
    
    }
}
