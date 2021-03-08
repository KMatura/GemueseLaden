using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemueseLaden
{
    class Veggi
    {
        public string Name { get; set; }
        public int Menge { get; set; }
        public float PPE { get; set; }
        public string Kategorie { get; set; }
        public float Price
        {
            get
            {
                if (Kategorie == "A")
                {
                    return PPE;
                }
                else if (Kategorie == "B")
                {
                    return PPE * 1.05f;
                }
                else if (Kategorie == "C")
                {
                    return PPE * 1.1f;
                }
                else
                {
                    return PPE;
                }
            }
        }
        public override string ToString()
        {
            return $"Veggi: {Name} Preis/Einheit: {PPE} Menge: {Menge} Kategorie: {Kategorie}";
        }

    }
}
