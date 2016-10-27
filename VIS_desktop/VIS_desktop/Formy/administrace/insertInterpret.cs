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
    public partial class insertInterpret : Form
    {
        public insertInterpret()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {

                InterpretGateway interpretgateway = new InterpretGateway();


                interpretgateway.UmeleckeJmeno = umeleckeBox.Text;
                interpretgateway.Jmeno = jmenoBox.Text;
                interpretgateway.Zeme = zemeBox.Text;
                //interpretgateway.DatumNarozeni = DateTime.ParseExact(datumnarozeniBox.Text, "yyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture);
                DateTime date = new DateTime(1994, 02, 02);
                interpretgateway.DatumNarozeni = date;


                Interpret i = new Interpret(interpretgateway);

                InterpretService intSer = new InterpretService();
                intSer.InsertInterpreta(i);

                infoLabel.Text = "interpret vložen";

            }
            catch (Exception ex)
            {
                infoLabel.Text = "Něco je špatně";
                Console.WriteLine(ex);
            }
        }
    }
}
