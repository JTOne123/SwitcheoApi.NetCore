﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SwitcheoApi.NetCore.Entities
{
    public class DepositParams
    {
        public string scriptHash { get; set; }
        public string operation { get; set; }
        public string[] args { get; set; }
    }
}
