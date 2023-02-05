using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWeb.Models.Classes
{
    public class Icon
    {
        [Key]
        public int id { get; set; }
        public string icon { get; set; }
        public string link { get; set; }
    }
}