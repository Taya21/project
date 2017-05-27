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

                UniversityStruct univ = new UniversityStruct (arr[0],arr[1],arr[2],arr[3],arr[4]);
                returnData.Add(univ);
            }
            return returnData;
        }
        public List<UniversityStruct> ReadFile()
        {
            return ReadFile("Universities");
        }
    }
}
