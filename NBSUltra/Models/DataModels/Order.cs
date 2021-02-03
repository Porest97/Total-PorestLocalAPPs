using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NBSUltra.Models.DataModels
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Kund")]
        public int? CompanyId { get; set; }
        [Display(Name = "Kund")]
        [ForeignKey("CompanyId")]
        public Company Customer { get; set; }

        [Display(Name = "Beskrivning")]
        public string OrderDescription { get; set; }
        
        [Display(Name = "Site")]
        public int? CustomerSiteId { get; set; }
        [Display(Name = "Site")]
        [ForeignKey("CustomerSiteId")]
        public CustomerSite CustomerSite { get; set; }

        [Display(Name = "Ant.")]
        public decimal Quantity { get; set; }

        [Display(Name = "Pris")]
        public decimal Price { get; set; }

        [Display(Name = "Totalt")]
        public decimal TotalOrderValue { get; set; }

        [Display(Name = "PO#")]
        public string CustomerPONumber { get; set; }

        [Display(Name = "Status")]
        public int? OrderStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("OrderStatusId")]
        public OrderStatus OrderStatus { get; set; }
    }
}