using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapWeb.Models
{
    public class CustomAuthenticationAttribute : FilterAttribute, IAuthorizationFilter
    {


        public string Roles { get; set; }

        public void OnAuthorization(AuthorizationContext filterContext)
        {

            //Kiểm tra session

            if (!MySession.isLogin(GroupName.ADMIN_GROUP))
            {
                //Chuyển sang form đăng nhập
                filterContext.Result = new RedirectResult("/Admin/Login");
                return;
            }

            // get permission user
       

        }
    }
}