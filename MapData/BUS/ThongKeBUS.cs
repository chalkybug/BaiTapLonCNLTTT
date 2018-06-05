using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapData.DAO;
namespace MapData.BUS
{
    public class ThongKeBUS
    {
        public ThongKeBUS() { }
        private static volatile ThongKeBUS instance;

        static object key = new object();

        public static ThongKeBUS Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new ThongKeBUS();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public DataTable ThongKe(string date1, string date2, string khuvuc)
        {
            return ThongKeDAO.Instance.ThongKe(date1, date2, khuvuc);
        }
        public DataTable ThongKeTatCaKhu(string date1, string date2)
        {
            return ThongKeDAO.Instance.ThongKeTatCaKhu(date1, date2);
        }
        public DataTable GetData()
        {
            return ThongKeDAO.Instance.GetData();
        }
    }
}
