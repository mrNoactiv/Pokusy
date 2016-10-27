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
    public partial class prehledZanru : Form
    {
        public int selected;

        private ZanrService zs=new ZanrService();
        public prehledZanru()
        {
            InitializeComponent();

            
            foreach(Zanr z in zs.getZanry())
            {

                ListViewItem item1 = new ListViewItem(z.Id.ToString());
                item1.SubItems.Add("id");

                ListViewItem item2 = new ListViewItem(z.Nazev);
                item2.SubItems.Add("nazev");

                this.prehledZanrView.Items.AddRange(new ListViewItem[] { item1, item2 });
            }

            if (SessionSingleton.getInstance().isAdministrator())
            {
                this.administraceNovyzanrButton.Show();
            }


        }

        private void vyberZanrButton_Click(object sender, EventArgs e)
        {
            if (this.prehledZanrView.SelectedItems.Count > 0)
            {
                try
                {
                    selected = Int32.Parse(prehledZanrView.SelectedItems[0].Text);
                    Formy.detailZanruForm detailZ = new Formy.detailZanruForm(selected);
                    detailZ.Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(e);
                    varovaniLabel.Show();
                    exceptionLabel.Show();
                }
            }
        }

        private void insertzanrButton_Click(object sender, EventArgs e)
        {
            Formy.administrace.insertZanr newZanr = new Formy.administrace.insertZanr();
            newZanr.Show();
        }
    }
}
