using MapData.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DAO
{
    class AccountDAO
    {
        private AccountDAO() { }

        private static volatile AccountDAO instance;

        static object key = new object();

        public static AccountDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
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
            List<Account> list = new List<Account>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account");
            foreach (DataRow item in data.Rows)
            {
                Account obj = new Account(item);
                list.Add(obj);
            }
            return list;
        }

    }
}
