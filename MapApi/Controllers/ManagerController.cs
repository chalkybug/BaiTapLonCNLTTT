using MapData.BUS;
using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MapApi.Controllers
{
    public class ManagerController : ApiController
    {
        // GET: api/Manager
        public IHttpActionResult Get()
        {
            List<DamChay> damchay = DamChayBUS.Instance.GetList();
            return Ok(damchay);

        }
        
    }
}
