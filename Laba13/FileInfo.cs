using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laba13
{
    class SDVFileInfo
    {
        public static void FullDirection(StreamWriter streamWriter, string f)//выводим полный путь до файла
        {
            SDVLog.SDVWriter(streamWriter, "Полный путь");
            FileInfo fi = new FileInfo(f);
            if (fi.Exists)
            {
                Console.WriteLine($"Полное направление: {fi.DirectoryName}\\{fi.Name}");
            }
        }
        public static void FileInfo(StreamWriter streamWriter, string f)//Размер, расширение, имя
        {
            SDVLog.SDVWriter(streamWriter, "Информация о файле");
            FileInfo fi = new FileInfo(f);
            if (fi.Exists)
            {
                Console.WriteLine($"Размер: {fi.Length}, Расширение: {fi.Extension}, Имя: {fi.Name}");
            }
        }
        public static void CreationTime(StreamWriter streamWriter, string f)//Время создания файла
        {
            SDVLog.SDVWriter(streamWriter, "Время создания");
            FileInfo fi = new FileInfo(f);
            if (fi.Exists)
            {
                Console.WriteLine($"Время создания: {fi.CreationTime}");
            }
        }
    }
}
