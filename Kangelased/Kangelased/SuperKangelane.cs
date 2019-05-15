using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kangelased
{
    class SuperKangelane:Kangelane
    {
        private double osavus;

        public SuperKangelane(string nimi, string asukoht):base(nimi,asukoht)
        {
            Random r = new Random();
            this.osavus = r.Next(1,5)+r.NextDouble();
        }
        public override int Päästa(int ohus)
        {
            return (int)Math.Round(ohus * (95 + osavus) / 100);
        }
        public override string ToString()
        {
            return base.ToString()+"ja ta on selles"+osavus+"protsenti osavam kui teised.";
        }
    }
}
