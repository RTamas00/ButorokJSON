using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorokJSON
{
    public class Targyak
    {
        public int azonosito { get; set; }
        public string nev { get; set; }

        public string anyag { get; set; }

        public Meretek meretek { get; set; }

        public int ar { get; set; }

        public bool keszleten { get; set; }

        public override string ToString()
        {
            return $"{nev} {anyag} " +
                $"({meretek.Magassag}x{meretek.Szelesseg}x{meretek.melyseg}) Ft" +
                $"Ára: {ar}Ft" +
            $"{(keszleten ? "Készleten van!" : "Nem elérhető")}";
        }
        public int terfogat()
        {
            return meretek.Magassag * meretek.Szelesseg * meretek.melyseg;
        }
    }
}
