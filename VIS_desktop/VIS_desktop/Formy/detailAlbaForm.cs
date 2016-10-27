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
    public partial class detailAlbaForm : Form
    {
        public int selected;
        private int idAlba;
        PisnickaService ps = new PisnickaService();
        public detailAlbaForm(string TEMP)
        {
            InitializeComponent();

            foreach (Pisnicka pisnicka in ps.getPisnickyPodleAlba(TEMP))
            {

                this.nazevAlbaLabel.Text = pisnicka.nazevAlba;
                this.interpretLabel.Text = pisnicka.umeleckeJmenoInterpreta;
                idAlba=pisnicka.idAlba;

                ListViewItem item1 = new ListViewItem(pisnicka.Id.ToString());
                item1.SubItems.Add("id");

                ListViewItem item2 = new ListViewItem(pisnicka.Nazev);
                item2.SubItems.Add("nazev");

                this.listPisnicekView.Items.AddRange(new ListViewItem[] { item1, item2});
            }

            if (SessionSingleton.getInstance().isAdministrator())
            {
                this.administraceInsertPisnicka.Show();
                this.deleteButton.Show();
            }

        }

        private void detailAlbaForm_Load(object sender, EventArgs e)
        {

        }

        private void listPisnicekView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vyberPisnickuButton_Click(object sender, EventArgs e)
        {
            if (this.listPisnicekView.SelectedItems.Count > 0 )
            {
                try
                {

                    selected = Int32.Parse(listPisnicekView.SelectedItems[0].Text);
                    Formy.detailPisnickaForm detailP = new Formy.detailPisnickaForm(selected);
                    detailP.Show();
                }
                catch(Exception ex)
                {
                    varovaniLabel.Show();
                    exceptionLabel.Show();
                }
            }
        }

        private void administraceInsertPisnicka_Click(object sender, EventArgs e)
        {
            Formy.administrace.insertPisnickuDoAlbaForm insertPdA = new Formy.administrace.insertPisnickuDoAlbaForm(idAlba);
            insertPdA.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            if (this.listPisnicekView.SelectedItems.Count > 0)
            {
                try
                {

                    selected = Int32.Parse(listPisnicekView.SelectedItems[0].Text);
                    PisnickaService.DeletePisnicka(selected);
                    infoLabel.Text = "pisnicka smazana";
                    this.Refresh();
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
