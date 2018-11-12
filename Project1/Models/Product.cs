
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class Product
    {
        public string name { get; set; }
        public string manfacture { get; set; }
        public string location { get; set; }
        public string language { get; set; }
        public Image Picture { get; set; }

        public Product(string name, string manfacture, string location, string language, Image picture)
        {
            this.name = name;
            this.manfacture = manfacture;
            this.location = location;
            this.language = language;
            Picture = picture;
        }

        public Product(string name, string manfacture, string location, string language)
        {
            this.name = name;
            this.manfacture = manfacture;
            this.location = location;
            this.language = language;
        }

        public Product()
        {
        }
    }
}