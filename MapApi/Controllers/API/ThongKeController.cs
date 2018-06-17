
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MapData.BUS;
using MapData.DTO;

namespace MapApi.Controllers
{
    public class ThongKeController : ApiController
    {

        public IHttpActionResult Get()
        {
            DataTable dt = new DataTable();
            dt = ThongKeBUS.Instance.GetData();
            return Ok(dt);
        }

        [HttpGet]
        public IHttpActionResult ThongKeTungKhu(string date1, string date2, string khuvuc)
        {
            List<ThongKe> list = ThongKeBUS.Instance.ThongKeTungKhu(date1, date2, khuvuc);

            return Ok(list);
        }


        [HttpGet]
        public IHttpActionResult ThongKeTatCaKhu(string date1, string date2)
        {
            List<ThongKe> list = ThongKeBUS.Instance.ThongKeTatCaKhu(date1, date2);

            return Ok(list);
        }

    }
}

