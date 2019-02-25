using Immeuble.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immeuble.Data.Configurations
{
    class OptionConfiguration : EntityTypeConfiguration<Option>
    {
        public OptionConfiguration()
        {
            HasRequired<Bungalow>(o => o.Bungalow).WithMany(b => b.Options).HasForeignKey(o => o.BungalowFK).WillCascadeOnDelete(true);
        }
    }
}
