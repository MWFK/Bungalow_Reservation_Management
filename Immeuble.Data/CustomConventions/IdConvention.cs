using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immeuble.Data.CustomConventions
{
    public class IdConvention : Convention
    {
        public IdConvention()
        {
            Properties<int>().Where(p=>p.Name.StartsWith("Code")).Configure(p=>p.IsKey());
        }
    }
}
