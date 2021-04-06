using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileManager
{
   public class DeletingFile

    {
       public DeletingFile()
        
        {

            Console.WriteLine("Введите путь к файлу который нужно удалить");

            string FileTrec =Console.ReadLine();

            FileInfo fi6 = new FileInfo(FileTrec);


            if (fi6.Exists) { fi6.Delete(); Console.WriteLine("Указанный файл удален");  } else { Console.WriteLine("Вы введи не привильный путь к файлу"); }












        }












    }
}
