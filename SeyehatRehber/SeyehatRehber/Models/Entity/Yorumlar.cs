using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyehatRehber.Models.Entity
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KULLANICIADI { get; set; }
        public string MAIL { get; set; }
        public string YORUM { get; set; }
        public DateTime TARIH { get; set; }
        public int BLOGID { get; set; }
        public virtual Blog BLOG { get; set; }
    }
}