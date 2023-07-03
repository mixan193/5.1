using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteWords(SplitText(Console.ReadLine()));
            Console.ReadKey();
        }
        private static string[] SplitText(string text)
        {
            return text.Split(' ');
        }
        private static void WriteWords(string[] text)
        {
            foreach (string word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
