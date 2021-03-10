using System;
using System.Collections.Generic;
using System.IO;

namespace FolderSearch
{
    class StartDirectory : IDirectory
    {
        public StartDirectory()
        {
        }

        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(DirectoryInfo directoryInfo)
        {
            try
            {
                return directoryInfo.EnumerateFileSystemInfos();
            }
            catch (DirectoryNotFoundException)
            {
                throw;
            }

        }
    }
}
