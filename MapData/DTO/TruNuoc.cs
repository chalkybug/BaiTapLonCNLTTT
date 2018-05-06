using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DTO
{
 public   class TruNuoc
    {
        //       id INT IDENTITY PRIMARY KEY,
        //city NVARCHAR(50) DEFAULT 'Hà Nội',
        //county NVARCHAR(50) DEFAULT 'Cầu Giấy',
        //address NVARCHAR(100) NOT NULL,
        //   lat FLOAT NOT NULL,
        //lng FLOAT NOT NULL,

        public int id { get; set; }
        public string city { get; set; }
        public string county { get; set; }
        public string address { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }


        public TruNuoc(int id, string city, string county, string address, float lat, float lng)
        {
            this.id = id;
            this.city = city;
            this.county = county;
            this.address = address;
            this.lat = lat;
            this.lng = lng;
        }

        public TruNuoc(DataRow row)
        {
            this.id = int.Parse(row["id"].ToString());
            this.city = row["city"].ToString();
            this.county = row["county"].ToString();
            this.address = row["address"].ToString();
            this.lat = float.Parse(row["lat"].ToString());
            this.lng = float.Parse(row["lng"].ToString());
        }
        public TruNuoc() { }
    }

}
