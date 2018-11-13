
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
        public string Name { get; set; }
        public string Manfacture { get; set; }
        public string Location { get; set; }
        public string Language { get; set; }
        public Image Picture { get; set; }

        public Product(string name, string manfacture, string location, string language, Image picture)
        {
            this.Name = name;
            this.Manfacture = manfacture;
            this.Location = location;
            this.Language = language;
            Picture = picture;
        }

        public Product(string name, string manfacture, string location, string language)
        {
            this.Name = name;
            this.Manfacture = manfacture;
            this.Location = location;
            this.Language = language;
        }

        public Product()
        {
        }
    }
}