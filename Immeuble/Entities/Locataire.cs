using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immeuble.Entities
{
    public class Locataire
    {
        [Key]
        public string CIN { get; set; }
        public string  Nom { get; set; }
        public string Prenom { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
