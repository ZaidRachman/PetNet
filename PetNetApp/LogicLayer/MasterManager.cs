﻿using DataAccessLayer;
using DataAccessLayerInterfaces;
using DataObjects;
using LogicLayerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class MasterManager
    {
        public IKennelManager KennelManager { get; set; }

        public MasterManager()
        {
            KennelManager = new KennelManager();
        }
    }
}
