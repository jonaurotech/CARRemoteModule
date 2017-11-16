using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace CAR.Inventory
{
    

        public partial class Asset
        {

      

        [Key]
            [StringLength(50)]
            public int barcode { get; set; }

            [Required]
            [StringLength(50)]
            public string model { get; set; }

            [Required]
            [StringLength(50)]
            public string serial_num { get; set; }

            [Required]
            [StringLength(100)]
            public string computer_name { get; set; }

            [Column("datetime_ received", TypeName = "smalldatetime")]
            public DateTime datetime__received { get; set; }

            [Required]
            [StringLength(30)]
            public string state { get; set; }

            [Column(TypeName = "smalldatetime")]
            public DateTime created { get; set; }

            [Column(TypeName = "smalldatetime")]
            public DateTime last_updated { get; set; }

            [Required]
            [StringLength(30)]
            public string APO_PCO_PIV_BADGE_NUM { get; set; }

            [StringLength(50)]
            public string Manufacturer { get; set; }

            public virtual AccountablePropertyOfficer AccountablePropertyOfficer { get; set; }
        }
    }

