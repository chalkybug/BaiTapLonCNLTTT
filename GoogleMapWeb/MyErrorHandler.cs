using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoogleMapWeb
{
    public class MyErrorHandler : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Log(filterContext.Exception);
            throw new NotImplementedException();
        }

        private void Log(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}