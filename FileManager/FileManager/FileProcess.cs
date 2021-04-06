using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace FileManager
{
    class FileProcess : FileListEvent
    {



       






        public FileProcess( )


        {


           




            char DirectorySeparator = Path.VolumeSeparatorChar;
            string directorySeparator = Convert.ToString(DirectorySeparator);
            char SeparatorFile = Path.DirectorySeparatorChar;
            string separatorFiler = Convert.ToString(SeparatorFile);

            string[] startrepo = new string[] {"A"+ directorySeparator+ separatorFiler, "B" + directorySeparator + separatorFiler, "C" + directorySeparator+ separatorFiler,


                "D" + directorySeparator+ separatorFiler, "E" + directorySeparator+ separatorFiler, "F" + directorySeparator+ separatorFiler,

                "G" + directorySeparator+ separatorFiler, "H" + directorySeparator+ separatorFiler, "I" + directorySeparator+ separatorFiler,

                "J" + directorySeparator+ separatorFiler, "K" + directorySeparator+ separatorFiler, "L" + directorySeparator+ separatorFiler,

                "M" + directorySeparator+ separatorFiler, "N" + directorySeparator+ separatorFiler, "O" + directorySeparator+ separatorFiler,

                "P" + directorySeparator+ separatorFiler, "Q" + directorySeparator+ separatorFiler, "R" + directorySeparator+ separatorFiler,
                "S" + directorySeparator+ separatorFiler, "T" + directorySeparator+ separatorFiler, "U" + directorySeparator+ separatorFiler,
                "V" + directorySeparator+ separatorFiler, "W" + directorySeparator+ separatorFiler, "X" + directorySeparator+ separatorFiler,
                "Y" + directorySeparator+ separatorFiler, "Z" + directorySeparator+ separatorFiler,





            };




            int j = 0;



            for (int i = 0; i < startrepo.Length; i++) { if (Directory.Exists(Path.GetFullPath(startrepo[i])) == true) { j++; }; }

            string[] startrepo2 = new string[j];

            for (int i = 0, k = 0; i < startrepo.Length; i++) { if (Directory.Exists(Path.GetFullPath(startrepo[i])) == true) { startrepo2[k] = startrepo[i]; k++; }; }




            string[][] globalDirectoryNesting1 = new string[startrepo2.Length][];

            for (int i = 0; i < globalDirectoryNesting1.Length; i++) { string HomeDir = startrepo2[i]; globalDirectoryNesting1[i] = Directory.GetFileSystemEntries(HomeDir, "*", SearchOption.TopDirectoryOnly); };


            string[][] globalDirectoryNesting3 = new string[startrepo2.Length][];

            for (int i = 0; i < globalDirectoryNesting3.Length; i++) { string HomeDir = startrepo2[i]; globalDirectoryNesting3[i] = Directory.GetDirectories(HomeDir, "*", SearchOption.TopDirectoryOnly); };





            
            int f = 0;




            for (int i = 0; i < globalDirectoryNesting1.Length; i++) { for (int l = 0; l < globalDirectoryNesting1[i].Length; l++) { f++; } };
            string[][] globalDirectoryNesting2 = new string[f][];



            for (int i = 0; i < globalDirectoryNesting1.Length; i++) { for (int l = 0; l < globalDirectoryNesting1[i].Length; l++) { string HomeDir = globalDirectoryNesting1[i][l]; try { globalDirectoryNesting2[l] = Directory.GetFileSystemEntries(HomeDir, "*", SearchOption.AllDirectories); } catch (UnauthorizedAccessException) {txt2="В классе FileProcess Исключение UnauthorizedAccessException на 102 строке "+ time; continue; } catch (System.IO.IOException) { txt3 ="В классе FileProcess Исключение System.IO.IOException на 102 строке"+time; continue; }; } };

            List<string> FileList = new List<string>();
            foreach (string[] gljn in globalDirectoryNesting2) { if (gljn != null) { foreach (string poiksd in gljn) { FileList.Add(poiksd); }; } }

            




            



            FileList.Sort();



            
            string[] FileListProcess = new string[5];
          string FileDirectoryList = "FileDirectoryList.cs" ;
            string PropertiesDirectoryFile = "PropertiesDirectoryFile.cs";
            string FileCopy = "FileCopy.cs";
            string DeletingFile = "DeletingFile.cs";
            string DeletingDirectiry = "DeletingDirectiry.cs";
           
            for (int i = 0; i < FileList.Count; i++)
            {
                 if (FileList[i].EndsWith(FileDirectoryList)) { fileDirectoryList =FileList[i]; }
                 else if (FileList[i].EndsWith(PropertiesDirectoryFile)) { propertiesDirectoryFile = FileList[i]; }
                  else if (FileList[i].EndsWith(FileCopy)) { fileCopy = FileList[i]; }
                  else if (FileList[i].EndsWith(DeletingFile)) { deletingFile = FileList[i]; }
                  else if (FileList[i].EndsWith(DeletingDirectiry)) { deletingDirectiry = FileList[i]; }


                





            };

           
             
              
            
            





        }



































        public string fileDirectoryList;
        public string propertiesDirectoryFile;
        public string fileCopy;
        public string deletingFile;
        public string deletingDirectiry;








    }
}
