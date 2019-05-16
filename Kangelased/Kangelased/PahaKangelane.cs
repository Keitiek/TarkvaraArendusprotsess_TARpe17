using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kangelased
{
   class PahaKangelane:Kangelane
    {
        public PahaKangelane(string supernimi, string v6ime, string nimi) : base(supernimi, v6ime, nimi)
        {

        }
        public string KasutaV6imet()
        {
            return "Paha kangelane"+ SuperNimi()+"püüab hävitada maailma.";
        }

        public override void V6iduK6ne()
        {
            Console.WriteLine("Mina" + SuperNimi() + "võitsin pahalase");
        }
    }
}
