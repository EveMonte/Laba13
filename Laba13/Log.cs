using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laba13
{
    public static class SDVLog
    {
        public static StreamWriter CreateStream(string str)//Создает экземпляр класса записи в файл
        {
            StreamWriter streamWriter = new StreamWriter(str);
            return streamWriter;
        }
        public static StreamReader CreateStreamR(string str)//Создает экземпляр класса чтение из файла
        {
            StreamReader streamReader = new StreamReader(str);
            return streamReader;
        }
        public static void SDVWriter(StreamWriter streamWriter, string info)//Запись в файл времени создания записи 
        {
            streamWriter.WriteLine(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":"
                + DateTime.Now.Day + ":" + DateTime.Now.Month + ":" + DateTime.Now.Year + " ");
            streamWriter.WriteLine(info);
        }
        public static void CloseStream(StreamWriter streamWriter)//Закрываем файл после работы с ним
        {
            streamWriter.Close();
        }
        public static string SDVReader(StreamReader streamReader)
        {
            return streamReader.ReadToEnd();
        }
        public static void SDVSearcher(StreamReader streamReader, string info)//Поиск в файле конкретную строку
        {
            string text = SDVReader(streamReader);
            if (text.Contains(info))
            {
                Console.WriteLine("Файл содержит необходимую информацию");
            }
            else
            {
                Console.WriteLine("Файл не содержит необходимую информацию");
            }
        }
    }
    
}
