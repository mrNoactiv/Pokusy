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
    public partial class registraceForm : Form
    {
        UzivatelService us=new UzivatelService();

        public registraceForm()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try {
                UzivatelGateway uzivatelgateway = new UzivatelGateway();

                uzivatelgateway.Prezdivka = prezdivkaBox.Text;

                uzivatelgateway.Heslo = prezdivkaBox.Text;
                uzivatelgateway.Email = emailBox.Text;
                uzivatelgateway.Typ = "user";

                Uzivatel uzivatel = new Uzivatel(uzivatelgateway);


                us.InsertUzivatel(uzivatel);

                infoLabel.Text = "Registrace proběhla úspěšně";
            }
            catch(Exception ex)
            {
                infoLabel.Text = "Něco je špatně";
                Console.WriteLine(ex);
            }
            



        }
    }
}
