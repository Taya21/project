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
        double countDay;
        double countNight;
        double countDist;
        double payment;

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

        public double CountDay
        {
            get { return countDay; }
        }

        public double CountNight
        {
            get { return countNight; }
        }

        public double CountDist
        {
            get { return countDist; }
        }

        public double Payment
        {
            get { return payment; }
        }

        public UniversityStruct(string Name, string Address,string Spel, string Day, string Night, string Dist, string Pay)
        {
            name = Name;
            address = Address;
            specialty = Spel;
            countDay = Convert.ToDouble(Day);
            countNight = Convert.ToDouble(Night);
            countDist = Convert.ToDouble(Dist);
            payment = Convert.ToDouble(Pay);
        }
    }
}
