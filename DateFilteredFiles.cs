using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSearch
{
    class DateFilteredFiles : IDirectory
    {
        private readonly IDirectory directory;
        
        internal DateFilteredFiles(IDirectory directory)
        {
            this.directory = directory;
        }
        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(DirectoryInfo directoryInfo)
        {
            return directory.EnumerateFileSystemInfos(directoryInfo)
                .Where(file => file.LastWriteTime > DateTime.Today.Subtract(TimeSpan.FromDays(60)) || file is DirectoryInfo);
        }
    }
}
