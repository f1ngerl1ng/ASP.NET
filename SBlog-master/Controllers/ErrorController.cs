using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MVC_Intro.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> logger;

        public  ErrorController(ILogger<ErrorController> logger){
            this.logger = logger;
        }

        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "404 Page Not Found";
                    logger.LogWarning($"404 Error Occured. Path = {statusCodeResult.OriginalPath}" + 
                        $" and QueryString = {statusCodeResult.OriginalQueryString}");
                    //ViewBag.Path = statusCodeResult.OriginalPath;
                    //ViewBag.QS = statusCodeResult.OriginalQueryString;
                    break;
            }
            return View("NotFound");
        }
        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            // Retrieve the exception 
            //var exceptionHandlerPathFeature =
            //        HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var exceptionDetail =
                    HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            //ViewBag.ExceptionPath = exceptionHandlerPathFeature.Path;
            //ViewBag.ExceptionMessage = exceptionHandlerPathFeature.Error.Message;
            //ViewBag.StackTrace = exceptionHandlerPathFeature.Error.StackTrace;
            logger.LogError($"The path {exceptionDetail.Path} an exeption {exceptionDetail.Error}");

            return View("Error");
        }
    }
}