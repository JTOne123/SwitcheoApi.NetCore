﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SwitcheoApi.NetCore.Entities
{
    public class DepositWithdrawalParams
    {
        public decimal amount { get; set; }
        public string asset_id { get; set; }
        public string blockchain { get; set; }
        public string contract_hash { get; set; }
        public long timestamp { get; set; }
    }
}