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
    public class TramCuuHoaController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<TramCuuHoa> item = TramCuuHoaBUS.Instance.GetList();
            return Ok(item);
        }


        public IHttpActionResult Post([FromBody] TramCuuHoa x)
        {
            TramCuuHoaBUS.Instance.Create(x.name, x.phone, x.address, x.lat, x.lng);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] TramCuuHoa x)
        {
            TramCuuHoaBUS.Instance.Update(x.id,x.name, x.phone, x.address, x.lat, x.lng);
            return Ok();
        }
   
        public IHttpActionResult Delete([FromUri] int id)
        {
            TramCuuHoaBUS.Instance.Delete(id);
            return Ok();
        }
    }
}
