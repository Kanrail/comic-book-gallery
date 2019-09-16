using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml =
                    "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "dan slott", Role = "Script"},
                    new Artist() {Name = "humberto ramos", Role = "Pencils"},
                    new Artist() {Name = "victor olazaba", Role = "Inks"},
                    new Artist() {Name = "edgar delgado", Role = "Colors"},
                    new Artist() {Name = "chris eliopoulos", Role = "Letters"},
                }
            };

            return View(comicBook);
        }
    }
}