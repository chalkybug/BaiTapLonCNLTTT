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
    public partial class UserControlXeCuuHoa : UserControl
    {
        public string baseAddress = "http://localhost:8177/api/";

        private int luu = 1;
        private void AnHien2(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
           
        }

        private void loaddata()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("xecuuhoa");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    var students = readTask.Result;
                    dgvXeCuuHoa.DataSource = students;
                }
            }
        }
        public UserControlXeCuuHoa()
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
                    var deleteTask = client.DeleteAsync("xecuuhoa/" + id.ToString());
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
                    int idd = int.Parse(txtID.Text);
                    string tenxe = txtTenXe.Text;
                    int idtram = int.Parse(txtIDTram.Text);
                    float dungtich = float.Parse(txtDungTich.Text);
                    float chieucao = float.Parse(txtChieuCao.Text);

                    string kichthuoc = txtSize.Text;
                    string sta = txtStatus.Text;
                    XeCuuHoa xecuuhoa = new XeCuuHoa() { id = idd, name = tenxe, idTramCuuHoa = idtram, capacity = dungtich, maxHeight = chieucao, size = kichthuoc, status = sta };
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(baseAddress);
                        var postTask = client.PostAsJsonAsync<XeCuuHoa>("xecuuhoa", xecuuhoa);
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
                    int idd = int.Parse(txtID.Text);
                    string tenxe = txtTenXe.Text;
                    int idtram = int.Parse(txtIDTram.Text);
                    float dungtich = float.Parse(txtDungTich.Text);
                    float chieucao = float.Parse(txtChieuCao.Text);

                    string kichthuoc = txtSize.Text;
                    string sta = txtStatus.Text;
                    XeCuuHoa xecuuhoa = new XeCuuHoa() { id = idd, name = tenxe, idTramCuuHoa = idtram, capacity = dungtich, maxHeight = chieucao, size = kichthuoc, status = sta };
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(baseAddress);
                        var postTask = client.PutAsJsonAsync<XeCuuHoa>("xecuuhoa", xecuuhoa);

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
