using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laba13
{
    class SDVDirInfo
    {
        public static void CreationTime(StreamWriter streamWriter, string s) //время создания каталога
        {
            SDVLog.SDVWriter(streamWriter, "Время создания");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists)
                Console.WriteLine($"Время создания: {dir.CreationTime}");
            else Console.WriteLine("Каталог не существует");
        }
        public static void FileCount(StreamWriter streamWriter, string s)//количество файлов каталога
        {
            SDVLog.SDVWriter(streamWriter, "Количество файлов");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists)
            {
                FileInfo[] fi = dir.GetFiles();
                Console.WriteLine($"Количество файлов: {fi.Length}");
            }
        }
        public static void DirCount(StreamWriter streamWriter, string s)//количество подкаталогов
        {
            SDVLog.SDVWriter(streamWriter, "Количество каталогов");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists && dir.Extension == "")
            {
                DirectoryInfo[] d = dir.GetDirectories();
                Console.WriteLine($"Количество каталогов: {d.Length}");
            }
        }
        public static void ParentsCount(StreamWriter streamWriter, string s)//количество родительских каталогов
        {
            SDVLog.SDVWriter(streamWriter, "Количество родительских каталогов");
            DirectoryInfo dir = new DirectoryInfo(s);
            if (dir.Exists)
            {
                Console.WriteLine($"Корень: {dir.Root}");
            }
        }
    }
}
