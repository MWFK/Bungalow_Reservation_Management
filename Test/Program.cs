using Immeuble.Data;
using Immeuble.Entities;
using ImmeubleService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Option p = new Option() {
                Commodite = Commodite.Chauffage,
                PrixOption=120,
                Bungalow = new Bungalow() {PrixChambre = 10,
                NombreChambre = 3,
                Descriptif = "Vue sur mer "
                

                }
            };

            Context ctx = new Context();
            ctx.Options.Add(p);


            Locataire c = new Locataire() {
                CIN="12345678",
                Nom="Alex",
                Prenom="Patric"
            };

            ctx.Locataires.Add(c);
            ctx.SaveChanges();

            //IServiceReservation ser = new ServiceReservation();
            
                  



            Console.WriteLine("Fin");
            Console.ReadKey();
    }
    }
}
