using System.Collections.Generic;
using System.IO;

namespace FolderSearch.IDirectories
{
    class StartDirectory : IDirectory
    {
        public StartDirectory()
        {
        }

        public IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directoryInfo)
        {
            try
            {
                return directoryInfo.EnumerateFiles();
            }
            catch (DirectoryNotFoundException)
            {
                throw;
            }

        }
    }
}
