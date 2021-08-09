using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSearch.IFilesImplementations
{
    class MaxFiles
    {
        readonly IFiles source;
        internal MaxFiles(IFiles source)
        {
            this.source = source;
        }
        public IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directory, int maxNumber)
        {
            return source.EnumerateFiles(directory).Take(maxNumber);
        }
    }
}
