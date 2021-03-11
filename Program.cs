using System.IO;
namespace FolderSearch
{
    class Program
    {
        static void Main()
        {
            new FilesToCopy(
                new DateFilteredFiles(
                    new RegexFilteredFiles(
                        new SortedDirectory(
                            new StartDirectory()))))
                .CopyFilesRecursively(
                new DirectoryInfo("../../../input"),
                new DirectoryInfo("../../../output"));
        }
    }
}
