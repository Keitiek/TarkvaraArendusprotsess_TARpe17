using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kangelased
{
   abstract class Kangelane : ISuperv6ime
    {
        // privaatsed isendiväljad
        private string nimi;
        private string supernimi;
        private string voime;
        private string asukoht;
        //konstruktor
        public Kangelane(string nimi, string asukoht)
        {
            this.nimi = nimi;
            this.asukoht = asukoht;
           
        }
        public Kangelane(string supernimi, string v6ime, string nimi)
        {
            this.supernimi = supernimi;
            this.voime = voime;
            this.nimi = nimi;

        }

        //Kõigi isendiväljade jaoks on vastavad get-meetodid ja set-meetodid.
        public string Nimi { get => nimi; set => nimi = value; }
        public string Asukoht { get => asukoht; set => asukoht = value; }
        public string Voime { get => voime; set => voime = value; }
        public string Supernimi { get => supernimi; set => supernimi = value; }

        public virtual int Päästa(int ohus)
        {
            return (int)Math.Round(ohus * .95);
        }
        public override string ToString()
        {
            return Nimi + "hoiab" + Asukoht + "turvalisena.";
        }
        public string AnnaNimi()
        {
            return nimi;
        }
        public string SuperNimi()
        {
            return supernimi;
        }
        public string AnnaVoime()
        {
            return voime;
        }
        public abstract void V6iduK6ne();
        }
    }


