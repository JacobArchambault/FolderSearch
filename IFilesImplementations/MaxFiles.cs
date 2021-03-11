using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSearch.IFilesImplementations
{
    class MaxFiles : IFiles
    {
        readonly IFiles source;
        readonly int maxNumber;
        internal MaxFiles(IFiles source, int maxNumber)
        {
            this.source = source;
            this.maxNumber = maxNumber;
        }
        public IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directory)
        {
            return source.EnumerateFiles(directory).Take(maxNumber);
        }
    }
}
