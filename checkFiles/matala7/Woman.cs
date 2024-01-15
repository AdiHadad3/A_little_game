using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala7
{
    class Woman:person
    {
        int numberOfKids;

        public Woman(string firstName, string lastName, string city,int numberOfKids):base(firstName,lastName,city)
        {
            NumberOfKids = numberOfKids;
        }
        public int NumberOfKids { get => numberOfKids; set => numberOfKids = value; }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
