using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FolderSearch
{
    class RegexFilteredFiles : IDirectory
    {
        private readonly IDirectory source;
        internal RegexFilteredFiles(IDirectory source)
        {
            this.source = source;
        }
        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos()
        {
            return source.EnumerateFileSystemInfos().Where(file => Regex.IsMatch(file.FullName, ".*.txt"));
        }
    }
}
