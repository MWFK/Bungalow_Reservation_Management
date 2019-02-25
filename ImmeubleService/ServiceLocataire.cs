using Immeuble.Data.Repositories;
using Immeuble.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmeubleService
{
    public class ServiceLocataire : Service<Locataire>, IServiceLocataire
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public ServiceLocataire()
           : base(ut)
        {

        }
    }
}
