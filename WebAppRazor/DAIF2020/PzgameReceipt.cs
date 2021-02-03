using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class PzgameReceipt
    {
        public int Id { get; set; }
        public int? PzgameId { get; set; }
        public int? ZoneGameId11 { get; set; }
        public int? ReceiptCategoryId { get; set; }
        public int? ReceiptStatusId { get; set; }
        public int? ReceiptTypeId { get; set; }
        public double Udz1fee { get; set; }
        public double Udz2fee { get; set; }
        public double Udz3fee { get; set; }
        public double Udz4fee { get; set; }
    }
}
