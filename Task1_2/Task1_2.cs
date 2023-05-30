using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2
{
    internal class Task1_2
    {
        static string[] SplitText(string text) { return text.Split(' '); }
        static void PrintArr(string[] text) { foreach (var e in text) WriteLine(e); }
        static void Main(string[] args)
        {
            string str = ReadLine();
            PrintArr(SplitText(str));
            ReadKey();
        }
    }
}