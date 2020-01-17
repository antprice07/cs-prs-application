using PrsNetServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrsNetServer.Controllers
{
    public class Request
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        [StringLength(255)]
        public string Justification { get; set; }
        [Required]
        public DateTime DateNeeded { get; set; }
        [Required]
        [StringLength(25)]
        public string DeliveryMode { get; set; }
        [Required]
        [StringLength(10)]
        public string Status { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        [Required]
        public decimal Total { get; set; } = 0.0m;
        [Required]
        public DateTime SubmittedDate { get; set; }
        [StringLength(100)]
        public string ReasonForRejection { get; set; }

        public Request()
        {

        }

    }
}
