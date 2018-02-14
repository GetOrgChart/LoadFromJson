using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoadFromJson.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public JsonResult GetData()
        {
            var data = new[] {
                new { id = "1", parentId = "",     name = "Amber McKenzie" },
                new { id = "2", parentId = "1",    name = "Ava Field"},
                new { id = "3", parentId = "1",    name = "Evie Johnson"},
                new { id = "4", parentId = "1",    name = "Paul Shetler"},
                new { id = "5", parentId = "2",    name = "Rebecca Francis"},
                new { id = "6", parentId = "2",    name = "Rebecca Randall"},
                new { id = "7", parentId = "2",    name = "Spencer May"},
                new { id = "8", parentId = "6",    name = "Max Ford"},
                new { id = "9", parentId = "7",    name = "Riley Bray"}
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}