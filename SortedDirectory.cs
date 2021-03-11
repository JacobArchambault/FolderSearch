using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSearch
{
    class SortedDirectory : IDirectory
    {
        readonly IDirectory source;
        internal SortedDirectory(IDirectory source)
        {
            this.source = source;
        }
        public IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directory)
        {
            return source.EnumerateFiles(directory).OrderByDescending(f => f.LastWriteTime);
        }
    }
}
