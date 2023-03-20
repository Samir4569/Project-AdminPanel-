using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_AdminPanel_.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ProjectName { get; set; }
        public string Startdate { get; set; }
        public string PaymentMode { get; set; }
        public bool IsAproved { get; set; }
        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
