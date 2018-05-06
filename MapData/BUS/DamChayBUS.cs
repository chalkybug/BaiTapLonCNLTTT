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
   public class DamChayBUS
    {
        private DamChayBUS() { }

        private static volatile DamChayBUS instance;

        static object key = new object();

        public static DamChayBUS Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new DamChayBUS();
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
            return DamChayDAO.Instance.GetList();
        }


        public DataTable ShowTable()
        {
            return DamChayDAO.Instance.ShowTable();
        }

        public int Create(int level, string city, string county, string address, float damages, DateTime date, float lat, float lng)
        {
            return DamChayDAO.Instance.Create(level, city, county, address, damages, date, lat, lng);
        }
        public int Update(int id, int level, string city, string county, string address, float damages, DateTime date, float lat, float lng)
        {
            return DamChayDAO.Instance.Update(id, level, city, county, address, damages, date, lat, lng);
        }
        public int Delete(int id)
        {
            return DamChayDAO.Instance.Delete(id);
        }
    }
}
