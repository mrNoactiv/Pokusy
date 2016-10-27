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
    public partial class prehledPisnicek : Form
    {
        public int selected;
        PisnickaService ps = new PisnickaService();
        public prehledPisnicek()
        {
            InitializeComponent();

            foreach (Pisnicka pisnicka in ps.getPisnicky())
            {


                ListViewItem item1 = new ListViewItem(pisnicka.Id.ToString());
                item1.SubItems.Add("id");

                ListViewItem item2 = new ListViewItem(pisnicka.Nazev);
                item2.SubItems.Add("nazev");

                this.prehledPisnicekView.Items.AddRange(new ListViewItem[] { item1, item2 });
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prehledPisnicek_Load(object sender, EventArgs e)
        {

        }

        private void vyberButton_Click(object sender, EventArgs e)
        {
            

            if (this.prehledPisnicekView.SelectedItems.Count > 0)
            {
                try
                {

                    selected = Int32.Parse(prehledPisnicekView.SelectedItems[0].Text);
                    detailPisnickaForm detailP = new Formy.detailPisnickaForm(selected);
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
