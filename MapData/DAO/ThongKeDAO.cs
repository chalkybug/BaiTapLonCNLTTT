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

        //public DataTable ThongKe(string date1, string date2,string khuvuc)
        //{
        //    SqlParameter[] para =
        //    {
        //       new SqlParameter("date1",date1),
        //        new SqlParameter("date2",date2),
        //        new SqlParameter("khuvuc",khuvuc)
        //};
        //    DataTable dt = DataProvider.Instance.GetData("ThongKeTungKhu", para);
        //    return dt;
        //}
        //public DataTable ThongKeTatCaKhu(string date1, string date2)
        //{
        //    SqlParameter[] para =
        //    {
        //       new SqlParameter("date1",date1),
        //        new SqlParameter("date2",date2)
        //};
        //    DataTable dt = DataProvider.Instance.GetData("ThongKeTatCaKhu", para);
        //    return dt;
        //}
        public DataTable GetData()
        {
            DataTable dt = DataProvider.Instance.GetData("select county from damchay group by county");
            return dt;
        }

        public List<ThongKe> ThongKeTungKhu(string date1, string date2, string khuvuc)
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
        //public List<ThongKe> GetKhuVuc()
        //{
        //    List<ThongKe> list = new List<ThongKe>();

        //    DataTable data = DataProvider.Instance.ExecuteQuery("select county from damchay group by county");
        //    foreach (DataRow item in data.Rows)
        //    {
        //        ThongKe obj = new ThongKe(item);
        //        list.Add(obj);
        //    }
        //    return list;
        //}
    }
}
