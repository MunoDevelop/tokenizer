using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    internal class Tokenizer
    {
        static string[] readFile(string[] lineList)
        {
            try
            {

                 lineList = File.ReadAllLines(@"Input.txt");
                foreach (string line in lineList)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }

            return lineList;
        }

        
    }
