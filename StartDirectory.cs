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

        public IEnumerable<FileInfo> EnumerateFiles()
        {
            try
            {
                return directoryInfo.EnumerateFiles("*.*", SearchOption.AllDirectories);
            }
            catch (DirectoryNotFoundException)
            {
                throw;
            }

        }
    }
}
