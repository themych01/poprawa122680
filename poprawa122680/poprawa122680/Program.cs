using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa122680
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PojazdSzynowy> ciuchcia = new List<PojazdSzynowy>();
            ciuchcia.Add(new Lokomotywa("WZ13", 55000));
            ciuchcia.Add(new Wagon("MZ22", 22000,"Węgiel"));
            ciuchcia.Add(new Wagon("MZ41", 17000,"koks"));
            ciuchcia.Add(new Wagon("MZ41", 17000,null));
            ciuchcia.Add(new Wagon("MZ31", 19000,null));
            ciuchcia.Add(new Wagon("MZ21", 15000,null));
            ciuchcia.Add(new Lokomotywa("WZ20", 70000));
            ciuchcia.Add(new Wagon("MZ10", 10000,"Węgiel"));
            ciuchcia.Add(new Wagon("MZ20", 20000,"Węgiel"));
            ciuchcia.Add(new Wagon("MZ20", 20000,"Węgiel"));
            Console.WriteLine("Elementy Listy: ");
            foreach(var element in ciuchcia)
            {

                element.Info();
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Sprawdzenie ładunek");
            foreach(var element in ciuchcia)
            {
                Console.WriteLine(element.ObliczKoszt());
            }
            Console.ReadKey();
            Console.Clear();
            double koszt = 0;
            Console.WriteLine("Łączny Koszt");
            foreach(var element in ciuchcia)
            {

                koszt += element.ObliczKoszt();
            }
            Console.WriteLine(koszt);
            Console.ReadKey();
            Console.Clear();
            Queue<Stacja> miasta = new Queue<Stacja>();
            miasta.Enqueue(new Stacja(25, "Olsztyn"));
            miasta.Enqueue(new Stacja(60, "Warszawa"));
            miasta.Enqueue(new Stacja(50, "Gdańsk"));
            miasta.Enqueue(new Stacja(30, "Płońsk"));
            miasta.Enqueue(new Stacja(15, "Tołkiny"));
            Console.WriteLine("Obroty w miastach");
            foreach(var element in miasta)
            {
  
                double cost = element.ObliczKoszt();
                Console.WriteLine(cost);
                
            }
            Console.ReadKey();
            Console.Clear();
            foreach(var element in miasta)
            {
                Console.WriteLine(element.ToString());
            }
            Console.ReadKey();

            List<Stacja> listka = new List<Stacja>();
            foreach (var element in miasta)
            {
                listka.Add(element);
            }
            Console.WriteLine();
            listka.Sort();
            foreach(var element in listka)
            {
                Console.WriteLine(element.ToString());
            }

            Console.ReadKey();

        }
    }
}
