using asp_films_kruglikov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_films_kruglikov.Controllers
{
    /*UPDATE Film
SET Cover = (
    SELECT *
    FROM OPENROWSET(BULK 'Z:\Popova\ASP.Net\FilmsActors\FilmsPhoto\matrix.jpg', SINGLE_BLOB)AS x )
WHERE Id = 2;*/

    public class FilmsController : Controller
    {
        filmsEntities2 db = new filmsEntities2();
        // GET: Films
        public ActionResult Index()
        {
            ViewBag.Films = db.Films;
            return View();
        }

        public FileContentResult GetImage(int id)
        {
            filmsEntities2 db = new filmsEntities2();

            Film film = db.Films.FirstOrDefault(g => g.Id == id);
            if (film != null)
            {
                return File(film.Cover, film.ImageMimeType);
            }
            else
            {
                return null;
            }
        }
    }
}