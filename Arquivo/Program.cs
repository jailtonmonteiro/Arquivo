using System;
using System.IO;

namespace Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\C#\register.txt";
            
            using(FileStream fs = new FileStream(path, FileMode.Open)){
                using(StreamReader sr = new StreamReader(fs)){
                    while(!sr.EndOfStream){
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}