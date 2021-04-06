using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FileManager
{
    public class DeletingDirectiry

    {
        public DeletingDirectiry() 
        
        
        {
            Console.WriteLine("Введите путь к директории которую нужно удалить при условии чтоона пуста");
         

            string DirectoryTrec = Console.ReadLine();


            DirectoryInfo directoryTrec = new DirectoryInfo(DirectoryTrec);


            if (directoryTrec.Exists)
            {
                try { directoryTrec.Delete(); } catch (System.IO.IOException )  { Console.WriteLine("Вы пытаетесь удалить директорию в которо есть файлы "); return; };  
                
                
                
                }
            else { Console.WriteLine("Вы ввели не правильный путь к дериктории"); };
          










        }





    }
}
