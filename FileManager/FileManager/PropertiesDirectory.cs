using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileManager
{
    public class PropertiesDirectory
    {
        public PropertiesDirectory()
        {
            Console.WriteLine("Введите путь дериктории для отображения свойчтв");
            string infoDirect = Console.ReadLine();

            DirectoryInfo direct = new DirectoryInfo(infoDirect);

            if (direct.Exists)



            {
                IEnumerable<DirectoryInfo> info = direct.EnumerateDirectories("*", SearchOption.TopDirectoryOnly);


                foreach (var info1 in info) { Console.WriteLine(" Наименование директлории {0}, \n Время создания каталога {1}, \n  Время последней записи в каталог {2}, \n время доступа к каталогу {3}, \n --------------------------\n", info1.FullName, info1.CreationTime, info1.LastWriteTime, info1.LastAccessTime); }








            }

            else { Console.WriteLine("вы ввели не существующий путь"); };
        }





















    }
}
