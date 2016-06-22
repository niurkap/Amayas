using AmayaWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AmayaWebAPI.Controllers
{
    public class AssetsController : ApiController
    {
        Asset[] assets = new Asset[]
        {
            new Asset { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Asset { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Asset { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Asset> GetAllAssets()
        {
            return assets;
        }

        public IHttpActionResult GetAsset(int id)
        {
            var asset = assets.FirstOrDefault((p) => p.Id == id);
            if (asset == null)
            {
                return NotFound();
            }
            return Ok(asset);
        }
    }
}
