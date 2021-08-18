using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FolderSearch
{
    static class FilesToCopy
    {
        public static void CopyRecursively(Func<FileInfo, bool> regexFilter, int maxNumber, DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.EnumerateDirectories())
                CopyRecursively(regexFilter, maxNumber, dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.EnumerateFiles().FilterFiles(regexFilter, maxNumber, source))
            {
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
            }
        }

        private static IEnumerable<FileInfo> FilterFiles(this IEnumerable<FileInfo> files, Func<FileInfo, bool> filter, int maxNumber, DirectoryInfo source)
        {
            return files
                .Where(filter)
                .OrderByDescending(f => f.LastWriteTime)
                .Take(maxNumber);
        }
    }
}
