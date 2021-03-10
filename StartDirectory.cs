using System;
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

        public FileInfo[] GetFiles()
        {
            try
            {
                return directoryInfo.GetFiles("*.*", SearchOption.AllDirectories);
            }
            catch (DirectoryNotFoundException)
            {
                throw;
            }

        }
    }
}
