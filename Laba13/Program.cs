using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laba13
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = SDVLog.CreateStream("SDVlogfile.txt");

            SDVDiskInfo.FreeSpace(file);
            SDVDiskInfo.FileSystemInfo(file);
            SDVDiskInfo.DiskInfo(file); Console.WriteLine();

            SDVFileInfo.FullDirection(file, "SDVlogfile.txt");
            SDVFileInfo.FileInfo(file, "SDVlogfile.txt");
            SDVFileInfo.CreationTime(file, "SDVlogfile.txt"); Console.WriteLine();

            SDVDirInfo.CreationTime(file, "..");
            SDVDirInfo.FileCount(file, "..");
            SDVDirInfo.DirCount(file, "..");
            SDVDirInfo.ParentsCount(file, ".."); Console.WriteLine();

            try
            {
                SDVFileManager.DiskReader(file, "C://");
            }
            catch (IOException) { };
            file.Close(); Console.WriteLine();

            StreamReader fileR = SDVLog.CreateStreamR("SDVlogfile.txt");
            SDVFinder.SearcherWord(fileR, "Системная информация"); fileR.Close();
            Console.WriteLine();

            StreamReader fileR1 = SDVLog.CreateStreamR("SDVlogfile.txt");
            SDVFinder.Searcher(fileR1, 1, 5); fileR1.Close();
            Console.WriteLine();

            StreamReader fileR2 = SDVLog.CreateStreamR("SDVlogfile.txt");
            SDVFinder.SearcherDate(fileR2, 2, 10);
            fileR2.Close();
        }
    }
}
