﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeyehatRehber.Models.Entity
{
    public class Adres
    {
        [Key]
        public int ID { get; set; }
        public string BASLIK { get; set; }
        public string ACIKLAMA { get; set; }
        public string ADRESACIK { get; set; }
        public string MAIL { get; set; }
        public string TELEFON { get; set; }
        public string KONUM { get; set; }
    }
}