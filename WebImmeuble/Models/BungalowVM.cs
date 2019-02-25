using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebImmeuble.Models
{
    public class BungalowVM
    {
        public int CodeBungalow { get; set; }
        public float PrixChambre { get; set; }
        public int NombreChambre { get; set; }
        public string Descriptif { get; set; }
    }
}