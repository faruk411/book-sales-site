using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();
        [Required(ErrorMessage = "Ad alanı zorunlu.")]
        public String? Name { get; set; }
        [Required(ErrorMessage = "Soyad alanı zorunlu.")]
        public String? Soyad { get; set; }
        public String? Eposta { get; set; }
        public String? Address { get; set; }
        public String? Sehir { get; set; }
        public bool GiftWrap { get; set; }
        public bool Shipped { get; set; }
        public DateTime OrdereAt { get; set; } = DateTime.Now;

    }
}
