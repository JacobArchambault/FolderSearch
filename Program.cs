using System;
using System.IO;
namespace FolderSearch
{
    class Program
    {
        static void Main()
        {
            var foo = new DateFilteredFiles(
                new RegexFilteredFiles(
                    new SortedDirectory(
                        new StartDirectory()))).EnumerateFileSystemInfos(new DirectoryInfo("../../../input"));
            foreach(var file in foo)
            {
                Console.WriteLine(file.FullName);
            }
        }
    }
}
