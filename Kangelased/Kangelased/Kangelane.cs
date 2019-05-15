using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kangelased
{
    class Kangelane
    {
        // privaatsed isendiväljad
        private string nimi;
        private string asukoht;
        //konstruktor
        public Kangelane(string nimi, string asukoht)
        {
            Nimi = nimi;
            Asukoht = asukoht;
        }
        //•	Kõigi isendiväljade jaoks on vastavad get-meetodid ja set-meetodid.
        public string Nimi { get => nimi; set => nimi = value; }
        public string Asukoht { get => asukoht; set => asukoht = value; }

        public virtual int Päästa(int ohus)
        {
            return (int)Math.Round(ohus * .95);
        }
        public override string ToString()
        {
            return Nimi + "hoiab" +Asukoht+ "turvalisena.";
        }
    }
}
