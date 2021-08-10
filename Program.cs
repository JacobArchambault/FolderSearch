using System;
using System.IO;
using static FolderSearch.Prompt;
using static FolderSearch.FilesToCopy;
using System.Text.RegularExpressions;

namespace FolderSearch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the file copier app");
            try
            {
                Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Run()
        {
            string pattern = TextResponse("Enter text or a regex string for the file names you'd like to search for, or press enter to skip this step: ");
            int cutOffDate = NumberResponse("From how many days ago would you like to keep files? ");
            CopyRecursively(
                file => Regex.IsMatch(file.FullName, pattern) 
                        && file.LastWriteTime > DateTime.Today.Subtract(TimeSpan.FromDays(cutOffDate)),
                NumberResponse("How many files would you like to keep per folder? "),
                new DirectoryInfo(
                    TextResponse(
                        "Please enter the directory path you want to copy files from: ",
                        "That directory doesn't exist. Please enter another directory path",
                        Directory.Exists)),
                new DirectoryInfo(
                    TextResponse(
                        "Enter the directory path you want to copy files to: ")));
        }
    }
}
