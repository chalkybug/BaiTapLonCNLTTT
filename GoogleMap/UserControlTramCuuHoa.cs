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
    public partial class UserControlTramCuuHoa : UserControl
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
            txtTen.Enabled = e;
            txtSDT.Enabled = e;
            txtDiaChi.Enabled = e;
            txtLat.Enabled = e;
            txtLng.Enabled = e;
        }

        private void loaddata()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("tramcuuhoa");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    var students = readTask.Result;
                    dgvTramCuuHoa.DataSource = students;
                }
            }
        }
        public UserControlTramCuuHoa()
        {
            InitializeComponent();
            loaddata();
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
                    var deleteTask = client.DeleteAsync("tramcuuhoa/" + id.ToString());
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
                MessageBox.Show("vui lòng chọn mã");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvTramCuuHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["id"].Value);
            txtDiaChi.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["address"].Value);
            txtLat.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["lat"].Value);
            txtLng.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["lng"].Value);
            txtSDT.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["phone"].Value);
            txtTen.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["name"].Value);
        }
        private void btnChonDiem_Click(object sender, EventArgs e)
        {
            frmMapChonDiemTramCuuHoa map = new frmMapChonDiemTramCuuHoa();
            map.tch = this;
            map.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (luu == 0)
            {
                try
                {
                    string ten = txtTen.Text;
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    float latt = float.Parse(txtLat.Text);
                    float lngg = float.Parse(txtLng.Text);
                    TramCuuHoa tramcuuhoa = new TramCuuHoa() { name = ten, address = diachi, phone = sdt, lat = latt, lng = lngg };

                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(baseAddress);
                        var postTask = client.PostAsJsonAsync<TramCuuHoa>("tramcuuhoa", tramcuuhoa);
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
                    MessageBox.Show("thêm không thành công \n" + ex);

                }
            }
            else
            {
                try
                {
                    int id1 = int.Parse(txtID.Text);
                    string ten = txtTen.Text;
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    float latt = float.Parse(txtLat.Text);
                    float lngg = float.Parse(txtLng.Text);
                    TramCuuHoa tramcuuhoa = new TramCuuHoa() { id = id1, name = ten, address = diachi, phone = sdt, lat = latt, lng = lngg };
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(baseAddress);
                        var postTask = client.PutAsJsonAsync<TramCuuHoa>("tramcuuhoa", tramcuuhoa);

                        postTask.Wait();

                        var result = postTask.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            MessageBox.Show("sửa thành công");
                            AnHien2(false);
                            loaddata();
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("vui lòng chọn mã");
                }

            }
        }

        private void UserControlTramCuuHoa_Load(object sender, EventArgs e)
        {
            AnHien2(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            AnHien2(false);
        }
    }
}
