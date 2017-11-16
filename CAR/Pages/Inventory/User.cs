using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace CAR.Inventory
{

   

        public partial class User
        {

       

        [Key]
            [StringLength(30)]
            public string USER_PIV_BADGE_NUM { get; set; }

            [Required]
            [StringLength(50)]
            public string last_name { get; set; }

            [Required]
            [StringLength(50)]
            public int barcode { get; set; }

            [Required]
            [StringLength(50)]
            public int previous_barcode { get; set; }

            [Required]
            [StringLength(50)]
            public string first_name { get; set; }

            [StringLength(2)]
            public string middle_initial { get; set; }

            [Column(TypeName = "smalldatetime")]
            public DateTime datetime_assigned { get; set; }

            [Required]
            [StringLength(20)]
            public string outstanding_asset { get; set; }

            [Required]
            [StringLength(50)]
            public string email { get; set; }

            [Column(TypeName = "smalldatetime")]
            public DateTime? created { get; set; }

            [Column(TypeName = "smalldatetime")]
            public DateTime? last_updated { get; set; }

            [StringLength(30)]
            public string APO_PCO_PIV_BADGE_NUM { get; set; }
        }
    }

