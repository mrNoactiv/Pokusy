using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Interface;

namespace VIS_desktop.Databaze
{
    public class Interpret
    {
        private IInterpretGateway data;

        public Interpret(IInterpretGateway data)
        {
            this.data = data;
        }

        public string umeleckeJmeno
        {
            get
            {
                return this.data.UmeleckeJmeno;
            }
        }

        public int Id
        {
            get
            {
                return this.data.Id;    
            }
        }

        public string Zeme
        {
            get
            {
                return this.data.Zeme;
            }
        }

        public string Jmeno
        {
            get
            {
                return this.data.Jmeno;
            }
        }

        public DateTime DatumNarozeni
        {
            get
            {
                return this.data.DatumNarozeni;
            }
        }


    }
}
