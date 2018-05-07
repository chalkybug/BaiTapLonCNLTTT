using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GoogleMapWeb.Models
{
    public class XeCuuHoa
    {
        //       id INT IDENTITY PRIMARY KEY,
        //name NVARCHAR(100) NOT NULL,
        //   idTramCuuHoa INT REFERENCES dbo.TramCuuHoa(id), -- thuộc trạm cứu hỏa nào
        //   capacity FLOAT NOT NULL, -- dung tích chứa được bao nhiêu lít
        //   maxHeight FLOAT NOT NULL , -- chiều cao tối đa xe có thể phun nước tới

        //   size VARCHAR(10) NOT NULL, -- kích thức s,m,l
        //   status VARCHAR(10) DEFAULT 'free' -- free and busy
        public int id { get; set; }
        public string name { get; set; }
        public int idTramCuuHoa { get; set; }
        public float capacity { get; set; }
        public float maxHeight { get; set; }
        public string size { get; set; }
        public string status { get; set; }

        public XeCuuHoa(int id, string name, int idTramCuuHoa, float capacity, float maxHeight, string size, string status)
        {
            this.id = id;
            this.name = name;
            this.idTramCuuHoa = idTramCuuHoa;
            this.capacity = capacity;
            this.maxHeight = maxHeight;
            this.size = size;
            this.status = status;
        }

        public XeCuuHoa(DataRow row)
        {
            this.id = int.Parse(row["id"].ToString());
            this.name = row["name"].ToString();
            this.idTramCuuHoa = int.Parse(row["idTramCuuHoa"].ToString());
            this.capacity = float.Parse(row["capacity"].ToString());
            this.maxHeight = float.Parse(row["maxHeight"].ToString());
            this.size = row["size"].ToString();
            this.status = row["status"].ToString();
        }

        public XeCuuHoa() { } // cần thêm để tránh giá trị null
    }
}