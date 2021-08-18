using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FolderSearch
{
    static class FilesToCopy
    {
        public static void CopyRecursively(Func<IEnumerable<FileInfo>, IEnumerable<FileInfo>> linqFilter, DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.EnumerateDirectories())
                CopyRecursively(linqFilter, dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.EnumerateFiles().Filter(linqFilter))
            {
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
            }
        }
    }
}
