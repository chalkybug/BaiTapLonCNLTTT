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
using System.Net.Http;
using MapData.DTO;

namespace GoogleMap
{
    public partial class frmDamChay : Form
    {
        public frmDamChay()
        {
            InitializeComponent();
            loaddata();
        }
        private void loaddata()
        {
            DataTable dt = new DataTable();
            dt = DamChayBUS.Instance.ShowTable();
            dgvDamChay.DataSource = dt;
        }
        public string baseAddress = "http://localhost:8177/api/";
        private void btnThem_Click(object sender, EventArgs e)
        {
            int capdo = int.Parse(txtCapDo.Text);
            string thanhpho = txtThanhPho.Text;
            string quanhuyen = txtQuanHuyen.Text;
            string diachi = txtDiaChi.Text;
            float thiethai =float.Parse(txtThietHai.Text);
            DateTime ngay = Convert.ToDateTime(dateNgayChay.Value) ;
            float latt = float.Parse(txtLat.Text);
            float lngg = float.Parse(txtLng.Text);
            DamChay damchay = new DamChay() { level = capdo, city = thanhpho, county = quanhuyen, address = diachi, damages = thiethai,date=ngay,lat=latt,lng=lngg };

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                var postTask = client.PostAsJsonAsync<DamChay>("damchay", damchay);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm thành công");
                    loaddata();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int idd = int.Parse(txtID.Text);
            int capdo = int.Parse(txtCapDo.Text);
            string thanhpho = txtThanhPho.Text;
            string quanhuyen = txtQuanHuyen.Text;
            string diachi = txtDiaChi.Text;
            float thiethai = float.Parse(txtThietHai.Text);
            DateTime ngay = Convert.ToDateTime(dateNgayChay.Text);
            float latt = float.Parse(txtLat.Text);
            float lngg = float.Parse(txtLng.Text);
            DamChay damchay = new DamChay() {id=idd, level = capdo, city = thanhpho, county = quanhuyen, address = diachi, damages = thiethai, date = ngay, lat = latt, lng = lngg };

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                var postTask = client.PutAsJsonAsync<DamChay>("damchay", damchay);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sửa thành công");
                    loaddata();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                var deleteTask = client.DeleteAsync("damchay/" + id.ToString());
                deleteTask.Wait();
                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("xóa thành công");
                    loaddata();
                }
            }
        }

        private void dgvDamChay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dgvDamChay.CurrentRow.Cells["id"].Value);
            txtThanhPho.Text = Convert.ToString(dgvDamChay.CurrentRow.Cells["city"].Value);
            txtQuanHuyen.Text = Convert.ToString(dgvDamChay.CurrentRow.Cells["county"].Value);
            txtDiaChi.Text = Convert.ToString(dgvDamChay.CurrentRow.Cells["address"].Value);
            txtCapDo.Text = Convert.ToString(dgvDamChay.CurrentRow.Cells["level"].Value);
            txtThietHai.Text = Convert.ToString(dgvDamChay.CurrentRow.Cells["damages"].Value);
            dateNgayChay.Text = Convert.ToString(dgvDamChay.CurrentRow.Cells["date"].Value);
            txtLat.Text = Convert.ToString(dgvDamChay.CurrentRow.Cells["lat"].Value);
            txtLng.Text = Convert.ToString(dgvDamChay.CurrentRow.Cells["lng"].Value);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
