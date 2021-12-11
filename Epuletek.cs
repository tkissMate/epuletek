using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epuletek
{
    enum epitesiAnyagok { tégla,panel,fa};
    class Epuletek
    {

        readonly string cim;
        int terulet;
        readonly epitesiAnyagok anyag;
        DateTime kezdes;
        DateTime vegzes;

        public string Cim => cim;

        public int Terulet { get => terulet; set => terulet = value; }

        internal epitesiAnyagok Anyag => anyag;

        public DateTime Kezdes { get => kezdes; set => kezdes = value; }
        public DateTime Vegzes { get => vegzes; set => vegzes = value; }

        public Epuletek(string cim, epitesiAnyagok anyag, int terulet, DateTime munkaKezdes, DateTime munkaVege)
        {
            this.cim = cim;
            this.anyag = anyag;
            Terulet = terulet;
            Kezdes = munkaKezdes;
            Vegzes = munkaVege;
        }
    }
}
