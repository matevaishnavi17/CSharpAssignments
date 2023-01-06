using System;
using System.IO;
namespace CSharpAssignmnet7
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\VGANESHM\source\repos\CSharpAssignmnet7";

            var dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);//for getting directories
            var files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);//for getting files

            Console.WriteLine("-----Displaying directories-----");
            foreach (string dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"{dirInfo.FullName}");
            }
            Console.WriteLine("\n-----Displaying all .txt files-----");
            foreach (string file in files)
            {
                var fileInfo = new FileInfo(file);
                Console.WriteLine($"{Path.GetFileName(file)} - { fileInfo.Length } bytes");
            }
        }
    }
}
