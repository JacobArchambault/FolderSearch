using System;
using System.Collections.Generic;
using System.IO;

namespace FolderSearch
{
    public static class FilesExtensions
    {
        public static IEnumerable<FileInfo> Filter(this IEnumerable<FileInfo> files, Func<IEnumerable<FileInfo>, IEnumerable<FileInfo>> filter)
        {
            return filter(files);
        }

    }
}
