using System.Collections.Generic;
using System.IO;

namespace FolderSearch
{
    interface IDirectory
    {
        IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directory);
    }
}
