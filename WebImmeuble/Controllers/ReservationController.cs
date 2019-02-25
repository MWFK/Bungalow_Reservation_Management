using Immeuble.Entities;
using AutoMapper;
using ImmeubleService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebImmeuble.Helpers;
using WebImmeuble.Models;

namespace WebImmeuble.Controllers
{
    public class ReservationController : Controller
    {
        IServiceReservation serviceRes = null;
        IServiceLocataire serviceLoc = null;
        IserviceBungalow serviceBung = null;
        public ReservationController()
        {
            serviceRes = new ServiceReservation();
            serviceLoc = new ServiceLocataire();
            serviceBung =new ServiceBungalow();
        }
        // GET: Reservation
        public ActionResult Index()
        {
            //List<Reservation> result = serviceRes.GetMany().ToList();
            //List<ReservationVM> listevm = Mapper.Map<List<Reservation>, List<ReservationVM>>(result);
            var res = serviceRes.GetMany();
            List<ReservationVM> liste = new List<ReservationVM>();
            foreach (var item in res)
            {
                liste.Add(
                    new ReservationVM
                    {
                        NombreJour = item.NombreJour,
                        PrixTotal = item.PrixTotal,
                        Saison = item.Saison,
                        DateDebut = item.DateDebut,
                        CIN = item.CIN,
                        CodeBungalow = item.CodeBungalow
                    });
            }

            return View(liste);
        }

        // GET: Reservation/Details/5
        public ActionResult Details(int id)
        {
            Bungalow b = serviceBung.GetById(id);
            BungalowVM bvm = new BungalowVM() {
                //CodeBungalow =b.CodeBungalow,
                Descriptif=b.Descriptif,
                NombreChambre=b.NombreChambre,
                PrixChambre=b.PrixChambre
            };
            return View(bvm);
        }

        // GET: Reservation/Create
        public ActionResult Create()
        {
            var Res = new ReservationVM();

            Res.Locataires = serviceLoc.GetMany().ToSelectListItems();
            Res.Bungalows = serviceBung.GetMany().ToSelectListItems();


            return View(Res);
        }

        // POST: Reservation/Create
        [HttpPost]
        public ActionResult Create(ReservationVM resVM)
        {
            Reservation reservation = new Reservation()
            {
                CIN = resVM.CIN,
                DateDebut = resVM.DateDebut,
                NombreJour = resVM.NombreJour,
                PrixTotal = resVM.PrixTotal,
                Saison=resVM.Saison,
                CodeBungalow = resVM.CodeBungalow,
            };
            serviceRes.Add(reservation);
            serviceRes.Commit();
            return RedirectToAction("Index");
        }

        // GET: Reservation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
