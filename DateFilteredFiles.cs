﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSearch
{
    class DateFilteredFiles : IDirectory
    {
        private readonly IDirectory directory;

        internal DateFilteredFiles(IDirectory directory)
        {
            this.directory = directory;
        }
        public IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directoryInfo)
        {
            return directory.EnumerateFiles(directoryInfo)
                .Where(file => file.LastWriteTime > DateTime.Today.Subtract(TimeSpan.FromDays(60)));
        }
    }
}