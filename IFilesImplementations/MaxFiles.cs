using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSearch.IFilesImplementations
{
    static class MaxFiles
    {
        public static IEnumerable<FileInfo> EnumerateFiles(IFiles source, DirectoryInfo directory, int maxNumber)
        {
            return source.EnumerateFiles(directory).Take(maxNumber);
        }
    }
}
