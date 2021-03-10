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
        public FileInfo[] EnumerateFiles()
        {
            return source.EnumerateFiles().OrderByDescending(f => f.LastWriteTime).ToArray();
        }
    }
}
