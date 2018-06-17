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
    public class XeCuuHoaController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<XeCuuHoa> item = XeCuuHoaBUS.Instance.GetList();
            return Ok(item);
        }
        [HttpPut]
        public IHttpActionResult Post([FromBody] XeCuuHoa x)
        {
            XeCuuHoaBUS.Instance.Create(x.name, x.idTramCuuHoa, x.capacity, x.maxHeight, x.size, x.status);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] XeCuuHoa x)
        {
            XeCuuHoaBUS.Instance.Update(x.id, x.name, x.idTramCuuHoa, x.capacity, x.maxHeight, x.size, x.status);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] int id)
        {
            XeCuuHoaBUS.Instance.Delete(id);
            return Ok();
        }
    }
}
