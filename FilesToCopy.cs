using FolderSearch.IFilesImplementations;
using System.IO;
namespace FolderSearch
{
    static class FilesToCopy
    {
        public static void CopyRecursively(string regexFilter, int maxNumber, int cutOffDate, DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.EnumerateDirectories())
                CopyRecursively(regexFilter, maxNumber, cutOffDate, dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in MaxFiles.EnumerateFiles(
                                        SortedDirectory.EnumerateFiles(
                                            DateFilteredFiles.EnumerateFiles(
                                                RegexFilteredFiles.EnumerateFiles(
                                                    source.EnumerateFiles(), 
                                                    regexFilter), 
                                                cutOffDate)), 
                                        maxNumber))
            {
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
            }
        }
    }
}
