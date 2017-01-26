using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa122680
{
    class Lokomotywa:PojazdSzynowy
    {
        public override double ObliczKoszt()
        {
            return koszt = masa * 34;
        }
        public override void Info()
        {
            Console.WriteLine("Lokomotywa, model: {0}, masa: {1}",marka,masa);
        }
        public Lokomotywa(string marka,int masa)
        {
            this.marka = marka;
            this.masa = masa;
        }
    }
}
