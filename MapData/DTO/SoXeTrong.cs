using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DTO
{
    public class SoXeTrong
    {
        public int id { get; set; }
        public string name { get; set; }
        public float capacity { get; set; }
        public float maxHeight { get; set; }
        public string size { get; set; }
        public string status { get; set; }


        public SoXeTrong(int id, string name, float capacity, float maxHeight, string size, string status)
        {
            this.id = id;
            this.name = name;
            this.capacity = capacity;
            this.maxHeight = maxHeight;
            this.size = size;
            this.status = status;
        }
        public SoXeTrong(DataRow row)
        {
            this.id = int.Parse(row["id"].ToString());
            this.name = row["name"].ToString();
            this.capacity = float.Parse(row["capacity"].ToString());
            this.maxHeight = float.Parse(row["maxHeight"].ToString());
            this.size = row["size"].ToString();
            this.status = row["status"].ToString();
        }
        public SoXeTrong() { }
    }
}
