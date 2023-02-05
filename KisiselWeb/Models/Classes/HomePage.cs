using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWeb.Models.Classes
{
    public class HomePage
    {
        [Key]
        public int id { get; set; }
        public string profile { get; set; }
        public string name { get; set; }
        public string job{ get; set; }
        public string description{ get; set; }
        public string contact { get; set; }

    }
}