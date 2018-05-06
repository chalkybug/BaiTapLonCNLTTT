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
    public class TruNuocBUS
    {
        private TruNuocBUS() { }

        private static volatile TruNuocBUS instance;

        static object key = new object();

        public static TruNuocBUS Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new TruNuocBUS();
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

            return TruNuocDAO.Instance.GetList();
        }


        public DataTable ShowTable()
        {

            return TruNuocDAO.Instance.ShowTable();
        }

        public int Create(string city, string county, string address, float lat, float lng)
        {
            return TruNuocDAO.Instance.Create(city, county, address, lat, lng);
        }
        public int Update(int id, string city, string county, string address, float lat, float lng)
        {
            return TruNuocDAO.Instance.Update(id, city, county, address, lat, lng); ;
        }
        public int Delete(int id)
        {

            return TruNuocDAO.Instance.Delete(id);
        }
    }
}
