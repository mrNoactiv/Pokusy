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
    public partial class knihovnaForm : Form
    {
        public int selected;
        UlozeniService us=new UlozeniService();


        public knihovnaForm()
        {
            InitializeComponent();


            

            foreach (Ulozeni ulozeni in us.getVypisKnihovny(SessionSingleton.getInstance().getLoggedUser().Id))
            {

                idUzivateleLabel.Text = ulozeni.IdUzivatele.ToString();
                idKnihovnyLabel.Text = ulozeni.IdKnihovny.ToString();

                ListViewItem item1 = new ListViewItem(ulozeni.IdPisnicky.ToString());
                item1.SubItems.Add("id");

                ListViewItem item2 = new ListViewItem(ulozeni.NazevPisnicky);
                item2.SubItems.Add("nazev");

                this.prehledKnihovnyView.Items.AddRange(new ListViewItem[] { item1, item2 });
            }


        }

        private void detailButton_Click(object sender, EventArgs e)
        {
            if (this.prehledKnihovnyView.SelectedItems.Count > 0)
            {
                try
                {

                    selected = Int32.Parse(prehledKnihovnyView.SelectedItems[0].Text);
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
