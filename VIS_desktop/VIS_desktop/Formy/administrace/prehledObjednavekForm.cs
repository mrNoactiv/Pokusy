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
    public partial class prehledObjednavekForm : Form
    {
        private ObjednavkaService oser = new ObjednavkaService();

        public int selected;
        public int uz;

        public prehledObjednavekForm()
        {
            InitializeComponent();

            foreach (Objednavka objednavka in oser.getObjednavky())
            {


                ListViewItem item1 = new ListViewItem(objednavka.Id.ToString());
                item1.SubItems.Add("id objednavky");

                ListViewItem item2 = new ListViewItem(objednavka.Uzivatel.ToString());
                item2.SubItems.Add("id uzivatele");

                

                this.prehledView.Items.AddRange(new ListViewItem[] { item1, item2 });
            }



        }

        private void vybratButton_Click(object sender, EventArgs e)
        {
            if (this.prehledView.SelectedItems.Count > 0)
            {
                try
                {
                    selected = Int32.Parse(prehledView.SelectedItems[0].Text);
                    //uz = Int32.Parse(prehledView.SelectedItems[1].Text);
                    DetailObjednavky detailO = new DetailObjednavky(selected);
                    detailO.Show();
                }
                catch (Exception ex)
                {
                    varovaniLabel.Show();
                    exceptionLabel.Show();
                }
            }




        }
    }
}
