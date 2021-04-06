using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace FileManager
{
   public class FileCopy
    {
       public FileCopy()
        
        
        {
            Console.WriteLine("Введите путь к файлу который нужно скопировать");
            string copy1 = Console.ReadLine();
            Console.WriteLine("Введите путь к папке в которую нужно скопировать файл");
            string copy2 = Console.ReadLine();
            char SeparatorFile1 = Path.DirectorySeparatorChar;
            string separatorFiler1 = Convert.ToString(SeparatorFile1);
            string[] copy1_1 = copy1.Split(separatorFiler1);
            string copy2_1  = copy2 +  "Копия_"+copy1_1[copy1_1.Length-1];
            Console.WriteLine(copy2_1);

            FileInfo NewNameCopyFile = new FileInfo(copy2_1);
            FileInfo NewNameCopyFile1 = new FileInfo(copy1);

            if (NewNameCopyFile1.Exists) 
            
            {

                if (NewNameCopyFile.Exists == false)
                { NewNameCopyFile.Create(); }
                else { NewNameCopyFile1.CopyTo(copy2_1); }

                




            }
            else { Console.WriteLine("Вы ввели несуществующий путь к файлу"); }


            









        }




    }
}
