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
    public class XeCuuHoaBUS
    {
        private XeCuuHoaBUS() { }

        private static volatile XeCuuHoaBUS instance;

        static object key = new object();

        public static XeCuuHoaBUS Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new XeCuuHoaBUS();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<XeCuuHoa> GetList()
        {
           
            return XeCuuHoaDAO.Instance.GetList();
        }


        public DataTable ShowTable()
        {
            return XeCuuHoaDAO.Instance.ShowTable();
        }

        public int Create(string name, int idTramCuuHoa, float capacity, float maxHeight, string size, string status)
        {
            return XeCuuHoaDAO.Instance.Create(name, idTramCuuHoa, capacity, maxHeight, size, status);
        }
        public int Update(int id, string name, int idTramCuuHoa, float capacity, float maxHeight, string size, string status)
        {
            return XeCuuHoaDAO.Instance.Update(id,name, idTramCuuHoa, capacity, maxHeight, size, status);
        }
        public int Delete(int id)
        {
            return XeCuuHoaDAO.Instance.Delete(id);
        }

    }
}
