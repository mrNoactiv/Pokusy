using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Interface;

namespace VIS_desktop.Databaze
{
    public class Pisnicka
    {
        private IPisnickaGateway data;

        public Pisnicka(IPisnickaGateway data)
        {
            this.data = data;
        }


        public int Id
        {
        get { return this.data.Id; }
        set { this.data.Id = Id; }
        }

        public String Nazev
        {
            get { return this.data.Nazev; }
            set { this.data.Nazev = Nazev; }
        }
        public String Delka
        {
            get { return this.data.Delka; }
            set { this.data.Delka = Delka; }
        }
        public float Hodnoceni
        {
            get { return this.data.Hodnoceni; }
            set { this.data.Hodnoceni = Hodnoceni; }
        }

        public string umeleckeJmenoInterpreta
        {
            get { return this.data.Interpret.UmeleckeJmeno; }
            set { this.data.Interpret.UmeleckeJmeno = value; }
        }
        public string nazevAlba
        {
            get { return this.data.Album.Nazev; }
            set { this.data.Album.Nazev = value; }
        }
        public string nazevZanru
        {
            get { return this.data.Zanr.Nazev; }
            set { this.data.Zanr.Nazev = value; }
        }
        public int idAlba
        {
            get { return this.data.Album.Id; }
        }

    }
}
