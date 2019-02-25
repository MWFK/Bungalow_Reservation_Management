using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immeuble.Entities
{
    public class Reservation
    {
        public int NombreJour { get; set; }
        public float PrixTotal { get; set; }
        [Key,Column(Order =3)]
        public DateTime DateDebut { get; set; }
        public int Saison { get; set; }
        [Key, Column(Order = 1)]
        public int CodeBungalow { get; set; }
        public virtual Bungalow Bungalow { get; set; }
        [Key, Column(Order = 2)]
        public int CIN { get; set; }
        public virtual Locataire Locataire { get; set; }
        
        


    }
}
