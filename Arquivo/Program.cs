using System;
using System.IO;

namespace Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"E:\C#\register.txt";
            string targetPath = @"E:\C#\register2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                fileInfo.CopyTo(targetPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An erro ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}