using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Error.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestedUrl { get; set; }
        public string ReferrerUrl { get; set; }
        public string ErrorType { get; set; }
        public string ErrorMessage { get; set; }
    }
}