using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace project
{
    class ReadExternalFile
    {

        public ReadExternalFile() { }

        public List<UniversityStruct> ReadFile() 
        {
            List<UniversityStruct> returnData = new List<UniversityStruct>();
            StreamReader reader = new StreamReader ("Universities.txt", Encoding.Default);

            string line;

            while((line = reader.ReadLine()) != null)
            {
                var arr = line.Split('|');

                UniversityStruct univ = new UniversityStruct (arr[0],arr[1],arr[2],arr[3],arr[4], arr[5], arr[6]);
                returnData.Add(univ);
            }

            reader.Close();
            return returnData;
        }

        public void WriteData(UniversityStruct ExtraData)
        {
            StreamWriter write = new StreamWriter("Universities.txt", true, Encoding.Default);

            write.WriteLine(ExtraData.Name + "|" + ExtraData.Address + "|" + ExtraData.Specialty + "|" + ExtraData.CountDay + "|" + ExtraData.CountNight + "|" + ExtraData.CountDist + "|" + ExtraData.Payment);
            write.Close();
        }

        public void DeleteLine(string lineForDelete)   // Delete line with chosen university. 
        {
            List<string> readData = new List<string>();
            StreamReader reader = new StreamReader("Universities.txt", Encoding.Default);

            string line;  // A variable for a temporary storage

            while ((line = reader.ReadLine()) != null)
            {
                if (line != lineForDelete) { readData.Add(line); }
            }

            reader.Close();

            StreamWriter write = new StreamWriter("Universities.txt", false, Encoding.Default);

            foreach (string lin in readData)   // Rewrite data if we delete a university
            {
                write.WriteLine(lin);
            }
            write.Close();
        }
    }
}
