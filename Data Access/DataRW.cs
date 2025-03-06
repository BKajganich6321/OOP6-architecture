﻿using OOP_A06_Architecture.View;
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

        void WriteOutput(string gameData, string fileName)
        {
            try
            {
                outputFile = new FileStream(fileName, FileMode.Append);
                writer = new StreamWriter(outputFile);
                writer.Write(gameData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                }
                if (writer != null)
                {
                    writer.Close();
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameData"></param>
        /// <returns></returns>
        string ReadOutput(string fileName)
        {
            string gameRecords = "";
            try
            {
                outputFile = new FileStream(fileName, FileMode.Open);
                reader = new StreamReader(outputFile);
                gameRecords = reader.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                if (fileName != null)
                {
                    outputFile.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}
