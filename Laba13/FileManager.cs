using System;
using System.IO;
using System.IO.Compression;
namespace Laba13
{
    class SDVFileManager
    {
        public static void DiskReader(StreamWriter streamWriter, string str)
        {
            SDVLog.SDVWriter(streamWriter, "Создание SDVInspect");//пишем в файл SDVlogfile.txt о создании SDVInspect
            Directory.CreateDirectory("SDVInspect");//создаем необходимый каталог
            FileStream fs = File.Create("SDVInspect\\SDVdirinfo.txt");//создаем файл
            fs.Close();

            SDVLog.SDVWriter(streamWriter, "Создание SDVdirinfo.txt");//пишем в файл создание SDVdirinfo.txt
            StreamWriter sw = new StreamWriter("SDVInspect\\SDVdirinfo.txt");// в каталог в файл SDVdirinfo.txt открываем поток
            DirectoryInfo dir = new DirectoryInfo(str);//получаем информацию о директории

            if (dir.Exists)
            {
                DirectoryInfo[] d = dir.GetDirectories();//если существует получаем каталоги и файлы
                FileInfo[] f = dir.GetFiles();

                for (int i = 0; i < d.Length; i++)//выводим все каталоги и файлы
                {
                    Console.WriteLine(d[i].Name);
                    sw.WriteLine(d[i].Name);
                }
                for (int i = 0; i < f.Length; i++)
                {
                    Console.WriteLine(f[i].Name);
                    sw.WriteLine(f[i].Name);
                }
                sw.Close();

                SDVLog.SDVWriter(streamWriter, "Скопировано из SDVdirinfo в SDVdirinfocopy");//пишем в файл "копирование каталога"
                if (File.Exists("SDVInspect\\SDVdirinfocopy.txt"))//перемещаем файл создавая его копию, после удаляем 
                {
                    File.Delete("SDVInspect\\SDVdirinfocopy.txt");
                }
                FileInfo q = new FileInfo("SDVInspect\\SDVdirinfo.txt");
                q.CopyTo("SDVInspect\\SDVdirinfocopy.txt");

                Directory.CreateDirectory("SDVFiles");
                q.CopyTo("SDVFiles\\SDVmove.txt");
                File.Delete("SDVInspect\\SDVdirinfo.txt");

                SDVLog.SDVWriter(streamWriter, "Создание SDVFiles");
                SDVLog.SDVWriter(streamWriter, "Запись в SDVFile");

                //срабатывает исключение при не первом запуске... удалить перед работой

                DirectoryInfo d1 = new DirectoryInfo("SDVFiles");//перемещаем директорий
                d1.MoveTo("SDVInspectMe");
                SDVLog.SDVWriter(streamWriter, "Перемещение SDVFiles");

                SDVLog.SDVWriter(streamWriter, "Архивация SDVFiles");
                ZipFile.CreateFromDirectory("SDVInspect", "SDV.zip");

                SDVLog.SDVWriter(streamWriter, "Разархивация SDVFiles");
                ZipFile.ExtractToDirectory("SDV.zip", "SDVEnd");
            }
        }
    }
}
