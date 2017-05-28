using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace project
{
    class ReadExternalFiles
    {

        public ReadExternalFiles() { }

        public List<UniversityStruct> ReadFile(string pathToFile)
        {
            List<UniversityStruct> returnData = new List<UniversityStruct>();
            StreamReader reader = new StreamReader (pathToFile+".txt",Encoding.Default);

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

        public List<UniversityStruct> ReadFile()
        {

            return ReadFile("Universities");
        }

        public void Write_Data(UniversityStruct WData)
        {
            StreamWriter write = new StreamWriter("Universities.txt", true, Encoding.Default);

            write.WriteLine(WData.Name + "|" + WData.Address + "|" + WData.Specialty + "|" + WData.CountDay + "|" + WData.CountNight + "|" + WData.CountDist + "|" + WData.Payment);
            write.Close();
        }

        public void DeleteLine(string lineForDelete)
        {
            List<string> readData = new List<string>();
            StreamReader reader = new StreamReader("Universities.txt", Encoding.Default);


            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line != lineForDelete) { readData.Add(line); }
            }
            reader.Close();

            StreamWriter write = new StreamWriter("Universities.txt", false, Encoding.Default);
            foreach (string lin in readData)
            {
                write.WriteLine(lin);
            }
            write.Close();
        }
    }
}
