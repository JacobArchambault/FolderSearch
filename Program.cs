using System;
using System.IO;
using System.Text.RegularExpressions;
namespace FolderSearch
{
    class Program
    {
        static void Main()
        {
            var foo = new RegexFilteredFiles(
                new SortedDirectory(
                    new StartDirectory(
                        new DirectoryInfo("../../../input")))).GetFiles();
            foreach(var file in foo)
            {
                Console.WriteLine(file.FullName);
            }
        }
    }
}
