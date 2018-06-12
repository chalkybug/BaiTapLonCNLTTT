using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DAO
{
    class TramCuuHoaDAO
    {
        private TramCuuHoaDAO() { }

        private static volatile TramCuuHoaDAO instance;

        static object key = new object();

        public static TramCuuHoaDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new TramCuuHoaDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<TramCuuHoa> GetList()
        {
            List<TramCuuHoa> list = new List<TramCuuHoa>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TramCuuHoa");
            foreach (DataRow item in data.Rows)
            {
                TramCuuHoa obj = new TramCuuHoa(item);
                list.Add(obj);
            }
            return list;
        }


        public DataTable ShowTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TramCuuHoa");

            return data;
        }

        public int Create(string name, string phone, string address, float lat, float lng)
        {
            string query = $"INSERT dbo.TramCuuHoa VALUES  (N'{name}', '{phone}', N'{address}', {lat}, {lng})";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Update(int id, string name, string phone, string address, float lat, float lng)
        {
            string query = $"UPDATE dbo.TramCuuHoa	SET name=N'{name}',phone='{phone}',address=N'{address}',lat={lat},lng={lng} WHERE id={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Delete(int id)
        {
            // xóa toàn bộ xe của trạm
            string query1 = $"DELETE dbo.XeCuuHoa WHERE idTramCuuHoa ={id}";

            DataProvider.Instance.ExecuteNonQuery(query1);
            //xóa trạm
            string query = $"DELETE dbo.TramCuuHoa WHERE id ={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}
