using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace FileManager
{
    class PropertiesFile
    {

        public PropertiesFile()






        {
            Console.WriteLine("Введите путь к файлу");
            string treac = Console.ReadLine();

            var fi1 = new FileInfo(treac);

            if (fi1.Exists)

            {
                Console.WriteLine(" Имя файла {0}, \n  Размер {1}, \n Время последнего доступа {2},  \n Время создания файла {3},  \n Время изменения файла {4},   ", fi1.Name, fi1.Length, fi1.LastAccessTime, fi1.CreationTime, fi1.LastWriteTime, fi1.Attributes);







            }
            else { Console.WriteLine("вы ввели не существующий путь"); }









        }







    }




















}

