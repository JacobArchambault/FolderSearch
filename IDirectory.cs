﻿using System.IO;

namespace FolderSearch
{
    interface IDirectory
    {
        FileInfo[] GetFiles();
    }
}
