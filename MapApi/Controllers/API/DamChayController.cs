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
    public class DamChayController : ApiController
    {

        public IHttpActionResult Get()
        {
            List<DamChay> item = DamChayBUS.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }
        
        public IHttpActionResult Post([FromBody] DamChay x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            DamChayBUS.Instance.Create(x.level, x.city, x.county, x.address, x.damages, x.date, x.lat, x.lng, x.image);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] DamChay x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            DamChayBUS.Instance.Update(x.id, x.level, x.city, x.county, x.address, x.damages, x.date, x.lat, x.lng, x.image);
            return Ok();
        }
       
        public IHttpActionResult Delete([FromUri] int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            DamChayBUS.Instance.Delete(id);
            return Ok();
        }
    }
}
