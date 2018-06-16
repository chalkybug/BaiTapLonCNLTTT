using MapData.BUS;
using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MapApi.Controllers
{
    public class TramCuuHoaController : ApiController
    {

     
        public IHttpActionResult Get()
        {
            List<TramCuuHoa> item = TramCuuHoaBUS.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        
        public IHttpActionResult Post([FromBody] TramCuuHoa x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            TramCuuHoaBUS.Instance.Create(x.name, x.phone, x.address, x.lat, x.lng);
            return Ok();
        }

      
        public IHttpActionResult Put([FromBody] TramCuuHoa x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            TramCuuHoaBUS.Instance.Update(x.id,x.name, x.phone, x.address, x.lat, x.lng);
            return Ok();
        }

 
        public IHttpActionResult Delete([FromUri] int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            TramCuuHoaBUS.Instance.Delete(id);
            return Ok();

        }
    }
}
