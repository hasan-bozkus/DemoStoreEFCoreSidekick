using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoStoreEFCoreSidekick.WebIU
{
    public partial class Product
    {
        [Required]
        [Key]
        public int ProductId { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(50)]
        public string? ProductName { get; set; }

        public decimal? ProductPrice { get; set; }

        public int? ProductStoct { get; set; }

        public bool? ProductStatus { get; set; }

        public virtual Category? Category { get; set; }
    }
}
