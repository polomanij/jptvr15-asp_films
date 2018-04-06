﻿using asp_films_kruglikov.Models;
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
        public filmsEntities2 db = new filmsEntities2();
        // GET: Films
        public ActionResult Index()
        {
            ViewBag.Films = db.Films;
            return View();
        }

        public ActionResult Actor(string id)
        {
            int actorId = Int32.Parse(id);
            Actor actor = db.Actors.FirstOrDefault(g => g.Id == actorId);
            if (actor != null)
            {
                ViewBag.Actor = actor;
            } else
            {
                return HttpNotFound();
            }
            return View();
        }

        public FileContentResult GetFilmImage(int id)
        {
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

        public FileContentResult GetActorImage(int id)
        {
            Actor actor = db.Actors.FirstOrDefault(g => g.Id == id);
            if (actor != null)
            {
                return File(actor.Photo, actor.ImageMimeType);
            }
            else
            {
                return null;
            }
        }
    }
}