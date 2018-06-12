using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DTO
{
    public class ThongKe
    {
        public string address { get; set; }
        public int count { get; set; }
        public float damages { get; set; }

        public ThongKe(string address, int count, float damages)
        {
            this.address = address;
            this.count = count;
            this.damages = damages;
        }

        public ThongKe(DataRow row)
        {
            this.address = row["diachi"].ToString();
            this.damages = float.Parse(row["thiethai"].ToString());
            this.count = int.Parse(row["sovuchay"].ToString());
          
        }
        public ThongKe() { }
    }
}
