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
    public partial class KosikForm : Form
    {
        public KosikForm()
        {
            InitializeComponent();

            foreach (Pisnicka pisnicka in Kosik.getInstance().getPisnicky())
            {


                ListViewItem item1 = new ListViewItem(pisnicka.Id.ToString());
                item1.SubItems.Add("id");

                ListViewItem item2 = new ListViewItem(pisnicka.Nazev);
                item2.SubItems.Add("nazev");

                this.obsahKosikuView.Items.AddRange(new ListViewItem[] { item1, item2 });
            }

        }

        private void znicitKosikButton_Click(object sender, EventArgs e)
        {
            Kosik.getInstance().znicitKosik();
            this.Close();
        }

        private void potvrditButton_Click(object sender, EventArgs e)
        {
            Formy.OdeslaniObjednavkyForm obj = new Formy.OdeslaniObjednavkyForm();
            obj.Show();
        }
    }
}
