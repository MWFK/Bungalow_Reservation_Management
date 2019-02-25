using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immeuble.Entities
{
    public class Option
    {
        public int CodeOption { get; set; }
        public Commodite Commodite { get; set; }
        public float PrixOption { get; set; }
        
        public int BungalowFK { get; set; }
        [ForeignKey("BungalowFK")]
        public virtual Bungalow Bungalow { get; set; }
        



    }
}
