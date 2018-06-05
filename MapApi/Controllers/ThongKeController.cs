using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MapData.BUS;

namespace MapApi.Controllers
{
    public class ThongKeController : ApiController
    {
        ThongKeBUS tkbus = new ThongKeBUS();
        public IHttpActionResult Get(string date1, string date2, string khuvuc)
        {
            DataTable dt = new DataTable();
            dt = tkbus.ThongKe( date1,  date2,  khuvuc);
            return Ok(dt);
        }
        public IHttpActionResult Get(string date1, string date2)
        {
            DataTable dt = new DataTable();
            dt = tkbus.ThongKeTatCaKhu(date1, date2);
            return Ok(dt);
        }
        public IHttpActionResult Get()
        {
            DataTable dt = new DataTable();
            dt = tkbus.GetData();
            return Ok(dt);
        }
    }
}

