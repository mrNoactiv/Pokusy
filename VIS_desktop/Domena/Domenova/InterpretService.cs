using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;
using VIS_desktop.DatabazeXML;
using VIS_desktop.Interface;

namespace VIS_desktop.Domenova
{
    public class InterpretService
    {
        private IInterpretFinder finder;


        public InterpretService()
        {
            finder = new InterpretFinder();
        }

        public Collection<Interpret> getInterprety()
        {

            //Collection<InterpretGateway> InterpretGateways = InterpretFinder.SELECT();
            Collection<IInterpretGateway> InterpretGateways = finder.SELECT();
            Collection<Interpret> interpreti = new Collection<Interpret>();
            foreach (IInterpretGateway ig in InterpretGateways)
            {
                interpreti.Add(new Interpret(ig));
            }
            return interpreti;

        }

        public Interpret getInterpreta(int param)
        {

            //InterpretGateway InterpretGateway = new InterpretFinder().SelectId(param);
            IInterpretGateway InterpretGateway = finder.SelectId(param);
            Interpret interpret = new Interpret(InterpretGateway);

            return interpret;

        }


        public void InsertInterpreta(Interpret interpret)
        {

            Interpret i = interpret;
            IInterpretGateway ig = new InterpretGateway();

            ig.UmeleckeJmeno = i.umeleckeJmeno;
            ig.Jmeno = i.Jmeno;
            ig.DatumNarozeni = i.DatumNarozeni;
            ig.Zeme = i.Zeme;

            ig.Insert();

        }

        public void DeleteInterpreta(int id)
        {
            IInterpretGateway ig = new XmlInterpretGateway();

            ig.Delete(id);
        }

    }
}
