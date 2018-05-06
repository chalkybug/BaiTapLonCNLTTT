using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DTO
{
   public class TramCuuHoa
    {
        //       id INT  IDENTITY PRIMARY KEY,
        //name NVARCHAR(100) NOT NULL,
        //   phone VARCHAR(11) NOT NULL,
        //   address NVARCHAR(100) NOT NULL,
        //   lat FLOAT NOT NULL,
        //lng FLOAT NOT NULL,
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }


        public TramCuuHoa(int id, string name, string phone, string address, float lat, float lng)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.lat = lat;
            this.lng = lng;
        }
        public TramCuuHoa(DataRow row)
        {
            this.id = int.Parse(row["id"].ToString());
            this.name = row["name"].ToString();
            this.phone = row["phone"].ToString();
            this.address = row["address"].ToString();
            this.lat = float.Parse(row["lat"].ToString());
            this.lng = float.Parse(row["lng"].ToString());
        }


    }
}
