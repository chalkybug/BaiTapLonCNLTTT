using MapData.DAO;
using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.BUS
{
  public  class AccountBUS
    {
        private AccountBUS() { }

        private static volatile AccountBUS instance;

        static object key = new object();

        public static AccountBUS Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new AccountBUS();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<Account> GetList()
        {
            return AccountDAO.Instance.GetList();
        }
    }
}
