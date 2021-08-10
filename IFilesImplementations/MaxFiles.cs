using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSearch.IFilesImplementations
{
    static class MaxFiles
    {
        public static IEnumerable<FileInfo> EnumerateFiles(IEnumerable<FileInfo> source, int maxNumber)
        {
            return source.Take(maxNumber);
        }
    }
}
