using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ComponentModel;

namespace FileManager
{
    class Program
    {
        

        static void Main()
        {
           



           

            Console.WriteLine("Для выполнения действий примените указанные ниже команды \n help - список команд \n fl – вывод списка файлов и директорий  \n prd  - вывод информации о директории \n prf  - вывод информации о файле \n dlf  - удаление файла \n dld - удаление директории \n copy – копирование файла \n  отчет о выполнении программы см. файл ListEvent.txt в директории программы  ");

            string hg = Console.ReadLine();

            while (hg== "prd"|| hg == "prf" || hg == "dlf" || hg == "dld"||hg == "fl" || hg == "help" || hg == "copy")


            {



                if (hg == "help") { Console.WriteLine("Для выполнения действий примените указанные ниже команды \n help - список команд \n fl – вывод списка файлов и директорий  \n prd  - вывод информации о директории \n prf  - вывод информации о файле \n dlf  - удаление файла \n dld - удаление директории \n copy – копирование файла \n  отчет о выполнении программы см. файл ListEvent.txt в директории программы "); Main(); };
                if (hg == "fl") { new FileDirectoryList(); Main(); };
                if (hg == "prd") { new PropertiesDirectory(); Main();  };
                if (hg == "prf") { new PropertiesFile(); Main(); };
                if (hg == "dlf") { new DeletingFile(); Main(); };
                if (hg == "dld") { new DeletingDirectiry(); Main(); };
                if (hg == "copy") { new FileCopy(); Main(); };
               

                continue;

            };



            Main();



            

























        }
            














     }
 }


