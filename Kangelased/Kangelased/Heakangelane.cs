using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kangelased
{
    class Heakangelane:Kangelane
    {
        public Heakangelane(string supernimi, string v6ime, string nimi) : base(supernimi, v6ime, nimi)
        {

        }
        public string KasutaV6imet()
        {
            return "Hea kangelane" + SuperNimi() + "päästab maailma.";
        }

        public override void V6iduK6ne()
        {
          Console.WriteLine("Mina" + SuperNimi() +"võitsin pahalase");
        }
    }
}
