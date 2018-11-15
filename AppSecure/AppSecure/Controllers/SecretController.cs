using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppSecure.Controllers
{
    public class SecretController : Controller
    {
        // GET: Secret
        [Authorize]
        //[Authorize (Roles="Admin, erik.guerrero@uttt.edu.mx")]
        public ContentResult Secret()
        {
            return Content("Este es un Secreto");
        }
        [AllowAnonymous]
        public ContentResult Overt()
        {
            return Content("Este no es un Secreto");
        }
    }
}