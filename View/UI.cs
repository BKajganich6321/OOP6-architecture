using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.View
{
    static internal class UI
    {
        static internal void Display(string lineOut)
        {
            Console.WriteLine(lineOut);
        }
        static internal void DisplayInline(string lineOut)
        {
            Console.WriteLine(lineOut);
        }
        static internal string GetString()
        {
            return Console.ReadLine();
        }
        static internal string GetKey()
        {
            return Console.ReadLine();
        }
        static internal void NewLine()
        {
            Console.WriteLine();
            return;
        }
        static internal void ClearScreen()
        {
            Console.Clear();
        }
    }
}
