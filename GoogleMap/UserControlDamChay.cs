using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using MapData.DTO;

namespace GoogleMap
{
    public partial class UserControlDamChay : UserControl
    {
        public string baseAddress = "http://localhost:8177/api/";
        private int luu = 1;
        private void AnHien2(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnChonDiem.Enabled = e;
            btnChonFile.Enabled = e;
            txtCapDo.Enabled = e;
            txtThanhPho.Enabled = e;
            txtDiaChi.Enabled = e;
            txtLat.Enabled = e;
            txtLng.Enabled = e;
            txtAnh.Enabled = e;
            txtQuanHuyen.Enabled = e;
            txtThietHai.Enabled = e;
            dateNgayChay.Enabled = e;
        }
        private void loaddata()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("damchay");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    var damchays = readTask.Result;
                    dgvDamChay.DataSource = damchays;
                }
            }
        }
        public UserControlDamChay()
        {
            InitializeComponent();
            loaddata();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Open File Images";
            opd.Filter = "Image|*.png;*.jpg;*.jpeg|All file type|*.*";
            if (opd.ShowDialog() == DialogResult.OK)
            {
                txtAnh.Text = opd.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            luu = 0;
            AnHien2(true);
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            luu = 1;
            AnHien2(true);
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
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
            catch (System.Exception ex)
            {
                MessageBox.Show("vui lòng nhập mã"+ex);
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            txtAnh.Text = Convert.ToString(dgvDamChay.CurrentRow.Cells["image"].Value);
        }
        private void btnChonDiem_Click(object sender, EventArgs e)
        {
           
            frmMap map = new frmMap();
            map.damchay = this;
            map.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            AnHien2(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (luu==0)
            {
                try
                {
                    int capdo = int.Parse(txtCapDo.Text);
                    string thanhpho = txtThanhPho.Text;
                    string quanhuyen = txtQuanHuyen.Text;
                    string diachi = txtDiaChi.Text;
                    float thiethai = float.Parse(txtThietHai.Text);
                    DateTime ngay = Convert.ToDateTime(dateNgayChay.Value);
                    float latt = float.Parse(txtLat.Text);
                    float lngg = float.Parse(txtLng.Text);
                    string anh = txtAnh.Text;
                    DamChay damchay = new DamChay() { level = capdo, city = thanhpho, county = quanhuyen, address = diachi, damages = thiethai, date = ngay, lat = latt, lng = lngg, image = anh };

                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(baseAddress);
                        var postTask = client.PostAsJsonAsync<DamChay>("damchay", damchay);
                        postTask.Wait();

                        var result = postTask.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Thêm thành công");
                            AnHien2(false);
                            loaddata();
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("thêm không thành công"+ex);
                }
            } 
            else
            {
                try
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
                    string anh = txtAnh.Text;
                    DamChay damchay = new DamChay() { id = idd, level = capdo, city = thanhpho, county = quanhuyen, address = diachi, damages = thiethai, date = ngay, lat = latt, lng = lngg, image = anh };

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
                            AnHien2(false);
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("sửa không thành công" + ex);
                }
            }
        }

        private void UserControlDamChay_Load(object sender, EventArgs e)
        {
            AnHien2(false);
        }
    }
}
