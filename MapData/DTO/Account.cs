using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DTO
{
    public class Account
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string displayName { get; set; }

        public Account(int id ,string username, string password, string name)
        {
            this.username = username;
            this.password = password;
            this.displayName = name;
        }

        public Account(DataRow row)
        {
            this.id = int.Parse(row["id"].ToString());

            this.username = row["username"].ToString();
          
            this.password = row["password"].ToString();

            this.displayName = row["displayName"].ToString();
        }
        public Account() { }


    }
}
