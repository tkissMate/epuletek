using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epuletek
{
    enum FenntartasTipusa { egyeni,szovetkezet,tarsashaz}
    class Tombhaz : Epuletek,CSV
    {
        readonly int lakasokSzama;
        FenntartasTipusa fenntartas;
        readonly bool vanLift;

        public int LakasokSzama => lakasokSzama;

        internal FenntartasTipusa Fenntartas { get => fenntartas; set => fenntartas = value; }

        public bool VanLift => vanLift;

        public Tombhaz(string cim, int terulet, epitesiAnyagok anyag, DateTime kezdes, DateTime vegzes, int lakasokSzama, bool vanLift, FenntartasTipusa fenntartas): base(cim, anyag, terulet, kezdes, vegzes)
        {
            this.lakasokSzama = lakasokSzama;
            this.vanLift = vanLift;
            Fenntartas = fenntartas;
        }

        public override string ToString()
        {
            return Cim;
        }

        public string toCSV()
        {
            return String.Join(";","tombhaz",Cim, Terulet, Anyag, Kezdes.ToString("yyyy-MM-dd"), Vegzes.ToString("yyyy-MM-dd"), lakasokSzama, vanLift, fenntartas);
        }
    }
}
