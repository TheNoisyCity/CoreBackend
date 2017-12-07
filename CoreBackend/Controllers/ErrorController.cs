using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreBackend.InnerModels;

namespace CoreBackend.Controllers
{
    [Route("[Controller]")]
    public class ErrorController : Controller
    {
        // GET: /<controller>/
        public JsonResult Index(int statusCode)
        {
            Error result = new Error();
            result.statusCode = statusCode;
            result.message = "Sample message";
            return Json(result);
        }
    }
}
