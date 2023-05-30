using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    internal class Task1_1
    {
        static string[] SplitText(string text)
        {
            string[] TextArr = new string[text.Length];
            string Word = "";
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    Word += text[i];
                }
                else
                {
                    TextArr[count] = Word;
                    count++;
                    Word = "";
                }
                if (i == text.Length - 1) TextArr[count] = Word;
            }
            return TextArr;
        }
        static void PrintArr(string[] text)
        {
            foreach (var e in text)
            {
                if (e != null)
                {
                    WriteLine(e);
                }
            }
        }
        static void Main(string[] args)
        {
            string str = ReadLine();
            PrintArr(SplitText(str));
            ReadKey();
        }
    }
}