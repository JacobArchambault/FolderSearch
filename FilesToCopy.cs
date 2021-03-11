using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSearch
{
    class FilesToCopy
    {
        readonly IDirectory dir;
        internal FilesToCopy(IDirectory dir)
        {
            this.dir = dir;
        }
        public void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
                CopyFilesRecursively(dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in dir.EnumerateFiles(source))
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
        }
    }
}
