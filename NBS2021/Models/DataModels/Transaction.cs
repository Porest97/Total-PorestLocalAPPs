using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NBS2021.Models.DataModels
{
    public class Transaction
    {
        public int Id { get; set; }

        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeChanged { get; set; }

        public Transaction()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }

        [Display(Name = "Datum/Tid")]
        public DateTime TransactionDate { get; set; }

        [Display(Name = "Konto")]
        public int SallaryAccountId { get; set; }
        [Display(Name = "Konto")]
        [ForeignKey("SallaryAccountId")]
        public SallaryAccount SallaryAccount { get; set; }

        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        [Display(Name = "Antal")]
        public decimal NumberOf { get; set; }

        [Display(Name = "Tim")]
        public decimal Hours { get; set; }

        [Display(Name = "Pris")]
        public decimal Price { get; set; }

        [Display(Name = "Belopp")]
        public decimal TransactionAmount { get; set; }

        [Display(Name = "Status")]
        public int TransactionStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("TransactionStatusId")]
        public TransactionStatus TransactionStatus { get; set; }

    }

    public class TransactionStatus
    {
        public int Id { get; set; }

        public string TrStatusName { get; set; }
    }
}
