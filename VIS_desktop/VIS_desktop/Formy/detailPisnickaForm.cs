using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIS_desktop.Domenova;
using VIS_desktop.Databaze;
using System.Collections.ObjectModel;
using VIS_desktop.Interface;

namespace VIS_desktop.Formy
{
    public partial class detailPisnickaForm : Form
    {
        private HodnoceniPisnickyService service =new HodnoceniPisnickyService();
        private PisnickaService serviceP =new PisnickaService();



        private int idPisnicky;
        private Pisnicka aktualniPisnicka;

        public detailPisnickaForm(int temp)
        {
            InitializeComponent();

            //Databaze.IPisnickaGateway pisnickaa = Databaze.PisnickaFinder.SelectId(temp);
            Databaze.Pisnicka pisnicka = serviceP.getPisnicku(temp);
            aktualniPisnicka = pisnicka;
            aktualniPisnicka.Id = temp;
            idPisnicky = temp;

            nazevLabel.Text = pisnicka.Nazev;
            delkaPisnickyLabel.Text = pisnicka.Delka;
            hodnoceniLabel.Text = pisnicka.Hodnoceni.ToString();
            jmenoInterpretaLabel.Text = pisnicka.umeleckeJmenoInterpreta;
            albumLabel.Text = pisnicka.nazevAlba;
            zanrLabel.Text = pisnicka.nazevZanru;


            if (SessionSingleton.getInstance().isLogged())
            {

                this.panel1.Show();
                this.koupitButton.Show();
            }
            else
                this.panel1.Hide();

                foreach (HodnoceniPisnicky hodnoceni in service.getPisnicky(temp))
            {


                ListViewItem item1 = new ListViewItem("Text: "+hodnoceni.Text);
                item1.SubItems.Add("id");

                ListViewItem item2 = new ListViewItem("Hodnoceni: "+hodnoceni.Hodnoceni.ToString());
                item2.SubItems.Add("hodnoceni");
                ListViewItem item3 = new ListViewItem("Autor: "+hodnoceni.Uzivatel);
                item2.SubItems.Add("Autor");
                ListViewItem item4 = new ListViewItem("--------------------");
                item2.SubItems.Add("rezdelovac");

                this.komentareView.Items.AddRange(new ListViewItem[] { item1, item2,item3,item4 });
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                UzivatelGateway uzivatelgateway = new UzivatelGateway();
                IPisnickaGateway pisnickagateway = new PisnickaGateway();
                HodnoceniPisnickyGateway hodnocenigateway = new HodnoceniPisnickyGateway();

                uzivatelgateway.Id = SessionSingleton.getInstance().getLoggedUser().Id;
                pisnickagateway.Id = idPisnicky;
                hodnocenigateway.Text = textKomentareBox.Text;

                if (radioButton1.Checked)
                {
                    hodnocenigateway.Hodnoceni = 1;
                }
                else if (radioButton2.Checked)
                {
                    hodnocenigateway.Hodnoceni = 2;
                }
                else if (radioButton3.Checked)
                {
                    hodnocenigateway.Hodnoceni = 3;
                }
                else if (radioButton4.Checked)
                {
                    hodnocenigateway.Hodnoceni = 4;
                }
                else if (radioButton5.Checked)
                {
                    hodnocenigateway.Hodnoceni = 5;
                }
                else
                    hodnocenigateway.Hodnoceni = 1;


                Uzivatel uzivatel = new Uzivatel(uzivatelgateway);
                Pisnicka pisnicka = new Pisnicka(pisnickagateway);
                HodnoceniPisnicky hodnoceni = new HodnoceniPisnicky(hodnocenigateway);

                service.InsertHodnoceni(hodnoceni, pisnicka, uzivatel);

                infoLabel.Text = "KOmentář vložen";

                this.komentareView.Clear();




                serviceP.UpravHodnoceniPisnicky(idPisnicky);
                Databaze.Pisnicka pis = serviceP.getPisnicku(idPisnicky);
                hodnoceniLabel.Text = pis.Hodnoceni.ToString();
                foreach (HodnoceniPisnicky hodnoceniP in service.getPisnicky(idPisnicky))
                {


                    ListViewItem item1 = new ListViewItem("Text: " + hodnoceniP.Text);
                    item1.SubItems.Add("id");

                    ListViewItem item2 = new ListViewItem("Hodnoceni: " + hodnoceniP.Hodnoceni.ToString());
                    item2.SubItems.Add("hodnoceni");
                    ListViewItem item3 = new ListViewItem("Autor: " + hodnoceniP.Uzivatel);
                    item2.SubItems.Add("Autor");
                    ListViewItem item4 = new ListViewItem("--------------------");
                    item2.SubItems.Add("rezdelovac");

                    this.komentareView.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4 });
                }


            }
            catch (Exception ex)
            {
                infoLabel.Text = "Něco je špatně";
                Console.WriteLine(ex);
            }







        }

        private void delkaPisnickyLabel_Click(object sender, EventArgs e)
        {

        }

        private void koupitButton_Click(object sender, EventArgs e)
        {
            if (Kosik.getInstance().kosikExistuje())
            {
                Kosik.getInstance().addpisnicku(aktualniPisnicka);
            }
            else
            {
                Collection<Pisnicka> pisnicky = new Collection<Pisnicka>();
                Kosik.getInstance().setKolekciPisnicek(pisnicky);
                Kosik.getInstance().addpisnicku(aktualniPisnicka);
            } 
        }
    }
}
