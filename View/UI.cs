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
            string response = "";


            return Console.ReadLine();
        }
        static internal int GetInt()
        {
            int value;
            string userInput = Console.ReadLine();
            while (!Int32.TryParse(userInput, out value))   
            {
                Console.WriteLine("Reposnse much be an whole number. Press any key to try again\n");
                userInput = Console.ReadLine();
            }
            return value;
        }
        static internal double GetDouble()
        {
            double value = 0;
            string userInput = Console.ReadLine();
            while (!Double.TryParse(userInput, out value) || value <= 0)
            {
                Console.WriteLine("Reposnse much be a postive number. Please try again\n");
                userInput = Console.ReadLine();
            }
            return value;
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
