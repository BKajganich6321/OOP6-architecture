using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.View
{
    static internal class UI
    {
        /// <summary>
        /// Display a printed Line in the console display. Begins output on a newLine
        /// </summary>
        /// <param name="lineOut"></param>
        static internal void Display(string lineOut)
        {
            Console.WriteLine(lineOut);
        }

        /// <summary>
        /// DisplayInline a printed Line in the console display. Begings output at cursors last location
        /// </summary>
        /// <param name="lineOut"></param>
        static internal void DisplayInline(string lineOut)
        {
            Console.WriteLine(lineOut);
        }

        /// <summary>
        /// GetString method which guarantees a return that has at least 1 character in its string, not exclusing ConsoleKeys
        /// </summary>
        /// <returns></returns>
        static internal string GetString()
        {
            string response = Console.ReadLine();
            while(response == "")
            {
                UI.Display("Input cannot, be empty, please try again");
                response = Console.ReadLine();
            }
            return response;
        }

        /// <summary>
        /// Confirm Overwrite. Boolean method that warnes the user that their chosen mmethod may cause conflicting and/or existing data to be overwritten
        /// Returns true after confirmation
        /// </summary>
        /// <returns></returns>
        static internal bool ConfirmOverwrite()
        {
            Display("This Operation will overwrite any currently existing data");
            Display("Please confirm or abort process with Y or abort with any other button");
            string confirm = GetKey().ToUpper();
            if(confirm == "Y")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// GetInt - Takes a string of input from the user repeatedly until the user provides input that can by parsed into a 32 bit whole integer.
        /// Negative numbers are not excluded
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// GetDouble - Takes a string of input from the user repeatedly until the user provides input that can by parsed into double
        /// Negative numbers are rejected.
        /// </summary>
        /// <returns></returns>
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


        /// <summary>
        /// GetGuid - Takes a string of input from the user. If the input can be parsed into a Guid, it is, and then that Guid is returned
        /// If the input cannot be partsed, returns an empty Guid
        /// </summary>
        /// <returns></returns>
        static internal Guid GetGuid()
        {
            ClearScreen();
            Display("Please enter the desired game's ID");          
            string guid = UI.GetString();
            if (Guid.TryParse(guid, out Guid ID))
            {
                return ID;
            }
            Display("The provided number is not a valid Guid");
            return Guid.Empty;
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
