using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FileManager
{
     
    public class FileDirectoryList : FileListEvent
    {

        
        public FileDirectoryList( )


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





            //foreach (string[] gljn in globalDirectoryNesting1) { if (gljn!=null) { foreach (string poiksd in gljn) { Console.WriteLine(poiksd); } }  }
            int f = 0;




            for (int i = 0; i < globalDirectoryNesting1.Length; i++) { for (int l = 0; l < globalDirectoryNesting1[i].Length; l++) { f++; } };
            string[][] globalDirectoryNesting2 = new string[f][];



            for (int i = 0; i < globalDirectoryNesting1.Length; i++) { for (int l = 0; l < globalDirectoryNesting1[i].Length; l++) { string HomeDir = globalDirectoryNesting1[i][l]; try { globalDirectoryNesting2[l] = Directory.GetFileSystemEntries(HomeDir, "*", SearchOption.TopDirectoryOnly); } catch (UnauthorizedAccessException) {txt ="В кдассе FileDirectoryList Исключение UnauthorizedAccessException - 87 строка";  continue; } catch (System.IO.IOException) { txt1 = "В кдассе FileDirectoryList исключение System.IO.IOException - 87 строка" ;  continue; }; } };

            

            List<string> FileList = new List<string>();
            foreach (string[] gljn in globalDirectoryNesting2) { if (gljn != null) { foreach (string poiksd in gljn) { FileList.Add(poiksd); }; } }

            List<string> DirectoryList = new List<string>();
            foreach (string[] gljn in globalDirectoryNesting3) { if (gljn != null) { foreach (string poiksd in gljn) { DirectoryList.Add(poiksd); }; } }





            // for (int i = 0; i < FileList.Count; i++) { Console.WriteLine(FileList[i]); }

            // string sortFileList(string[][] globalDirectoryNesting4)
            // {
            //   for (int i = 0; i < globalDirectoryNesting4.GetLength(0); i++)
            //   {
            //      for (int l = 0; l < globalDirectoryNesting4[i].Length; l++)
            //      { return globalDirectoryNesting4[i][l]; }
            //  }
            // }






            //  for (int n = 0; n < FileList.Count; n++) { if (globalDirectoryNesting4[i][l].StartsWith(FileList[n])) { }; };




            FileList.Sort();



            List<string> FileListSort = new List<string>();



            for (int i = 0; i < FileList.Count; i++)
            {
                for (int mh = 0; mh < DirectoryList.Count; mh++)

                {






                    if (FileList[i].StartsWith(DirectoryList[mh]))


                    {

                        int directsearh = 0;
                        for (int direct = 0; direct < FileListSort.Count; direct++)
                        { if (FileListSort[direct] == DirectoryList[mh]) { directsearh++; }; };
                        if (directsearh == 0) { FileListSort.Add(DirectoryList[mh]); };



                        int filetrecLength = DirectoryList[mh].Length;




                        FileListSort.Add(FileList[i].Remove(0, filetrecLength).PadLeft(FileList[i].Length, '.'));


                        
                    };




                }


            }





            // string[] filetrec1 = FileList[i].Split(separatorFiler); string[] filetrec2 = DirectoryList[mh].Split(separatorFiler);







            for (int i = 0; i < FileListSort.Count; i++) { Console.WriteLine(FileListSort[i]); }



        }




    }
}
