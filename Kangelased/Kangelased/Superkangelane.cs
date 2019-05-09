using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Superkangelane:Kangelased
    {
        private double _Osavus;

        public Superkangelane(string Nimi, string Asukoht):base(Nimi,Asukoht)
            {
            Random r = new Random();
            _Osavus = r.Next(1, 5) + r.NextDouble();
            }
        public override int Päästa(int Ohustatud)
        {
            return (int)Math.Round(Ohustatud * (95 + _Osavus) / 100);
        }

        public override string ToString()
        {
            return base.ToString() + " ja ta on selles " + _Osavus + " protsendi osavam kui teised.";
        }
    }
}
