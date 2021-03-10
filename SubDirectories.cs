using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSearch
{
    class SubDirectories : IDirectory
    {
        readonly IDirectory source;
        internal SubDirectories(IDirectory source)
        {
            this.source = source;
        }
        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(DirectoryInfo directory)
        {
            return source.EnumerateFileSystemInfos(directory)
                .Where(x => x is DirectoryInfo);
        }
    }
}
