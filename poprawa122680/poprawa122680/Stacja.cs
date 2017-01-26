using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa122680
{
    class Stacja:IKoszt,IComparable<Stacja>
    {
        private int ileDzienniePociagow;
        private string nazwaStacji;
        public double ObliczKoszt()
        {
            return ileDzienniePociagow * 345.67;
        }
        public override string ToString()
        {
            return "Stacja: " + nazwaStacji + ", liczba pociągów dziennie: " + ileDzienniePociagow;
        }
        public Stacja(int ileDzienniePociagow, string nazwaStacji)
        {
            this.ileDzienniePociagow = ileDzienniePociagow;
            this.nazwaStacji = nazwaStacji;
        }
        public void Compare()
        {

        }
        public int CompareTo(Stacja other)
        {
            return this.nazwaStacji.CompareTo(other.nazwaStacji);
        }
    }
}
