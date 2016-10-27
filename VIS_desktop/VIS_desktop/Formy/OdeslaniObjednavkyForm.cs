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
using VIS_desktop.Interface;

namespace VIS_desktop.Formy
{
    public partial class OdeslaniObjednavkyForm : Form
    {
        ObjednavkaService oser=new ObjednavkaService();
        ObjednaniService objednaniSer=new ObjednaniService();


        public OdeslaniObjednavkyForm()
        {
            InitializeComponent();

            if(SessionSingleton.getInstance().isLogged())
            {
                prezdivkaLabel.Text = "Jste přihlášen jako " +SessionSingleton.getInstance().getLoggedUser().Prezdivka;
                emaillabel.Text="Email " + SessionSingleton.getInstance().getLoggedUser().Email;
                emialHostLabel.Hide();
                textBox1.Hide();
            }
            else
            {
                prezdivkaLabel.Hide();
                emaillabel.Hide();
                emialHostLabel.Show();
                textBox1.Show();
            }

        }

        private void OdeslaniObjednavkyForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if(ucetBox.TextLength==0)
                {
                    varovani2Label.Text = "Vyplňte účet";
                }
            
            else
            {
                ObjednavkaGateway og = new ObjednavkaGateway();
                UzivatelGateway u = new UzivatelGateway();
                ObjednaniGateway obj = new ObjednaniGateway();
                IPisnickaGateway pg = new PisnickaGateway();

                u.Id= SessionSingleton.getInstance().getLoggedUser().Id;


                og.Uzivatel = u;

                Objednavka o = new Objednavka(og);
                oser.InsertObjednavku(o);

                ObjednavkaGateway objIdg = new ObjednavkaGateway();
                Objednavka idObjednavky= oser.getIdObjednavky(SessionSingleton.getInstance().getLoggedUser().Id);

                foreach (Pisnicka p in Kosik.getInstance().getPisnicky())
                {
                    pg.Id = p.Id;
                    objIdg.Id = idObjednavky.Id;


                    obj.Objednavka = objIdg;
                    obj.Pisnicka = pg;

                    Objednani ob=new Objednani(obj);
                    objednaniSer.InsertObjednani(ob);

                }

                vytvoreniLabel.Show();
                Kosik.getInstance().znicitKosik();
                
            }
        }
    }
}
