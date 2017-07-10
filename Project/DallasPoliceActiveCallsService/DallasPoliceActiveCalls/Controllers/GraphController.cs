using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DallasPoliceActiveCalls.Controllers
{
    public class GraphController : Controller
    {
        // GET: Graph
        public ActionResult Graph()
        {
            Repository.GraphRepository graphRepository = new Repository.GraphRepository();
           List<Models.PriorityGraphModel> delete = graphRepository.GetPriorityGraphDetails();
            return View(delete);
        }
    }
}