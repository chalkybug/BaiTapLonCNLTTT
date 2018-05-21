using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DTO
{
    public class BaoChay
    {
        public int id { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string address { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
        public string image { get; set; }

        public BaoChay(int id, string city, string county, string address, float lat, float lng,string image)
        {
            this.id = id;

            this.city = city;
            this.county = county;
            this.address = address;
            this.lat = lat;
            this.lng = lng;
            this.image = image; 
        }
        public BaoChay(DataRow row)
        {
            this.id = int.Parse(row["id"].ToString());
            this.city = row["city"].ToString();
            this.county = row["county"].ToString();
            this.address = row["address"].ToString();
            this.lat = float.Parse(row["lat"].ToString());
            this.lng = float.Parse(row["lng"].ToString());
            this.image = row["image"].ToString();
        }
        public BaoChay() { }
    }
}
