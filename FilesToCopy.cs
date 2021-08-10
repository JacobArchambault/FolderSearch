using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FolderSearch
{
    static class FilesToCopy
    {
        public static void CopyRecursively(Func<FileInfo, bool> regexFilter, int maxNumber, int cutOffDate, DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.EnumerateDirectories())
                CopyRecursively(regexFilter, maxNumber, cutOffDate, dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in FilterFiles(regexFilter, maxNumber, cutOffDate, source))
            {
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
            }
        }

        private static IEnumerable<FileInfo> FilterFiles(Func<FileInfo, bool> regexFilter, int maxNumber, int cutOffDate, DirectoryInfo source)
        {
            return source
                .EnumerateFiles()
                .Where(regexFilter)
                .Where(file => file.LastWriteTime > DateTime.Today.Subtract(TimeSpan.FromDays(cutOffDate)))
                .OrderByDescending(f => f.LastWriteTime)
                .Take(maxNumber);
        }
    }
}
