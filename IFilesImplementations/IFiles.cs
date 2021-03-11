using System.Collections.Generic;
using System.IO;

namespace FolderSearch.IFilesImplementations
{
    interface IFiles
    {
        IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directory);
    }
}
