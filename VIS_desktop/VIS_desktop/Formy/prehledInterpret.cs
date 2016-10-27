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
    public partial class prehledInterpret : Form
    {
        public int selected;

        public prehledInterpret()
        {
            InitializeComponent();

            InterpretService intSer = new InterpretService();

            foreach (Interpret interpret in intSer.getInterprety())
            {


                ListViewItem item1 = new ListViewItem(interpret.Id.ToString());
                item1.SubItems.Add("id");

                ListViewItem item2 = new ListViewItem(interpret.umeleckeJmeno);
                item2.SubItems.Add("jmeno");

                this.prehledInterpretu.Items.AddRange(new ListViewItem[] { item1, item2 });
            }


            if (SessionSingleton.getInstance().isAdministrator())
            {
                this.administraceNovzInterpretButton.Show();
                this.deleteButton.Show();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.prehledInterpretu.SelectedItems.Count > 0)
            {
                try
                {

                    selected = Int32.Parse(prehledInterpretu.SelectedItems[0].Text);
                    detailInterpretaForm detailI = new Formy.detailInterpretaForm(selected);
                    detailI.Show();
                }
                catch (Exception ex)
                {
                    varovaniLabel.Show();
                    exceptionLabel.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formy.administrace.insertInterpret newInterpret = new Formy.administrace.insertInterpret();
            newInterpret.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.prehledInterpretu.SelectedItems.Count > 0)
            {
                try
                {

                    selected = Int32.Parse(prehledInterpretu.SelectedItems[0].Text);
                    InterpretService IntSer = new InterpretService();
                    IntSer.DeleteInterpreta(selected);
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
