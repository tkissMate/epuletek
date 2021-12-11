using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epuletek
{
    enum TetoAnyaga {cserep,zsindely,nad};
    class Csaladihaz : Epuletek,CSV
    {
        int ottElok;
        bool vanGarazs;
        TetoAnyaga teto;

        public int OttElok { get => ottElok; set => ottElok = value; }
        public bool VanGarazs { get => vanGarazs; set => vanGarazs = value; }
        internal TetoAnyaga Teto { get => teto; set => teto = value; }

        public Csaladihaz( string cim, int terulet,epitesiAnyagok anyag,DateTime kezdes,DateTime vegzes,int ottElok, bool vanGarazs, TetoAnyaga teto) :base(cim,anyag,terulet,kezdes,vegzes)
        {
            OttElok = ottElok;
            VanGarazs = vanGarazs;
            Teto = teto;
        }

        public override string ToString()
        {
            return Cim;
        }

        public string toCSV()
        {
            return String.Join(";","csaladi", Cim, Terulet, Anyag, Kezdes.ToString("yyyy-MM-dd"), Vegzes.ToString("yyyy-MM-dd"), ottElok, vanGarazs, teto);
        }
    }
}
