using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laba13
{
    static class SDVDiskInfo
    {
        private static DriveInfo[] allDrives = DriveInfo.GetDrives();

        public static void FreeSpace(StreamWriter streamWriter)//вывод свободного места
        {
            SDVLog.SDVWriter(streamWriter, "Свободное пространство");
            for (int i = 0; i < allDrives.Length; i++)
            {
                if (allDrives[i].IsReady)
                {
                    Console.WriteLine($"[{allDrives[i].Name}]Доступное свободное пространство: {allDrives[i].AvailableFreeSpace}");
                }
            }
        }

        public static void FileSystemInfo(StreamWriter streamWriter)//вывод информации о файловой системе
        {
            SDVLog.SDVWriter(streamWriter, "Системная информация");
            Console.WriteLine($"Информация о файловой системе: {allDrives[0].DriveFormat}");
        }

        public static void DiskInfo(StreamWriter streamWriter)//имя, объем, доступный объем, метка тома каждого существующего диска
        {
            SDVLog.SDVWriter(streamWriter, "Информация о диске");
            for (int i = 0; i < allDrives.Length; i++)
            {
                if (allDrives[i].IsReady)
                {
                    Console.WriteLine($"[{allDrives[i].Name}] " +
                        $"Общий размер: {allDrives[i].TotalSize}, " +
                        $"Доступное свободное пространство: {allDrives[i].AvailableFreeSpace}, " +
                        $"Метка: {allDrives[i].VolumeLabel}");
                }
            }
        }
    }
}
