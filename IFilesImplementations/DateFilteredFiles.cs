using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSearch.IFilesImplementations
{
    static class DateFilteredFiles
    {
        public static IEnumerable<FileInfo> EnumerateFiles(IEnumerable<FileInfo> source, int cutOffDate)
        {
            return source
                .Where(file => file.LastWriteTime > DateTime.Today.Subtract(TimeSpan.FromDays(cutOffDate)));
        }
    }
}
