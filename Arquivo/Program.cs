using System;
using System.IO;
using System.Collections.Generic;

namespace Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\C#\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message);
            }
        }
    }
}