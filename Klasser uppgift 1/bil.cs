using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser_uppgift_1
{
    internal class bil
    {
        public string märke;
        public string modell;
        public string färg;
        public int årsmodell;
        public int vikt;

        public void MataIn()
        {
            Console.WriteLine("Vad är det för märke på bilen?");
            märke = Console.ReadLine();
            Console.WriteLine("Vad är det för modell?");
            modell = Console.ReadLine();
            Console.WriteLine("Vad är det för färg på bilen?");
            färg = Console.ReadLine();
            Console.WriteLine("Vad har bilen för årsmodell?");
            årsmodell = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket väger bilen? (kg)");
            vikt = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void MataUt()
        {
            Console.WriteLine("Här kommer information om bilen:");
            Console.WriteLine($"Märke: {märke}");
            Console.WriteLine($"Modell: {modell}");
            Console.WriteLine($"Färg: {färg}");
            Console.WriteLine($"Årsmodell: {årsmodell}");
            Console.WriteLine($"Vikt: {vikt} kg");
            Console.WriteLine();
        }
    }


}
