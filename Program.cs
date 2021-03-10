using System;
using System.IO;
namespace FolderSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            new StartDirectory(new DirectoryInfo("../../../input")).CopyFrom();
            Console.WriteLine("Hello World!");
        }
    }
}
