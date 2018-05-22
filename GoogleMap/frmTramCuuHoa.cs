using MapData.BUS;
using MapData.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace GoogleMap
{
    public partial class frmTramCuuHoa : Form
    {
        public frmTramCuuHoa()
        {
            InitializeComponent();
            loaddata();
        }
        private void loaddata()
        {
            DataTable dt = new DataTable();
            dt = TramCuuHoaBUS.Instance.ShowTable();
            dgvTramCuuHoa.DataSource = dt;
        }
        public string baseAddress = "http://localhost:8177/api/";
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            float latt =float.Parse( txtLat.Text);
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
                    loaddata();
                }
            }
        }

        private void frmTramCuuHoa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
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

        private void dgvTramCuuHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["id"].Value);
            txtDiaChi.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["address"].Value);
            txtLat.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["lat"].Value);
            txtLng.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["lng"].Value);
            txtSDT.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["phone"].Value);
            txtTen.Text = Convert.ToString(dgvTramCuuHoa.CurrentRow.Cells["name"].Value);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
