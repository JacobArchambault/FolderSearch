﻿using System.IO;
using System;
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
                                    Prompt("Enter text or a regex string for the file names you'd like to search for, or press enter to skip this step: ")), 
                                60)))
                .CopyFilesRecursively(
                new DirectoryInfo(
                    Prompt(
                        "Please enter the directory path you want to copy files from: ",
                        "That directory doesn't exist. Please enter another directory path")),
                new DirectoryInfo(
                    Prompt(
                        "Enter the directory path you want to copy files to: ")));
        }

        private static string Prompt(string promptMessage)
        {
            Console.Write(promptMessage);
            return Console.ReadLine();
        }

        private static string Prompt(string promptMessage, string invalidInputMessage)
        {
            Console.WriteLine(promptMessage);
            var response = Console.ReadLine();
            while (!Directory.Exists(response))
            {
                Console.WriteLine(invalidInputMessage);
                response = Console.ReadLine();
            }
            return response;
        }
    }
}
