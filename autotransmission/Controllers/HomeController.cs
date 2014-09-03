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

        private SessionState _session = new SessionState();


        public ActionResult LoadArticle(string data)
        {

            var lib = new DataContext();
            switch (data)
            {
                case "at":
                    _session.CurrentArticle = lib.GetAutoTransArticle();
                    break;
                case "em":
                    _session.CurrentArticle = lib.GetEngineManagementArticle();
                    break;
                case "tt":
                    _session.CurrentArticle = lib.GetTechTalkArticle();
                    break;
                case "ss":
                    _session.CurrentArticle = lib.GetServiceScheduleArticle();
                    break;
            }

            return View("Index", _session.CurrentArticle);
        }

        public ActionResult Index()
        {

            //var lib = new DataContext();

            //_currentArticle = lib.GetAutoTransArticle();
            return View();
        }

        public ActionResult TablesPartial()
        {
            return PartialView("TablesPartial", _session.CurrentArticle);
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
            //var ss = new ServiceIntervalEditorModel(((ServiceSchedule)_session.CurrentArticle.Sections[0].Elements[0]).ServiceIntervals);
            return PartialView("Popups/ServiceIntervals", ((ServiceSchedule)_session.CurrentArticle.Sections[0].Elements[0]).ServiceIntervals );
        }

        [HttpPost]
        public ActionResult SaveIntervals(List<ServiceInterval> intervals)
        {
            var ss = (ServiceSchedule)_session.CurrentArticle.Sections[0].Elements[0];

            foreach (var i in intervals)
            {
                foreach (var sog in ss.ServiceOperationGroups)
                {
                    foreach (var so in sog.ServiceOperations)
                    {
                        so.ServiceOperations.Add(new ServiceIntervalOperation() { ServiceInterval = i, OperationType = operationType.Adjust });
                    }
                }
            }

            return RedirectToAction("ShowServiceSchedule", new {ss = ss});
        }


        public ActionResult ShowServiceSchedule(ServiceSchedule ss)
        {
            return View(ss);
        }
    }
}