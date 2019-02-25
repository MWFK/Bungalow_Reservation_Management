using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immeuble.Data.Repositories
{
    public interface IDatabaseFactory : IDisposable
    {
        Context DataContext { get; }
    }

}
