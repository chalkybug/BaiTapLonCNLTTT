using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapData.DAO;
using MapData.DTO;

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

        public List<ThongKe> ThongKeTungKhu(string date1, string date2, string khuvuc)
        {
            return ThongKeDAO.Instance.ThongKeTungKhu(date1, date2, khuvuc);
        }
        public List<ThongKe> ThongKeTatCaKhu(string date1, string date2)
        {
            return ThongKeDAO.Instance.ThongKeTatCaKhu(date1, date2);
        }
       
    }
}
