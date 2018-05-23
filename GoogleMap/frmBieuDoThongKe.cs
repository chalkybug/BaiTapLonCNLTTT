using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMap
{
    public partial class frmBieuDoThongKe : Form
    {
        public frmBieuDoThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKeThietHai_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=qlPCCC;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select address,damages from DamChay where date between '" + date1.Text + "' and '" + date2.Text + "' and county=N'"+cmbKhuVuc.Text+"' ", db);
            DataTable dt = new DataTable();
            da.Fill(dt);
            chartThongKeThietHai.DataSource = dt;
            chartThongKeThietHai.ChartAreas["ChartArea1"].AxisX.Title = "địa chỉ";
            chartThongKeThietHai.Series["Series1"].XValueMember = "address";
            chartThongKeThietHai.Series["Series1"].YValueMembers = "damages";
        }
    }
}
