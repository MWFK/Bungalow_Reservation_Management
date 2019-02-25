using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Immeuble.Entities
{
    public class ReservationVM
    {
        public int NombreJour { get; set; }
        public float PrixTotal { get; set; }
        public DateTime DateDebut { get; set; }
        public int Saison { get; set; }
        
        [Display(Name = "Bungalow")]
        public int CodeBungalow { get; set; }
        public IEnumerable<SelectListItem> Bungalows { get; set; }
        [Display(Name = "Locataire")]
        public int CIN { get; set; }
        public IEnumerable<SelectListItem> Locataires { get; set; }
       





    }
}
