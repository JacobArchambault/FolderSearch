﻿using FolderSearch.IFilesImplementations;
using System.IO;
namespace FolderSearch
{
    static class FilesToCopy
    {
        public static void CopyRecursively(IFiles filteredFiles, int maxNumber, DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.EnumerateDirectories())
                CopyRecursively(filteredFiles, maxNumber, dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in MaxFiles.EnumerateFiles(
                                        SortedDirectory.EnumerateFiles(
                                            filteredFiles.EnumerateFiles(
                                                source)), 
                                        maxNumber))
            {
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
            }
        }
    }
}
