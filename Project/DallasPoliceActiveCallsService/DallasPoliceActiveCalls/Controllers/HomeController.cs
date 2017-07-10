using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DallasPoliceActiveCalls.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            Repository.HomeRepository homeRepository = new Repository.HomeRepository();

            List<Models.ActiveCallsIndex> activeCallsIndexList = homeRepository.GetData();

            return View(activeCallsIndexList);
        }

        public ActionResult Create(Models.CreateModel createModel)
        {
            if (ModelState.IsValid == true)
            {
                Repository.CreateRepository createRepository = new Repository.CreateRepository();
                createRepository.CreateData(createModel);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Edit(string ID)
        {
            Repository.EditRepository editRepository = new Repository.EditRepository();
            Models.EditModel editModel = editRepository.PopulateEdit(ID);

            return View(editModel);
        }

        [HttpPost]
        public ActionResult Edit(Models.EditModel EditModel)
        {
            if (ModelState.IsValid == true)
            {
                Repository.EditRepository editRepository = new Repository.EditRepository();
                editRepository.EditData(EditModel);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Details(string ID)
        {

            Repository.DetailsRepository detailsRepository = new Repository.DetailsRepository();
            Models.Details details = detailsRepository.GetDetails(ID);
            return View(details);
        }

        public ActionResult Delete(string id)
        {
            Repository.DeleteRepository deleteRepository = new Repository.DeleteRepository();
            Models.DeleteModel delete = deleteRepository.PopulateDelete(id);
            return View(delete);
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            Repository.DeleteRepository deleteRepository = new Repository.DeleteRepository();
            deleteRepository.DeleteData(id);
            return RedirectToAction("Index");
        }
    }
}