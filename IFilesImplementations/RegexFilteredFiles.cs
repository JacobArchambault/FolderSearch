using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FolderSearch.IFilesImplementations
{
    static class RegexFilteredFiles
    {
        public static IEnumerable<FileInfo> EnumerateFiles(IEnumerable<FileInfo> source, string regexFilter)
        {
            return source.Where(file => Regex.IsMatch(file.FullName, regexFilter));
        }
    }
}
