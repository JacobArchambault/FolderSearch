using FolderSearch.IFilesImplementations;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FolderSearch
{
    static class FilesToCopy
    {
        public static void CopyRecursively(string regexFilter, int maxNumber, int cutOffDate, DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.EnumerateDirectories())
                CopyRecursively(regexFilter, maxNumber, cutOffDate, dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in MaxFiles.EnumerateFiles(
                                        source
                                            .EnumerateFiles()
                                            .Where(file => Regex.IsMatch(file.FullName, regexFilter))
                                            .Where(file => file.LastWriteTime > DateTime.Today.Subtract(TimeSpan.FromDays(cutOffDate)))
                                            .OrderByDescending(f => f.LastWriteTime), 
                                        maxNumber))
            {
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
            }
        }
    }
}
