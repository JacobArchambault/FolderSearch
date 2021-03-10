using System.Collections.Generic;
using System.IO;

namespace FolderSearch
{
    interface IDirectory
    {
        IEnumerable<FileSystemInfo> EnumerateFileSystemInfos();
    }
}
