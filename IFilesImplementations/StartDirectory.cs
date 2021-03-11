using System.Collections.Generic;
using System.IO;

namespace FolderSearch.IFilesImplementations
{
    class StartDirectory : IFiles
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
