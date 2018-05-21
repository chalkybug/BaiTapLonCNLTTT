
using MapApi.Models;
using MapData.BUS;
using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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
            
           
            string folderImage = "folderImage";
            string path = AppDomain.CurrentDomain.BaseDirectory.ToString() + folderImage; // folder name
            string name = ConvertBase64ToImage.ConvertAndSaveImage(x.image, path);
            // save image path {x.image= name}
            BaoChayBUS.Instance.Create(x.city, x.county, x.address, x.lat, x.lng, name);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] BaoChay x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            BaoChayBUS.Instance.Update(x.id, x.city, x.county, x.address, x.lat, x.lng, x.image);
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
