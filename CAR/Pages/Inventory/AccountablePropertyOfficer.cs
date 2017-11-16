
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CAR.Inventory
{
   

        [Table("AccountablePropertyOfficer")]
        public partial class AccountablePropertyOfficer
        {
            

            [Required]
            [StringLength(50)]
            public string user_id { get; set; }

            [Required]
            [StringLength(50)]
            public string center { get; set; }

            public bool CAR_admin { get; set; }

            [Column("must change pwd")]
            public bool? must_change_pwd { get; set; }

            [Required]
            [StringLength(20)]
            public string password { get; set; }

            [Required]
            [StringLength(50)]
            public string last_name { get; set; }

            [StringLength(1)]
            public string middle_initial { get; set; }

            [Required]
            [StringLength(50)]
            public string first_name { get; set; }

            [Required]
            [StringLength(15)]
            public string phone_num { get; set; }

            [Required]
            [StringLength(75)]
            public string email { get; set; }

            [StringLength(100)]
            public string password_reminder { get; set; }

            [Column(TypeName = "smalldatetime")]
            public DateTime created { get; set; }

            [Column(TypeName = "smalldatetime")]
            public DateTime last_updated { get; set; }

            public bool? can_send_reminder { get; set; }

            public bool? enabled { get; set; }

            [Key]
            [StringLength(30)]
            public string APO_PCO_PIV_BADGE_NUM { get; set; }

            public virtual Center Center { get; set; }

         
            public virtual ICollection<Asset> Assets { get; set; }
        }
    }

