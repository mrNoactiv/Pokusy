using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIS_desktop.Databaze;
using VIS_desktop.Domenova;

namespace VIS_desktop.Formy
{
    public partial class profilUzivatele : Form
    {
        UzivatelService us=new UzivatelService();
        UlozeniService uls=new UlozeniService();


        public profilUzivatele(int temp)
        {
            InitializeComponent();

            Databaze.Uzivatel uzivatel = us.getUzivatel(temp);

            prezdivkaBox.Text =uzivatel.Prezdivka;
            typLabel.Text = uzivatel.Typ;
            emailBox.Text = uzivatel.Email;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {

                UzivatelGateway uzivatelGateway = new UzivatelGateway();


                uzivatelGateway.Prezdivka = prezdivkaBox.Text;
                uzivatelGateway.Email = emailBox.Text;
                uzivatelGateway.Heslo = hesloBox.Text;

                Uzivatel u = new Uzivatel(uzivatelGateway);

                us.UpdateUzivatel(u,SessionSingleton.getInstance().getLoggedUser().Id);

                infoLabel.Text = "Informace změněny";

            }
            catch (Exception ex)
            {
                infoLabel.Text = "Něco je špatně";
                Console.WriteLine(ex);
            }

        }

        private void zobrazButton_Click(object sender, EventArgs e)
        {
            if (uls.getVypisKnihovny(SessionSingleton.getInstance().getLoggedUser().Id).Count == 0)
            {
                knihovnaJePrazdnaLabel.Show();
            }
            else
            {
                Formy.knihovnaForm knihovna = new Formy.knihovnaForm();
                knihovna.Show();
            }
        }
    }
}
