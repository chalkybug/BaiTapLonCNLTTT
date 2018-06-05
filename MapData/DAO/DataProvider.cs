using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapData.DAO
{
    class DataProvider
    {
        private static volatile DataProvider instance;
        private DataProvider() { }
        private string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlPCCC;Integrated Security=True";
        static object key = new object();
        public static DataProvider Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new DataProvider();
                    }
                }
                return instance;
            }

        }
        public DataTable GetData(string strSql)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                SqlDataAdapter da = new SqlDataAdapter(strSql, connection);
                DataTable dt = new DataTable();
                if (ConnectionState.Closed == connection.State)
                {
                    connection.Open();
                }
                da.Fill(dt);
                connection.Close();
                return dt;
            }
        }
        public DataTable GetData(string NameProc, SqlParameter[] para)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                SqlCommand cmd = new SqlCommand(NameProc, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                if (ConnectionState.Closed == connection.State)
                {
                    connection.Open();
                }
                da.Fill(dt);
                connection.Close();
                return dt;
            }
                
        }
        // viết lại cái query xử lý thông qua provider
        public DataTable ExecuteQuery(string query, Object[] parameter = null)
        {

            DataTable data = new DataTable("data");
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                // xử lý nâng cao parameter là sử lý chuỗi thêm vào

                if (parameter != null)// nghĩa là có tham số truyền vào
                {
                    string[] listPara = query.Split(' ');
                    int n = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[n]);
                            n++;
                        }
                    }
                }

                // trung gian qua một cái sqldataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();


            }

            return data;
        }

        public int ExecuteNonQuery(string query, Object[] parameter = null)// số dòng thành công
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                // xử lý nâng cao parameter là sử lý chuỗi thêm vào

                if (parameter != null)// nghĩa là có tham số truyền vào
                {
                    string[] listPara = query.Split(' ');
                    int n = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains("@"))
                        {

                            command.Parameters.AddWithValue(item, parameter[n]);
                            n++;

                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();


            }

            return data;
        }

        public object ExecuteScalar(string query, Object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                // xử lý nâng cao parameter là sử lý chuỗi thêm vào

                if (parameter != null)// nghĩa là có tham số truyền vào
                {
                    string[] listPara = query.Split(' ');
                    int n = 0;
                    foreach (var item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[n]);
                            n++;
                        }
                    }
                }

                // trung gian qua một cái sqldataAdapter
                data = command.ExecuteScalar();
                connection.Close();


            }

            return data;
        }
    }
}
