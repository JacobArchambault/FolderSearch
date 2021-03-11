using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSearch
{
    class DateFilteredFiles : IDirectory
    {
        private readonly IDirectory directory;
        private readonly int cutOffDate;

        internal DateFilteredFiles(IDirectory directory, int cutOffDate)
        {
            this.directory = directory;
            this.cutOffDate = cutOffDate;

        }
        public IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directoryInfo)
        {
            return directory.EnumerateFiles(directoryInfo)
                .Where(file => file.LastWriteTime > DateTime.Today.Subtract(TimeSpan.FromDays(cutOffDate)));
        }
    }
}
