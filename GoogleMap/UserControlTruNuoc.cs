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
    public partial class userControlTruNuoc1 : UserControl
    {
        public string baseAddress = "http://localhost:8177/api/";

        private int luu = 1;
        private void AnHien2(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            txtID.Enabled = e;
            txtTP.Enabled = e;
            txtQH.Enabled = e;
            txtDC.Enabled = e;
            txtLat.Enabled = e;
            txtLng.Enabled = e;
        }

        private void loaddata()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("TruNuoc");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    var students = readTask.Result;
                    dgvTruNuoc.DataSource = students;
                }
            }
        }
        public userControlTruNuoc1()
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
                    var deleteTask = client.DeleteAsync("trunuoc/" + id.ToString());
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (luu == 0)
            {
                try
                {
                    string thanhpho = txtTP.Text;
                    string diachi = txtDC.Text;
                    string quanhuyen = txtQH.Text;
                    float latt = float.Parse(txtLat.Text);
                    float lngg = float.Parse(txtLng.Text);
                    TruNuoc trunuoc = new TruNuoc() { city=thanhpho,county=quanhuyen, address = diachi , lat = latt, lng = lngg };

                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(baseAddress);
                        var postTask = client.PostAsJsonAsync<TruNuoc>("trunuoc", trunuoc);
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

                    string thanhpho = txtTP.Text;
                    string diachi = txtDC.Text;
                    string quanhuyen = txtQH.Text;
                    float latt = float.Parse(txtLat.Text);
                    float lngg = float.Parse(txtLng.Text);
                    TruNuoc trunuoc = new TruNuoc() { id = id1, city=thanhpho,county=quanhuyen, address = diachi,  lat = latt, lng = lngg };
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(baseAddress);
                        var postTask = client.PutAsJsonAsync<TruNuoc>("TruNuoc", trunuoc);

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
        private void UserControlTruNuoc_Load(object sender, EventArgs e)
        {
            AnHien2(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            AnHien2(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgvTruNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dgvTruNuoc.CurrentRow.Cells["id"].Value);
            txtTP.Text = Convert.ToString(dgvTruNuoc.CurrentRow.Cells["city"].Value);
            txtQH.Text = Convert.ToString(dgvTruNuoc.CurrentRow.Cells["county"]);
            txtDC.Text = Convert.ToString(dgvTruNuoc.CurrentRow.Cells["address"]);

            txtLat.Text = Convert.ToString(dgvTruNuoc.CurrentRow.Cells["lat"].Value);
            txtLng.Text = Convert.ToString(dgvTruNuoc.CurrentRow.Cells["lng"].Value);
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTruNuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblTHietHai_Click(object sender, EventArgs e)
        {

        }

        private void lbltp_Click(object sender, EventArgs e)
        {

        }

        private void txtDC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbldc_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLng_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuan_Click(object sender, EventArgs e)
        {

        }
    }
}
