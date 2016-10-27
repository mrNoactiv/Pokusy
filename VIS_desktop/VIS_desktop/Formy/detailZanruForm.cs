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
    public partial class detailZanruForm : Form
    {
        public int selected;
        private PisnickaService ps=new PisnickaService();
        private ZanrService zs=new ZanrService();

        public detailZanruForm(int TEMP)
        {
            InitializeComponent();


            Zanr zanr = zs.getZanr(TEMP);

            this.nazevLabel.Text = zanr.Nazev;
            this.popisLabel.Text = zanr.Popis;

            foreach (Pisnicka pisnicka in ps.getPisnickyPodleZanru(TEMP))
            {

                ListViewItem item1 = new ListViewItem(pisnicka.Id.ToString());
                item1.SubItems.Add("id");

                ListViewItem item2 = new ListViewItem(pisnicka.Nazev);
                item2.SubItems.Add("nazev");

                this.listPisnicekView.Items.AddRange(new ListViewItem[] { item1, item2 });
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listPisnicekView.SelectedItems.Count > 0)
            {
                try
                {

                    selected = Int32.Parse(listPisnicekView.SelectedItems[0].Text);
                    Formy.detailPisnickaForm detailP = new Formy.detailPisnickaForm(selected);
                    detailP.Show();
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
