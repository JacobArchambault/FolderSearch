using System.IO;
using System;
namespace FolderSearch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the file copier app");
            new FilesToCopy(
                new DateFilteredFiles(
                    new RegexFilteredFiles(
                        new SortedDirectory(
                            new StartDirectory()))))
                .CopyFilesRecursively(
                new DirectoryInfo(Prompt()),
                new DirectoryInfo("../../../output"));
        }

        private static string Prompt()
        {
            Console.WriteLine("Please enter the directory path you want to copy files from");
            var startDirectory = Console.ReadLine();
            while (!Directory.Exists(startDirectory))
            {
                Console.WriteLine("That directory doesn't exist. Please enter another directory path");
                startDirectory = Console.ReadLine();
            }
            return startDirectory;
        }
    }
}
