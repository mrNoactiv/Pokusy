﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIS_desktop.Interface
{
    public interface IUlozeniFinder
    {
        Collection<IUlozeniGateway> VypisKnihovny(int id);




    }
}
