using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        public int id { get; set; }  //car's id
        public string name { get; set; } // car's name 
        public string shortDesc { get; set; } // short description
        public string longDesc { get; set; } // long description
        public string img { get; set; }  // URL adress
        public ushort price { get; set; } // + prive
        public bool isFavourite { get; set; } // if true = main page
        public bool available { get; set; }   // How many > 1?
        public int categoryID { get; set; }
        public virtual Category Category { get; set; } // object
    }
}
