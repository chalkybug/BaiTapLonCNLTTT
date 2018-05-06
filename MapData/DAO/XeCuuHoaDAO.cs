using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DAO
{
   public class XeCuuHoaDAO
    {
        private XeCuuHoaDAO() { }

        private static volatile XeCuuHoaDAO instance;

        static object key = new object();

        public static XeCuuHoaDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new XeCuuHoaDAO();
                    }
                }
              
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

      
        public List<XeCuuHoa> GetList()
        {
            List<XeCuuHoa> list = new List<XeCuuHoa>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.XeCuuHoa");
            foreach (DataRow item in data.Rows)
            {
                XeCuuHoa obj = new XeCuuHoa(item);
                list.Add(obj);
            }
            return list;
        }


        public DataTable ShowTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.XeCuuHoa");

            return data;
        }

        public int Create(string name, int idTramCuuHoa, float capacity, float maxHeight, string size, string status)
        {
            string query = $"insert dbo.XeCuuHoa values (N'{name}', {idTramCuuHoa} ,{capacity}, {maxHeight}, '{size}', '{status}');";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Update(int id, string name, int idTramCuuHoa, float capacity, float maxHeight, string size, string status)
        {
           string query = $"UPDATE dbo.XeCuuHoa SET	name=N'{name}',idTramCuuHoa={idTramCuuHoa},capacity={capacity},maxHeight={maxHeight},size='{size}',status='{status}'  WHERE id ={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Delete(int id)
        {
            string query = $"DELETE dbo.XeCuuHoa WHERE id ={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }


    }

}
