using System;
using System.IO;
namespace FolderSearch
{
    class Program
    {
        static void Main()
        {
            var foo = new SortedDirectory(new StartDirectory(new DirectoryInfo("../../../input"))).GetFiles();
            Console.WriteLine("Hello World!");
        }
    }
}
