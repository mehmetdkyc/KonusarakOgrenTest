using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities
{
    public class Products
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }

    }
}
