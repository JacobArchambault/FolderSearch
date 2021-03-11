﻿using FolderSearch.IDirectories;
using System;
using System.IO;

namespace FolderSearch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the file copier app");
            new FilesToCopy(
                        new SortedDirectory(
                            new DateFilteredFiles(
                                new RegexFilteredFiles(
                                    new StartDirectory(),
                                    TextResponse(
                                        "Enter text or a regex string for the file names you'd like to search for, or press enter to skip this step: ")),
                                NumberResponse(
                                    "From how many days ago would you like to keep files?",
                                    "Please enter a whole number"))))
                .CopyFilesRecursively(
                new DirectoryInfo(
                    TextResponse(
                        "Please enter the directory path you want to copy files from: ",
                        "That directory doesn't exist. Please enter another directory path")),
                new DirectoryInfo(
                    TextResponse(
                        "Enter the directory path you want to copy files to: ")));
        }

        private static string TextResponse(string toPrompt)
        {
            Console.Write(toPrompt);
            return Console.ReadLine();
        }

        private static string TextResponse(string toPrompt, string withInvalidInputMessage)
        {
            Console.WriteLine(toPrompt);
            var response = Console.ReadLine();
            while (!Directory.Exists(response))
            {
                Console.WriteLine(withInvalidInputMessage);
                response = Console.ReadLine();
            }
            return response;
        }
        private static int NumberResponse(string fromPrompt, string withErrorMessage)
        {
            Console.WriteLine(fromPrompt);
            int response;
            while (!int.TryParse(Console.ReadLine(), out response) || response < 0)
            {
                Console.WriteLine(withErrorMessage);
            }
            return response;
        }
    }
}
