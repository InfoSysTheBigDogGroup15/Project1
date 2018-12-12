using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Straws")]
public class Straws
{
	[Key]
    public int strawID { get; set; }

    public string strawMaterial { get; set; }

    public decimal stawHeight { get; set; }

    public string strawColor { get; set; }

}
