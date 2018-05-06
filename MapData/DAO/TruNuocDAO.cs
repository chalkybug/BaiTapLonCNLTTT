using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DAO
{
   public class TruNuocDAO
    {
        private TruNuocDAO() { }

        private static volatile TruNuocDAO instance;

        static object key = new object();

        public static TruNuocDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new TruNuocDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<TruNuoc> GetList()
        {
            List<TruNuoc> list = new List<TruNuoc>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TruNuoc");
            foreach (DataRow item in data.Rows)
            {
                TruNuoc obj = new TruNuoc(item);
                list.Add(obj);
            }
            return list;
        }


        public DataTable ShowTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TruNuoc");

            return data;
        }

        public int Create( string city, string county, string address, float lat, float lng)
        {
            string query = $"insert dbo.TruNuoc values (N'{city}', N'{county}', N'{address}', {lat}, {lng});";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Update(int id, string city, string county, string address, float lat, float lng)
        {
            string query = $"UPDATE dbo.TruNuoc SET city=N'{city}',county=N'{county}',address=N'{address}',lat={lat},lng={lng}  WHERE id ={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Delete(int id)
        {
            string query = $"DELETE dbo.TruNuoc WHERE id ={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}
