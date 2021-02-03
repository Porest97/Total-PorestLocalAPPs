using System;
using System.Collections.Generic;

namespace WebAppRazor.DAIF2020
{
    public partial class ZoneGameReceipt
    {
        public int Id { get; set; }
        public int? ReceiptCategoryId { get; set; }
        public int? ReceiptStatusId { get; set; }
        public int? ReceiptTypeId { get; set; }
        public int? ZoneGameId { get; set; }
        public int Udz1fee { get; set; }
        public int Udz1travelKost { get; set; }
        public int Udz1alowens { get; set; }
        public int Udz1other { get; set; }
        public int Udz1totalFee { get; set; }
        public int Udz2fee { get; set; }
        public int Udz2travelKost { get; set; }
        public int Udz2alowens { get; set; }
        public int Udz2lateGameKost { get; set; }
        public int Udz2other { get; set; }
        public int Udz2totalFee { get; set; }
        public int ZoneGameTotalKost { get; set; }
        public int AmountPaidUdz1 { get; set; }
        public int AmountPaidUdz2 { get; set; }
        public int TotalAmountPaid { get; set; }
        public int TotalAmountToPay { get; set; }
        public int Udz1lateGameKost { get; set; }
    }
}
