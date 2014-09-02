using autotransmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using to_dummyData;
using to_lib;

namespace autotransmission.Controllers
{
    [NoCache]
    public class HomeController : Controller
    {

        private Article _currentArticle;

        public ActionResult LoadArticle(string data)
        {

            var lib = new DataContext();
            switch (data)
            {
                case "at":
                    _currentArticle = lib.GetAutoTransArticle();
                    break;
                case "em":
                    _currentArticle = lib.GetEngineManagementArticle();
                    break;
                case "tt":
                    _currentArticle = lib.GetTechTalkArticle();
                    break;
                case "ss":
                    _currentArticle = lib.GetServiceScheduleArticle();
                    break;
            }

            return View("Index", _currentArticle);
        }

        public ActionResult Index()
        {

            //var lib = new DataContext();

            //_currentArticle = lib.GetAutoTransArticle();
            return View();
        }

        public ActionResult TablesPartial()
        {
            return PartialView("TablesPartial", _currentArticle);
        }


        
        public ActionResult LoadAttributes(Guid id)
        {
            //var thisElement = _currentArticle.GetElementWithId(id);
            //if (thisElement != null)
            //    return PartialView("Popups/Attributes", thisElement.Attributes);
            return PartialView("Popups/Attributes");
        }

        public ActionResult LoadTags(Guid id)
        {
            //var thisElement = _currentArticle.GetElementWithId(id);
            //if (thisElement != null)
            //    return PartialView("Popups/Tags", thisElement.Attributes);
            return PartialView("Popups/Tags");
        }

        public ActionResult LoadCategories()
        {
            return PartialView("Popups/Categories");
        }
        
        public ActionResult LoadKeywords()
        {
            return PartialView("Popups/Keywords");
        }

        public ActionResult LoadContent()
        {
            return PartialView("Popups/Content");
        }


        public ActionResult UploadResource()
        {
            return PartialView("Popups/UploadResource");
        }

        public ActionResult ConfigureResource()
        {
            return PartialView("Popups/ConfigureResource");
        }


        public ActionResult GetServiceIntervals()
        {
            var ss = ((ServiceSchedule)_currentArticle.Sections[1].Elements[0]).ServiceIntervals;
            return PartialView("Popups/ServiceIntervals", ss );
        }
    }
}