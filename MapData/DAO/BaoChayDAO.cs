using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DAO
{
    class BaoChayDAO
    {
        private BaoChayDAO() { }

        private static volatile BaoChayDAO instance;

        static object key = new object();

        public static BaoChayDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new BaoChayDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<BaoChay> GetList()
        {
            List<BaoChay> list = new List<BaoChay>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BaoChay");
            foreach (DataRow item in data.Rows)
            {
                BaoChay obj = new BaoChay(item);
                list.Add(obj);
            }
            return list;
        }


        public DataTable ShowTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BaoChay");

            return data;
        }

        public int Create(string city, string county, string address, float lat, float lng)
        {
            string query = $"INSERT dbo.BaoChay VALUES  ( N'{city}', N'{county}', N'{address}', {lat}, {lng} )";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Update(int id, string city, string county, string address, float lat, float lng)
        {
            string query = $"UPDATE dbo.BaoChay SET ,city=N'{city}',county=N'{county}',address=N'{address}',lat={lat},lng={lng} WHERE id={id}";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }
        public int Delete(int id)
        {
            string query = $"DELETE dbo.BaoChay WHERE id ={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}
