﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Interface
{
    public interface IZanrFinder
    {

         Collection<IZanrGateway> SELECT();
         IZanrGateway SelectId(int id);

    }
}
