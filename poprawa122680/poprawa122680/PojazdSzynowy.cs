using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa122680
{
    abstract class PojazdSzynowy: IKoszt
    {
        protected string marka;
        protected int masa;
        public PojazdSzynowy(string marka, int masa)
        {
            this.marka = marka;
            this.masa = masa;
        }

        public PojazdSzynowy()
        {
            
        }
        public double koszt;
        public abstract double ObliczKoszt();

        public abstract void Info();
       
    }
}
