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
    public class SoXeTrongBUS
    {
        public SoXeTrongBUS() { }
        private static volatile SoXeTrongBUS instance;

        static object key = new object();

        public static SoXeTrongBUS Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new SoXeTrongBUS();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }
        public List<SoXeTrong> GetData(string id)
        {
            return SoXeTrongDAO.Instance.GetData(id);
        }
        public int SuaTrangThaiXe(int id)
        {
            return SoXeTrongDAO.Instance.SuaTrangThaiXe(id);
        }

    }
}
