using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http;
namespace GoogleMap
{
    public partial class UserControlThongKeBieuDo : UserControl
    {
        public string baseAddress = "http://localhost:8177/api/";
        public UserControlThongKeBieuDo()
        {
            InitializeComponent();
        }

        private void btnThongKeThietHai_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=qlPCCC;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select address,damages from DamChay where date between '" + date1.Text + "' and '" + date2.Text + "' and county=N'" + cmbKhuVuc.Text + "' ", db);
            DataTable dt = new DataTable();
            da.Fill(dt);
            chartThongKeThietHai.DataSource = dt;
            chartThongKeThietHai.ChartAreas["ChartArea1"].AxisX.Title = "địa chỉ";
            chartThongKeThietHai.Series["Series1"].XValueMember = "address";
            chartThongKeThietHai.Series["Series1"].YValueMembers = "damages";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlThongKeBieuDo_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("thongke");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    var thongkes = readTask.Result;
                    cmbKhuVuc.DataSource = thongkes;
                    cmbKhuVuc.DisplayMember = "county";
                }
            }
        }
    }
}
