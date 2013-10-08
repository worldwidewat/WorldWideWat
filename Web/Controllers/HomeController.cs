using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new IndexModel();

            model.Tiles.Add(new Tile
                                {
                                    Title = "upboat.me",
                                    Description = @"Build a meme from anywhere by linking 
                                                    to upboat.me. Put your meme info right 
                                                    in the url.",
                                    Url = "http://upboat.me",
                                    ImageUrl = "http://placekitten.com/300/100"
                                });

            model.Tiles.Add(new Tile
                                {
                                    Title = "iffylink.com",
                                    Description =
                                        @"A volatile URL-shortener. Nothing lasts forever, 
                                          why should short links?",
                                    Url = "http://iffylink.com",
                                    ImageUrl = "http://placekitten.com/301/100"
                                });

            model.Tiles.Add(new Tile
                                {
                                    Title = "tickstodatetime.com",
                                    Description =
                                        @"Convert .NET <code>Ticks</code> to a human-readable 
                                          <code>DateTime</code>.",
                                    Url = "http://tickstodatetime.com",
                                    ImageUrl = "http://placekitten.com/302/100"
                                });

            model.Tiles.Add(new Tile
                                {
                                    Title = "datetimetostring.com",
                                    Description =
                                        @"Quick and direct access to all those obscure format
                                          strings for .NET's <code>DateTime</code>.",
                                    Url = "http://datetimetostring.com",
                                    ImageUrl = "http://placekitten.com/303/100"
                                });

            return View(model);
        }

    }
}
