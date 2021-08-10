using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSearch.IFilesImplementations
{
    static class SortedDirectory
    {
        public static IEnumerable<FileInfo> EnumerateFiles(IEnumerable<FileInfo> source)
        {
            return source.OrderByDescending(f => f.LastWriteTime);
        }
    }
}
