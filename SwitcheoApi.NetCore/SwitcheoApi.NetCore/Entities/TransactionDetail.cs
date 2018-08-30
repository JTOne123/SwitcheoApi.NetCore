﻿namespace SwitcheoApi.NetCore.Entities
{
    public class TransactionDetail
    {
        public string hash { get; set; }
        public string sha256 { get; set; }
        public int type { get; set; }
        public int version { get; set; }
        public TransactionAttributes[] attributes { get; set; }
        public TransactionInput[] inputs { get; set; }
        public TransactionOutput[] outputs { get; set; }
        public string[] scripts { get; set; }
        public string script { get; set; }
        public decimal gas { get; set; }
    }
}
