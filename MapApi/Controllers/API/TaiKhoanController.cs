using MapData.DTO;
using MapData.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MapApi.Controllers
{
    public class TaiKhoanController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<Account> item = AccountBUS.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
