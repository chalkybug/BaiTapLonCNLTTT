using MapData.DAO;
using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.BUS
{
  public  class BaoChayBUS
    {
        private BaoChayBUS() { }

        private static volatile BaoChayBUS instance;

        static object key = new object();

        public static BaoChayBUS Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new BaoChayBUS();
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
            return BaoChayDAO.Instance.GetList();
        }


        public DataTable ShowTable()
        {
            return BaoChayDAO.Instance.ShowTable();
        }

        public int Create(string city, string county, string address, float lat, float lng, string image)
        {
            return BaoChayDAO.Instance.Create( city, county, address, lat, lng,image);
        }
        public int Update(int id, string city, string county, string address, float lat, float lng, string image)
        {
            return BaoChayDAO.Instance.Update(id, city, county, address, lat, lng,image);
        }
        public int Delete(int id)
        {
            return BaoChayDAO.Instance.Delete(id);
        }
    }
}
