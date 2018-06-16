using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MapData.BUS;
using System.Data;
using MapData.DTO;

namespace MapApi.Controllers
{
    public class SoXeTrongController : ApiController
    {
        // SoXeTrongBUS tkbus = new SoXeTrongBUS();
        [HttpGet]
        public IHttpActionResult Get(string id)
        {
            //DataTable dt = new DataTable();
            //dt = tkbus.GetData(id);
            //return Ok(dt);
            List<SoXeTrong> item = SoXeTrongBUS.Instance.GetData(id);
            return Ok(item);
        }
        [HttpPut]
        public IHttpActionResult SuaTrangThaiXe([FromBody] SoXeTrong x)
        {
            SoXeTrongBUS.Instance.SuaTrangThaiXe(x.id);
            return Ok();
        }

    }
}
