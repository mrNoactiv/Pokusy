﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIS_desktop.Databaze;

namespace VIS_desktop.Interface
{
    public interface IHodnoceniPisnickyFinder
    {
        Collection<IHodnoceniPisnickyGateway> selectPisnicky(int id);
    }
}
