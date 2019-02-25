using Immeuble.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebImmeuble.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Locataire> Locataires)
        {
            return
                Locataires.OrderBy(loc=>loc.CIN)
                      .Select(loc =>
                          new SelectListItem
                          {
                              //Selected = (loc.CIN == selectedId),
                              Text = loc.Nom + " " + loc.Prenom,
                              Value = loc.CIN
                          });
        }
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Bungalow> Bungalows)
        {
            return
                Bungalows
                      .Select(bun =>
                          new SelectListItem
                          {
                              //Selected = (loc.CIN == selectedId),
                              Text = bun.NombreChambre.ToString(),
                              Value = bun.CodeBungalow.ToString()
                          });
        }
    }
}