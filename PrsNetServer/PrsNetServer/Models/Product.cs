using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrsNetServer.Models {
    public class Product {
        public int Id { get; set; }
        [StringLength(20)]
        [Required]
        public string PartNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; } = 10.99m;
        [StringLength(20)]
        [Required]
        public string Unit { get; set; }
        [StringLength(255)]
        public string Photopath { get; set; }

        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
        public Product() {

            }
        }
    }
