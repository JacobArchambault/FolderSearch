using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSearch.IFilesImplementations
{
    class SortedDirectory : IFiles
    {
        readonly IFiles source;
        internal SortedDirectory(IFiles source)
        {
            this.source = source;
        }
        public IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directory)
        {
            return source.EnumerateFiles(directory).OrderByDescending(f => f.LastWriteTime);
        }
    }
}
