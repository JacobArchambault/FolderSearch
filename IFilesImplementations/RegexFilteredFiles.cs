using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FolderSearch.IFilesImplementations
{
    class RegexFilteredFiles : IFiles
    {
        private readonly IFiles source;
        private readonly string regexFilter;
        internal RegexFilteredFiles(IFiles source, string regexFilter)
        {
            this.source = source;
            this.regexFilter = regexFilter;
        }
        public IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directoryInfo)
        {
            return source.EnumerateFiles(directoryInfo).Where(file => Regex.IsMatch(file.FullName, regexFilter));
        }
    }
}
