using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSearch.IFilesImplementations
{
    class DateFilteredFiles : IFiles
    {
        private readonly IFiles directory;
        private readonly int cutOffDate;

        internal DateFilteredFiles(IFiles directory, int cutOffDate)
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
