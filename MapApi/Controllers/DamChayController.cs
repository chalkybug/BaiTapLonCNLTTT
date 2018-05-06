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
            return Ok(item);
        }


        public IHttpActionResult Post([FromBody] DamChay x)
        {
            DamChayBUS.Instance.Create(x.level, x.city, x.county, x.address, x.damages, x.date, x.lat, x.lng);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] DamChay x)
        {
            DamChayBUS.Instance.Update(x.id,x.level, x.city, x.county, x.address, x.damages, x.date, x.lat, x.lng);
            return Ok();
        }
       
        public IHttpActionResult Delete([FromUri] int id)
        {
            DamChayBUS.Instance.Delete(id);
            return Ok();
        }
    }
}
