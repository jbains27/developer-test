using OrangeBricks.Web.Controllers.Error.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace OrangeBricks.Web.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HttpError404()
        {
            Response.ContentType = "text/html";
            Response.StatusCode = (int)HttpStatusCode.NotFound;

            var model = new ErrorViewModel();
            model.ErrorMessage = Response.StatusCode.ToString();      

            return View("Error", model);
        }
        public ActionResult Error()
        {
            Response.ContentType = "text/html";

            var model = new ErrorViewModel();
            Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            model.RequestedUrl = Request.Url.ToString();

            return View("Error", model);
        }
        
    }
}