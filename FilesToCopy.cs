using FolderSearch.IDirectories;
using System.IO;
namespace FolderSearch
{
    class FilesToCopy
    {
        readonly IDirectory filteredFiles;
        internal FilesToCopy(IDirectory dir)
        {
            this.filteredFiles = dir;
        }
        public void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.EnumerateDirectories())
                CopyFilesRecursively(dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in filteredFiles.EnumerateFiles(source))
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
        }
    }
}
