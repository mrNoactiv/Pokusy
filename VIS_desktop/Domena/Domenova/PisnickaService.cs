using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;
using VIS_desktop.DatabazeXML;
using VIS_desktop.Interface;

namespace VIS_desktop.Domenova
{
    public class PisnickaService
    {

        private IPisnickaFinder pf;

        public PisnickaService()
        {
            pf = new XmlPisnickaFinder();
        }

        public Collection<Pisnicka> getPisnicky()
        {

            Collection<IPisnickaGateway> PisnickaGateways =  pf.SELECT();
            Collection<Pisnicka> pisnicky = new Collection<Pisnicka>();
            foreach (IPisnickaGateway pg in PisnickaGateways)
            {
                pisnicky.Add(new Pisnicka(pg));
            }
            return pisnicky;

        }

        public Pisnicka getPisnicku(int param)
        {

            IPisnickaGateway PisnickaGateway = pf.SelectId(param);
            Pisnicka pisnicka = new Pisnicka(PisnickaGateway);
            
            return pisnicka;

        }

        public Collection<Pisnicka> getPisnickyPodleAlba(string param)
        {

            Collection<IPisnickaGateway> PisnickaGateways = pf.selectPodleAlba(param);
            Collection<Pisnicka> pisnicky = new Collection<Pisnicka>();
            foreach (IPisnickaGateway pg in PisnickaGateways)
            {
                pisnicky.Add(new Pisnicka(pg));
            }
            return pisnicky;

        }

        public Collection<Pisnicka> getPisnickyPodleZanru(int param)
        {

            Collection<IPisnickaGateway> PisnickaGateways = pf.selectZanr(param);
            Collection<Pisnicka> pisnicky = new Collection<Pisnicka>();
            foreach (IPisnickaGateway pg in PisnickaGateways)
            {
                pisnicky.Add(new Pisnicka(pg));
            }
            return pisnicky;

        }

        public void UpravHodnoceniPisnicky(int id)
        {
            
            pf.UpravHodnoceni(id);
        }


        public static void InsertPisnicku(Pisnicka pisnicka,Interpret interpret,Zanr zanr,Album album)
        {
            Pisnicka p = pisnicka;
            Zanr z = zanr;
            Interpret i = interpret;
            Album a = album;

            IPisnickaGateway pg = new PisnickaGateway();
            IZanrGateway zg=new ZanrGateway();
            IAlbumGateway ag=new AlbumGateway();
            IInterpretGateway ig=new InterpretGateway();

            pg.Insert();

        }
        public static void DeletePisnicka(int id)
        {
            IPisnickaGateway pg=new PisnickaGateway();
            pg.Delete(id);

        }

    }
}
