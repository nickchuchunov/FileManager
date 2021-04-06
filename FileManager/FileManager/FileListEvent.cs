using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileManager
{
    public class FileListEvent
    {





       public string txt { get; set; }
        public string txt1 { get; set; }
        public string txt2 { get; set; }
        public string txt3 { get; set; }

        public static DateTime PresentTime = DateTime.Now;
        public string time = Convert.ToString(PresentTime);
        
        public  FileListEvent() 
        
        {
            

            List<string> Event1 = new List<string>();

            Event1.Add(txt);
            Event1.Add(txt1);
            Event1.Add(txt2);
            Event1.Add(txt3);

            File.WriteAllLines("ListEvent.txt", Event1);





        }










    }
}
