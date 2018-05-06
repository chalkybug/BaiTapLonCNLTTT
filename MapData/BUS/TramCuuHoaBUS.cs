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
   public class TramCuuHoaBUS
    {
        private TramCuuHoaBUS() { }

        private static volatile TramCuuHoaBUS instance;

        static object key = new object();

        public static TramCuuHoaBUS Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new TramCuuHoaBUS();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<TramCuuHoa> GetList()
        {
           
            return TramCuuHoaDAO.Instance.GetList();
        }


        public DataTable ShowTable()
        {
            return TramCuuHoaDAO.Instance.ShowTable();
        }

        public int Create(string name, string phone, string address, float lat, float lng)
        {
            
            return TramCuuHoaDAO.Instance.Create(name, phone, address, lat, lng);
        }
        public int Update(int id, string name, string phone, string address, float lat, float lng)
        {
        
            return TramCuuHoaDAO.Instance.Update(id,name, phone, address, lat, lng);
        }
        public int Delete(int id)
        {
            return TramCuuHoaDAO.Instance.Delete(id);
        }
    }
}
