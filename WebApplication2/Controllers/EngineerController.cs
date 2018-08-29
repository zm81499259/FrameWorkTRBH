using BLLContainer;
using IBusinessLogicLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class EngineerController : Controller
    {
        IEngineeringService service = null;
        public EngineerController()
        {
            service=BusinessLogicLayerContainer.Resolve<IEngineeringService>();
        }
        // GET: Engineer
        public ActionResult Index()
        {
            var data = service.GetAllList();
            return View(data);
        }
    }
}