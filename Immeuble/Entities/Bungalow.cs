using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immeuble.Entities
{
    public class Bungalow
    {
        public int CodeBungalow { get; set; }
        public float PrixChambre { get; set; }
        public int NombreChambre { get; set; }
        public string Descriptif { get; set; }

        public Adresse Adresse { get; set; }
        public virtual ICollection<Option> Options { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }

    public class Adresse
    {
        public string Ville { get; set; }
        public string Rue { get; set; }
        public int CodePostal { get; set; }
    }
}
