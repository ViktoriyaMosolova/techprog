using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Text a = new Text();
            a.MainText();
        }
    }

    class Text
    {
        string[] Lines = File.ReadAllLines("C:\\Users\\1\\Desktop\\techprog\\lab4\\lab4\\test.txt", Encoding.Default);

        public void MainText()
        {
            //Read();
            RenameLink();
            //AddNumber();
        }


        public void Read()
        {
            string[] Lines = File.ReadAllLines("C:\\Users\\1\\Desktop\\techprog\\lab4\\lab4\\test.txt", Encoding.Default);

            /*foreach (string Chars in Lines)
            {
                Regex Reg = new Regex(@"[/*///]");

            /*var Query = from Chr in Chars where Reg.IsMatch(Chr.ToString()) group Chr by Chr into g select new { Char = g.Key, Count = g.Count() };

            foreach (var Pair in Query)
            {
                Console.WriteLine(String.Format($"Символ: {Pair.Char} - Количество: {Pair.Count}"));
            }
            }*/
        }
        

        public void RenameLink()
        {
            for (int i = 0; i < Lines.Length; i++)
            {
                if (Lines[i].Split(':')[0] == "https" || Lines[i].Split(':')[0] == "ftp")
                {
                    string Line = "C:";
                    foreach (string j in Lines[i].Split('/'))
                    {
                        if (j != "")
                        {
                            Line += "\\";
                            Line += j.Trim(':', '\\', '/');
                        }
                    }
                    Console.WriteLine(Line);
                }
            }
        }

        public void AddNumber()
        {

            for (int i = 0; i < Lines.Length; i++)
            {
                if (File.Exists(Lines[i]))
                {
                    string Line = Path.GetDirectoryName(Lines[i]);
                    Line += "\\";
                    Line += Path.GetFileNameWithoutExtension(Lines[i]);
                    Line += $"_{i}";
                    Line += Path.GetExtension(Lines[i]);
                    Console.WriteLine(Line);
                }
                else
                {
                    Console.WriteLine(Lines[i]);
                }

            }

        }


    }
}
