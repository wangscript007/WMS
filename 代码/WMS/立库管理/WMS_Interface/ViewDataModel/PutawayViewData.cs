﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WMS_Interface
{
    public class PutawayViewData
    {
        private BindingList<PalletInfor> palletInforData = new BindingList<PalletInfor>();
        public BindingList<PalletInfor> PalletInforData
        {
            get { return this.palletInforData; }
            set { this.palletInforData = value; }
        }
        public PutawayViewData()
        { }
    }
 
}
