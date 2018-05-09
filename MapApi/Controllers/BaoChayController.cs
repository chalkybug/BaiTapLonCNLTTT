
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
    public class BaoChayController : ApiController
    {

        public IHttpActionResult Get()
        {
            List<BaoChay> item = BaoChayBUS.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] BaoChay x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            BaoChayBUS.Instance.Create(x.city, x.county, x.address, x.lat, x.lng);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] BaoChay x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            BaoChayBUS.Instance.Update(x.id, x.city, x.county, x.address, x.lat, x.lng);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid student id");
            BaoChayBUS.Instance.Delete(id);
            return Ok();
        }
    }
}
