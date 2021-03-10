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
        public FileInfo[] GetFiles()
        {
            return source.GetFiles().OrderByDescending(f => f.LastWriteTime).ToArray();
        }
    }
}
