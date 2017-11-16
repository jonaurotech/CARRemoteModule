using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CAR.Inventory
{
  
 

  
    public partial class Center
    {
       
        
        [Key]
        [Column("center")]
        [StringLength(50)]
        public string center { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime created { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime last_updated { get; set; }

        [Required]
        [StringLength(50)]
        public string location_code { get; set; }

      
    }
}

 