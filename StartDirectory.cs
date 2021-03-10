using System;
using System.Collections.Generic;
using System.IO;

namespace FolderSearch
{
    class StartDirectory : IDirectory
    {
        private readonly DirectoryInfo directoryInfo;
        public StartDirectory(DirectoryInfo directoryInfo)
        {
            this.directoryInfo = directoryInfo;
        }

        public IEnumerable<FileSystemInfo> EnumerateFiles()
        {
            try
            {
                var foo = directoryInfo.EnumerateFileSystemInfos("*", SearchOption.AllDirectories);
                return foo;
            }
            catch (DirectoryNotFoundException)
            {
                throw;
            }

        }
    }
}
