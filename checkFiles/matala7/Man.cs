using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala7
{
    class Man:person
    {
        double distanceFromWork;

        public Man(string firstName, string lastName, string city,double distanceFromWork):base(firstName, lastName, city)
        {
            this.DistanceFromWork = distanceFromWork;
        }
        public double DistanceFromWork { get => distanceFromWork; set => distanceFromWork = value; }
    }
}
