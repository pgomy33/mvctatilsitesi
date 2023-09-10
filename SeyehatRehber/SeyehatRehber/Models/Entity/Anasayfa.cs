using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyehatRehber.Models.Entity
{
    public class Anasayfa
    {
        [Key]
        public int ID { get; set; }
        public string BASLIK { get; set; }
        public string ACIKLAMA { get; set; }
    }
}