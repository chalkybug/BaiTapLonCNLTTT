using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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

        public DataTable ThongKe(string date1, string date2,string khuvuc)
        {
            SqlParameter[] para =
            {
               new SqlParameter("date1",date1),
                new SqlParameter("date2",date2),
                new SqlParameter("khuvuc",khuvuc)
        };
            DataTable dt = DataProvider.Instance.GetData("ThongKeTungKhu", para);
            return dt;
        }
        public DataTable ThongKeTatCaKhu(string date1, string date2)
        {
            SqlParameter[] para =
            {
               new SqlParameter("date1",date1),
                new SqlParameter("date2",date2)
        };
            DataTable dt = DataProvider.Instance.GetData("ThongKeTatCaKhu", para);
            return dt;
        }
        public DataTable GetData()
        {
            DataTable dt = DataProvider.Instance.GetData("select county from damchay group by county");
            return dt;
        }
    }
}
