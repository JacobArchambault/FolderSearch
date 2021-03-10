using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
