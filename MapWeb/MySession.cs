using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapWeb
{
    public class MySession
    {

        static public void setKey(string key, string value)
        {
            System.Web.HttpContext.Current.Session[key] = value;
        }

        static public void setAdmin(string key, Account value)
        {
            System.Web.HttpContext.Current.Session[key] = value;
        }


        static public object getKey(string key, object defaultValue = null)
        {
            if (System.Web.HttpContext.Current.Session[key] == null)
            {
                return defaultValue;
            }
            return System.Web.HttpContext.Current.Session[key];

        }

        static public int logout(string Key)
        {
            System.Web.HttpContext.Current.Session[Key] = null;
            return 0;
        }

        // check the login status
        static public bool isLogin(string Key)
        {
            if (System.Web.HttpContext.Current.Session[Key] == null)
            {
                return false;
            }

            return true;
        }
    }
}