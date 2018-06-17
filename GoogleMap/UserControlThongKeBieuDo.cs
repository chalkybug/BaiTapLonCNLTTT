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
using MapData.DTO;

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
            string ngay1 = date1.Text;
            string ngay2 = date2.Text;
            string khuvuc = cmbKhuVuc.Text;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("thongke?date1=" + ngay1 + "&date2=" + ngay2 + "&khuvuc=" + khuvuc);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    var thiethais = readTask.Result;
                    chartThongKeThietHai.DataSource = thiethais;
                    chartThongKeThietHai.ChartAreas["ChartArea1"].AxisX.Title = "địa chỉ";
                    chartThongKeThietHai.Series["Series1"].XValueMember = "address";
                    chartThongKeThietHai.Series["Series1"].YValueMembers = "damages";
                }
            }
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
