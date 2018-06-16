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
    public class TruNuocController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<TruNuoc> item = TruNuocBUS.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }


        public IHttpActionResult Post([FromBody] TruNuoc x)
        {

            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            TruNuocBUS.Instance.Create(x.city, x.county, x.address, x.lat, x.lng);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] TruNuoc x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            TruNuocBUS.Instance.Update(x.id,x.city, x.county, x.address, x.lat, x.lng);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            TruNuocBUS.Instance.Delete(id);
            return Ok();
        }
    }
}
