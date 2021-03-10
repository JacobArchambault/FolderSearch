using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSearch
{
    class StartDirectory : IDirectory
    {
        private readonly DirectoryInfo directoryInfo;
        public StartDirectory(DirectoryInfo directoryInfo)
        {
            this.directoryInfo = directoryInfo;
        }

        public FileInfo[] GetFiles()
        {
            try
            {
                return directoryInfo.GetFiles();
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}
