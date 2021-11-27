using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\USER\Desktop\ИТМО\Lab8\Task8.1\Task8.1\bin\Debug";

            string[] allFolders = Directory.GetDirectories(path);
            string[] allFiles = Directory.GetFiles(path);
            foreach (string files in allFiles)
            {
                Console.WriteLine(files);
            }
            foreach (string folder in allFolders)
            {
                Console.WriteLine();
                Console.WriteLine(folder + ":");
                allFiles = Directory.GetFiles(folder, "*.*");
                foreach (string file in allFiles)
                {
                    Console.WriteLine(file);
                }
            }
            Console.ReadKey();
        }
    }

}
