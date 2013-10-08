using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class IndexModel
    {
        public IndexModel()
        {
            Tiles = new List<Tile>();
        }

        public List<Tile> Tiles { get; set; }
    }
}