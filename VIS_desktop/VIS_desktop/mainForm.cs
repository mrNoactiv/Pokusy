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

namespace VIS_desktop
{
    public partial class mainForm : Form
    {
        UzivatelService us=new UzivatelService();

        public mainForm()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void albaButton_Click(object sender, EventArgs e)
        {
            Formy.prehledAlb prehledA = new Formy.prehledAlb();
            prehledA.Show();
        }

        private void pisnickyButton_Click(object sender, EventArgs e)
        {
            Formy.prehledPisnicek prehledP = new Formy.prehledPisnicek();
            prehledP.Show();
        }

        private void prehledZanruButton_Click(object sender, EventArgs e)
        {
            Formy.prehledZanru prehledZ = new Formy.prehledZanru();
            prehledZ.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formy.profilUzivatele profil = new Formy.profilUzivatele(SessionSingleton.getInstance().getLoggedUser().Id);
            profil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formy.prehledInterpret prehledI = new Formy.prehledInterpret();
            prehledI.Show();
        }

        private void registraceButton_Click(object sender, EventArgs e)
        {
            Formy.registraceForm registraceF = new Formy.registraceForm();
            registraceF.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            try
            {
                Uzivatel uzivatel = us.getLoginUzivatele(prezdivkaBox.Text, hesloBox.Text);


                SessionSingleton.getInstance().setLoggedUser(uzivatel);
                prihlasenyUzivatelLabel.Text = "Jste přihlášen jako " + SessionSingleton.getInstance().getLoggedUser().Prezdivka;

                if (SessionSingleton.getInstance().isLogged())
                {
                    profilButton.Show();
                }
                if (SessionSingleton.getInstance().isLogged())
                {
                    panel1.Hide();

                }
                odhlasitButton.Show();
                kosikButton.Show();
                
                if (SessionSingleton.getInstance().isAdministrator())
                {
                    objednavkyButton.Show();
                }

                }
            catch(Exception ex)
            {
                prihlasenyUzivatelLabel.Text = "Neplatné přihlašovací údaje";
                SessionSingleton.getInstance().logOut();
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void odhlasitButton_Click(object sender, EventArgs e)
        {
            SessionSingleton.getInstance().logOut();

            profilButton.Hide();
            panel1.Show();
            prihlasenyUzivatelLabel.Text = "Byl jste odhlášen";
            odhlasitButton.Hide();
            kosikButton.Hide();
            Kosik.getInstance().znicitKosik();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                if (Kosik.getInstance().kosikExistuje())
                {
                    Formy.KosikForm kos = new Formy.KosikForm();
                    kos.Show();
                }
                else
                    kosikLabel.Text = "kosik neexistuje";
            
            
        }

        private void objednavkyButton_Click(object sender, EventArgs e)
        {
            Formy.administrace.prehledObjednavekForm objednavky = new Formy.administrace.prehledObjednavekForm();
            objednavky.Show();

        }
    }
}
