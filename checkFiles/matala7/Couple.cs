using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matala7
{
    class Couple:IComparable
    {
        Man manCouple;
        Woman womanCouple;

        public Couple(Man manCouple, Woman womanCouple)
        {
            this.ManCouple = manCouple;
            this.WomanCouple = womanCouple;
        }
        public Man ManCouple { get => manCouple; set => manCouple = value; }
        public Woman WomanCouple { get => womanCouple; set => womanCouple = value; }
        public int CompareTo(object obj)//sort by last name only
        {
            if (!(obj is Couple))
                throw new Exception("object is not a couple..");
            Couple c = (Couple)obj;
            int i = string.Compare(c.manCouple.LastName, this.manCouple.LastName);
            if (i == 0) return 0;
            if (i < 0) return -1;
            else return 1;
        }
        public override string ToString()
        {
            return $"{womanCouple.FirstName} and {manCouple.FirstName} {manCouple.LastName} - {manCouple.City}";
        }
    }
}
