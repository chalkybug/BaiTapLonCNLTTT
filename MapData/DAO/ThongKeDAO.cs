using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MapData.DTO;

namespace MapData.DAO
{
    public class ThongKeDAO
    {
        private ThongKeDAO() { }

        private static volatile ThongKeDAO instance;

        static object key = new object();

        public static ThongKeDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new ThongKeDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public List<ThongKe> ThongKeTungKhu(string date1, string date2,string khuvuc)
        {
            List<ThongKe> list = new List<ThongKe>();

            DataTable data = DataProvider.Instance.ExecuteQuery($"EXECUTE dbo.ThongKeTungKhu @date1 = '{date1}',  @date2 = '{date2}',  @khuvuc = N'{khuvuc}'");
            foreach (DataRow item in data.Rows)
            {
                ThongKe obj = new ThongKe(item);
                
                list.Add(obj);
            }
            return list;
        }

        public List<ThongKe> ThongKeTatCaKhu(string date1, string date2)
        {
            List<ThongKe> list = new List<ThongKe>();

            DataTable data = DataProvider.Instance.ExecuteQuery($"EXECUTE dbo.ThongKeTatCaKhu @date1 = '{date1}',  @date2 = '{date2}' ");
            foreach (DataRow item in data.Rows)
            {
                ThongKe obj = new ThongKe(item);
                list.Add(obj);
            }
            return list;
        }
       
    }
}
