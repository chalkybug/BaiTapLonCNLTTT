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

        public BaoChay(int id, string city, string county, string address, float lat, float lng)
        {
            this.id = id;

            this.city = city;
            this.county = county;
            this.address = address;
            this.lat = lat;
            this.lng = lng;
        }
        public BaoChay(DataRow row)
        {
            this.id = int.Parse(row["id"].ToString());
            this.city = row["city"].ToString();
            this.county = row["county"].ToString();
            this.address = row["address"].ToString();
            this.lat = float.Parse(row["lat"].ToString());
            this.lng = float.Parse(row["lng"].ToString());
        }
        public BaoChay() { }
    }
}
