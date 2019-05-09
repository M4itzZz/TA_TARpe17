using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Kangelased
    {
        private string _Nimi;
        private string _Asukoht;

        public Kangelased(string Nimi, string Asukoht)
        {
            _Nimi = Nimi;
            _Asukoht = Asukoht;
        }

        public string Nimi { get => Nimi; set => Nimi = value; }
        public string Asukoht { get => Asukoht; set => Asukoht = value; }   

        public int Päästa(int Ohustatuid)
        {
            return (int)Math.Round(Ohustatuid * .95);
        }

        public override string ToString()
        {
            return Nimi + " hoiab " + Asukoht + "turvalisem";
        }
    }
}
