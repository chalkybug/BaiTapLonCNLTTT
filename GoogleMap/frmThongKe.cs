using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapData.BUS;
using MapData.DAO;
namespace GoogleMap
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKeTatCaKhu_Click(object sender, EventArgs e)
        {

            DataTable dt = ThongKeBUS.Instance.ThongKeTatCaKhu(date1.Text, date2.Text);
            dgvThietHai.DataSource = dt;
        }

        private void btnThongKeTungKhu_Click(object sender, EventArgs e)
        {
            DataTable dt = ThongKeBUS.Instance.ThongKe(date1.Text, date2.Text, cmbKhuVuc.Text);
            dgvThietHai.DataSource = dt;
        }

        private void dgvThietHai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            cmbKhuVuc.DataSource = ThongKeBUS.Instance.GetData();
            cmbKhuVuc.DisplayMember = "county";

        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCaoThietHai bcth = new frmBaoCaoThietHai();
            bcth.tk = this;
            bcth.ShowDialog();
        }
    }
}
