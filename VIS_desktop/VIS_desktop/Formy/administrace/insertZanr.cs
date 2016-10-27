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

namespace VIS_desktop.Formy.administrace
{
     

    public partial class insertZanr : Form
    {
        private ZanrService zs=new ZanrService();

        public insertZanr()
        {
            InitializeComponent();
        }

        private void vlozButton_Click(object sender, EventArgs e)
        {

            try
            {
                ZanrGateway zanrGateway = new ZanrGateway();


                zanrGateway.Nazev=nazevBox.Text;
                zanrGateway.Popis=popisBox.Text;


                Zanr z = new Zanr(zanrGateway);

                zs.InsertZanr(z);

                infoLabel.Text = "KOmentář vložen";

            }
            catch (Exception ex)
            {
                infoLabel.Text = "Něco je špatně";
                Console.WriteLine(ex);
            }
    }
    }
}
