using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeyehatRehber.Models.Entity
{
    public class Blog
    {
        public int ID { get; set; }
        public string BASLIK { get; set; }
        public DateTime TARIH { get; set; }
        public string ACIKLAMA { get; set; }
        public string BLOGIMAGE { get; set; }
    }
}