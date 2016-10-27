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
    public partial class detailInterpretaForm : Form
    {
        public detailInterpretaForm(int temp)
        {
            InitializeComponent();

            Interpret interpret = new InterpretService().getInterpreta(temp);


            umeleckeJmenoLabel.Text = "Umelecké jméno: " + interpret.umeleckeJmeno;
            jmenoLabel.Text = "Skutečné jméno: " + interpret.Jmeno;
            datumLabel.Text = "Datum Narození: " + interpret.DatumNarozeni.Year;
            zemeLabel.Text = "Země původu: " + interpret.Zeme;



        }
    }
}
