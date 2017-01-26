using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa122680
{
    class Wagon:PojazdSzynowy
    {
        private string ładunek;
        public override double ObliczKoszt()
        {
            if (ładunek == null) return 3000 ;
            else return  (3000 + masa);
        }
        public override void Info()
        {
            Console.WriteLine("Wagon, model: {0}, masa: {1}",marka,masa);
        }
        public Wagon(string marka, int masa,string ładunek)
        {
            this.marka = marka;
            this.masa = masa;
            this.ładunek = ładunek;
        }
    }
}
