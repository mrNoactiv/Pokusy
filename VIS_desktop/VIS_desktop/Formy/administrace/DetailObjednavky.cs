using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIS_desktop.Databaze;
using VIS_desktop.Domenova;
using VIS_desktop.Interface;

namespace VIS_desktop.Formy.administrace
{
    public partial class DetailObjednavky : Form
    {
        KnihovnaService ks=new KnihovnaService();
        ObjednaniService os = new ObjednaniService();
        UlozeniService us=new UlozeniService();

        public int idObjednavky;
        private Collection<int> pisnicky = new Collection<int>();
        public DetailObjednavky(int TEMP)
        {
            InitializeComponent();

            idObjednavky = TEMP;
            
            
            foreach (Objednani o in os.getObjednavku(idObjednavky))
            {
                

                ListViewItem item1 = new ListViewItem(o.Objednavka.ToString());
                item1.SubItems.Add("id objednavky");

                ListViewItem item2 = new ListViewItem(o.Pisnicka.ToString());
                item2.SubItems.Add("id pisnicky");

                pisnicky.Add(o.Pisnicka);

                emailLabel.Text =o.Email;
                uzivatelLabel.Text =o.Uzivatel.ToString();

                this.listView1.Items.AddRange(new ListViewItem[] { item1, item2 });
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (us.getVypisKnihovny(int.Parse(uzivatelLabel.Text)).Count == 0)
            {
                KnihovnaGateway kg = new KnihovnaGateway();
                UzivatelGateway ug = new UzivatelGateway();

                ug.Id = Int32.Parse(uzivatelLabel.Text);
                kg.Uzivatel = ug;

                Knihovna k = new Knihovna(kg);
                
                ks.InsertKnihovnu(k);
            }

            UlozeniGateway ulg = new UlozeniGateway();
            IPisnickaGateway pg = new PisnickaGateway();
            KnihovnaGateway kng = new KnihovnaGateway();

            Knihovna knihovna = ks.getIdKnihovny(Int32.Parse(uzivatelLabel.Text));
            foreach (int i in pisnicky)
            {
                pg.Id = i;
                kng.Id = knihovna.Id;

                ulg.Knihovna = kng;
                ulg.Pisnicka = pg;

                Ulozeni ulozeni = new Ulozeni(ulg);

                UlozeniService.InsertUlozeni(ulozeni);
            }

            infoLabel.Text = "ok";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DetailObjednavky_Load(object sender, EventArgs e)
        {

        }
    }
}
