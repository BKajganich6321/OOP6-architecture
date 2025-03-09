using OOP_A06_Architecture.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A06_Architecture.Data_Access
{
    internal class DataRW
    {
        //initialize variables to read/write to file
        FileStream outputFile = null;
        StreamReader reader = null;
        StreamWriter writer = null;   

        /// <summary>
        /// WriteOutput - Opens FileStream and writer and writes "gameData" into the file
        ///               Catches any exceptions and then closes the writer and strema
        /// </summary>
        /// <param name="gameData"></param>
        /// <param name="fileName"></param>
        internal void WriteOutput(string gameData, string fileName)
        {
            try
            {
                outputFile = new FileStream(fileName, FileMode.OpenOrCreate);
                writer = new StreamWriter(outputFile);
                writer.Write(gameData);
            }
            catch (Exception ex)
            {
                UI.Display(ex.ToString());
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
                if (outputFile != null)
                {
                    outputFile.Close();
                }
              
            }

        }

        /// <summary>
        /// ReadOutput - Opens the FileStream and Reader, reads the file onto a string and returns that string after
        ///              closing the reader and stream, respectively
        /// </summary>
        /// <param name="gameData"></param>
        /// <returns></returns>
        internal string ReadOutput(string fileName)
        {
            string gameData = "";
            try
            {
                outputFile = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
                reader = new StreamReader(outputFile);
                gameData = reader.ReadToEnd();
            }
            catch (Exception e)
            {
                UI.Display(e.ToString());
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (fileName != null)
                {
                    outputFile.Close();
                }
            }
            return gameData;
        }
    }
}
