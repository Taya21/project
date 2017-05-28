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
        string specialty;
        string countDay;
        string countNight;
        string countDist;
        string payment;

        public string Name
        {
            get { return name; }
        }

        public string Address
        {
            get { return address; }
        }

        public string Specialty
        {
            get { return specialty; }
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

        public string Payment
        {
            get { return payment; }
        }

        public UniversityStruct(string Name, string Address,string Spel, string Day, string Night, string Dist, string Pay)
        {
            name = Name;
            address = Address;
            specialty = Spel;
            countDay = Day;
            countNight = Night;
            countDist = Dist;
            payment = Pay;
        }
    }
}
