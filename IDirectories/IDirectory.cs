using System.Collections.Generic;
using System.IO;

namespace FolderSearch.IDirectories
{
    interface IDirectory
    {
        IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directory);
    }
}
