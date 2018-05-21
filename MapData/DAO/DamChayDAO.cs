using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DAO
{
    class DamChayDAO
    {
        private DamChayDAO() { }

        private static volatile DamChayDAO instance;

        static object key = new object();

        public static DamChayDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new DamChayDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<DamChay> GetList()
        {
            List<DamChay> list = new List<DamChay>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.DamChay");
            foreach (DataRow item in data.Rows)
            {
                DamChay obj = new DamChay(item);
                list.Add(obj);
            }
            return list;
        }


        public DataTable ShowTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.DamChay");

            return data;
        }

        public int Create(int level, string city, string county, string address, float damages, DateTime date, float lat, float lng, string image)
        {
            string query = $"INSERT dbo.DamChay VALUES  ({level} , N'{city}', N'{county}', N'{address}', {damages}, '{date}', {lat}, {lng},'{image}' )";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Update(int id, int level, string city, string county, string address, float damages, DateTime date, float lat, float lng, string image)
        {
            string query = $"UPDATE dbo.DamChay SET level={level},city=N'{city}',county=N'{county}',address=N'{address}',damages={damages},date='{date}',lat={lat},lng={lng},image='{image}' WHERE id={id}";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }
        public int Delete(int id)
        {
            string query = $"DELETE dbo.DamChay WHERE id ={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}
