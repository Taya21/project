using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project
{
    class UniversityStruct
    {
        string name;
        string address;
        string countDay;
        string countNight;
        string countDist;

        public string Name
        {
            get { return name; }
        }

        public string Address
        {
            get { return address; }
        }

        public string CountDay
        {
            get { return countDay; }
        }

        public string CountNight
        {
            get { return countNight; }
        }

        public string CountDist
        {
            get { return countDist; }
        }

        public UniversityStruct(string Name, string Address, string Day, string Night, string Dist)
        {
            name = Name;
            address = Address;
            countDay = Day;
            countNight = Night;
            countDist = Dist;
        }
    }
}
