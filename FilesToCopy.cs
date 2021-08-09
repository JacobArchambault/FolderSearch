using FolderSearch.IFilesImplementations;
using System.IO;
namespace FolderSearch
{
    static class FilesToCopy
    {
        public static void CopyRecursively(IFiles filteredFiles, DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.EnumerateDirectories())
                CopyRecursively(filteredFiles, dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in filteredFiles.EnumerateFiles(source))
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
        }
    }
}
