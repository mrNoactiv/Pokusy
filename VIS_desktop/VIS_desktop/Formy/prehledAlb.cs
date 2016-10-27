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

    public partial class prehledAlb : Form
    {
        private string selected;
        public prehledAlb()
        {
            InitializeComponent();
            foreach(Album album in new AlbumService().getAlbums())
            {
                this.prehledAlbView.Items.Add(new ListViewItem(album.Nazev));
            }

            if (SessionSingleton.getInstance().isAdministrator())
            {
                this.insertAlbum.Show();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prehledAlbView.SelectedItems.Count > 0)
            {
                selected = prehledAlbView.SelectedItems[0].Text;
                Formy.detailAlbaForm detailA = new Formy.detailAlbaForm(selected);
                detailA.Show();
            }
        }
        public string getSelected()
        {
            return selected;
        }

        private void insertAlbum_Click(object sender, EventArgs e)
        {
            Formy.administrace.insertAlbum newAlbum = new Formy.administrace.insertAlbum();
            newAlbum.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
