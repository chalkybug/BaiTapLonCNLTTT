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
        [HttpGet]
        public IHttpActionResult Get()
        {
            List<XeCuuHoa> item = XeCuuHoaBUS.Instance.GetList();
            return Ok(item);
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] XeCuuHoa x)
        {
            XeCuuHoaBUS.Instance.Create(x.name, x.idTramCuuHoa, x.capacity, x.maxHeight, x.size, x.status);
            return Ok();
        }

        [HttpPut]
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

        [HttpPut]
        public IHttpActionResult CallCar([FromUri] int id, string status)
        {
            if (id<0)
            {
                return BadRequest();
            }
            if (status =="free" || status=="busy")

            {
                XeCuuHoa xe = XeCuuHoaBUS.Instance.GetList().Where(x => x.id == id).FirstOrDefault();
                xe.status = status;
                XeCuuHoaBUS.Instance.Update(xe.id, xe.name, xe.idTramCuuHoa, xe.capacity, xe.maxHeight, xe.size, xe.status);
                return Ok();
            }
            return Ok("Status error");


        }

    }
}
