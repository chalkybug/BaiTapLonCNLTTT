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

        // GET: api/Manager/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Manager
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Manager/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Manager/5
        public void Delete(int id)
        {
        }
    }
}
