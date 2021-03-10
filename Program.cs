using System;
using System.IO;
namespace FolderSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new StartDirectory(new DirectoryInfo("../../../input")).CopyFrom();
            Console.WriteLine("Hello World!");
        }
    }
}
