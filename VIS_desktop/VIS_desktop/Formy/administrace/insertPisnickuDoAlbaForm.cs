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
using VIS_desktop.Interface;


namespace VIS_desktop.Formy.administrace
{
    public partial class insertPisnickuDoAlbaForm : Form
    {
        private int selectedAlbum;

        public insertPisnickuDoAlbaForm(int id)
        {
            InitializeComponent();
            selectedAlbum = id;
            albumBox.Text = id.ToString();


        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                IPisnickaGateway pisnickagateway = new PisnickaGateway();
                IAlbumGateway albumGateway = new AlbumGateway();
                IZanrGateway zanrgateway = new ZanrGateway();
                IInterpretGateway interpretgateway = new InterpretGateway();


                pisnickagateway.Nazev=nazevBox.Text;
                pisnickagateway.Delka=delkaBox.Text;
                zanrgateway.Id=Int32.Parse(zanrBox.Text);
                interpretgateway.Id = Int32.Parse(interpretBox.Text);
                albumGateway.Id=Int32.Parse(albumBox.Text);





                Pisnicka p = new Pisnicka(pisnickagateway);
                Interpret i = new Interpret(interpretgateway);
                Zanr z = new Zanr(zanrgateway);
                Album a = new Album(albumGateway);


                PisnickaService.InsertPisnicku(p,i,z,a);

                infoLabel.Text = "pisnicka vložena";

            }
            catch (Exception ex)
            {
                infoLabel.Text = "Něco je špatně";
                Console.WriteLine(ex);
            }




        }
    }
}
