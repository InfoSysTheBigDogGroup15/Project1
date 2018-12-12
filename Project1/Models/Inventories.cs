using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1.models
{
    [Table("Inventories")]
    public class Inventories
    {
            [Key]
            [Required]
            public int inventoryID { get; set; }

            public int? strawID { get; set; }
            public virtual Straw Straw { get; set; }


            public int quantity { get; set; }
    }
            
}
