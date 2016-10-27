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
using VIS_desktop.DatabazeXML;
using VIS_desktop.Domenova;
using VIS_desktop.Interface;

namespace VIS_desktop.Formy.administrace
{
    public partial class insertAlbum : Form
    {
        public insertAlbum()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {

                //AlbumGateway albumgateway = new AlbumGateway();
                IAlbumGateway albumgateway = new XmlAlbumGateway();

                albumgateway.Nazev = nazevBox.Text;
                //interpretgateway.DatumNarozeni = DateTime.ParseExact(datumnarozeniBox.Text, "yyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture);
                DateTime date = new DateTime(1994, 02, 02);
                albumgateway.DatumVydani = date;


                Album a = new Album(albumgateway);


                AlbumService aSer= new AlbumService();
                aSer.InsertAlbum(a);

                infoLabel.Text = "Album vloženo";

            }
            catch (Exception ex)
            {
                infoLabel.Text = "Něco je špatně";
                Console.WriteLine(ex);
            }
        }
    }
}
