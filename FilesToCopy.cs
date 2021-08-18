using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FolderSearch
{
    static class FilesToCopy
    {
        public static void CopyRecursively(Func<IEnumerable<FileInfo>, IEnumerable<FileInfo>> linqFilter, int maxNumber, DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.EnumerateDirectories())
                CopyRecursively(linqFilter, maxNumber, dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.EnumerateFiles().FilterFiles(linqFilter, maxNumber, source))
            {
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
            }
        }

        private static IEnumerable<FileInfo> FilterFiles(this IEnumerable<FileInfo> files, Func<IEnumerable<FileInfo>, IEnumerable<FileInfo>> filter, int maxNumber, DirectoryInfo source)
        {
            return filter(files)
                .OrderByDescending(f => f.LastWriteTime)
                .Take(maxNumber);
        }
    }
}
