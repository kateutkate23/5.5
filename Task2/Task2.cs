using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Task_2
{
    internal class Task2
    {
        static string[] SplitText(string text) { return text.Split(' '); }
        static string ReverseWords(string inputPhrase)
        {
            string[] reversedText = SplitText(inputPhrase);
            string resultString = "";
            for (int i = reversedText.Length - 1; i >= 0; i--)
            {
                resultString += reversedText[i] + " ";
            }
            return resultString;
        }
        static void Main(string[] args)
        {
            string str = ReadLine();
            WriteLine(ReverseWords(str));
            ReadKey();
        }
    }
}