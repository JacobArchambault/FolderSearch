using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSearch
{
    class StartDirectory
    {
        private readonly DirectoryInfo directoryInfo;
        public StartDirectory(DirectoryInfo directoryInfo)
        {
            this.directoryInfo = directoryInfo;
        }

        internal void CopyFrom()
        {
            try
            {
                directoryInfo.GetFiles();
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}
