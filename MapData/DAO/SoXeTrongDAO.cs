using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DAO
{
    public class SoXeTrongDAO
    {
        private SoXeTrongDAO() { }

        private static volatile SoXeTrongDAO instance;

        static object key = new object();

        public static SoXeTrongDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new SoXeTrongDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public List<SoXeTrong> GetData(string id)
        {
            List<SoXeTrong> list = new List<SoXeTrong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT id,name,capacity,maxHeight,size,status FROM dbo.XeCuuHoa WHERE idTramCuuHoa = '" + id + "'AND status='free'");
            foreach (DataRow item in data.Rows)
            {
                SoXeTrong obj = new SoXeTrong(item);
                list.Add(obj);
            }
            return list;
        }
        public int SuaTrangThaiXe(int id)
        {
            string query = $"UPDATE dbo.XeCuuHoa SET status='busy' WHERE id ={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        //}
        //public DataTable GetData(string id)
        //{
        //    DataTable dt = DataProvider.Instance.GetData("SELECT id,name,capacity,maxHeight,size,status FROM dbo.XeCuuHoa WHERE idTramCuuHoa = '"+id+"'");
        //    return dt;
        //}
    }
}
