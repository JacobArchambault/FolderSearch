﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FolderSearch
{
    class RegexFilteredFiles : IDirectory
    {
        private readonly IDirectory source;
        internal RegexFilteredFiles(IDirectory source)
        {
            this.source = source;
        }
        public IEnumerable<FileInfo> EnumerateFiles()
        {
            return source.EnumerateFiles().Where(file => Regex.IsMatch(file.FullName, ".*.txt"));
        }
    }
}
