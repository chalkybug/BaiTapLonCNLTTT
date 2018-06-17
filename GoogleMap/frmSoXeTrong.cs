using MapData.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMap
{
    public partial class frmSoXeTrong : Form
    {
        public string baseAddress = "http://localhost:8177/api/";
        List<string> list = new List<string>();
        string ma;

        List<XeCuuHoa> dsXeCuuHoa = new List<XeCuuHoa>();
        public void loaddata(string id)
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
                    var readTask = result.Content.ReadAsAsync<List<XeCuuHoa>>();
                    readTask.Wait();
                    dsXeCuuHoa = readTask.Result;
                    
                }
            }
            dgvSoXeTrong.DataSource = dsXeCuuHoa.Where(x => x.status == "free").ToList();
        }

        string idd;
        public frmSoXeTrong(string id)
        {
            InitializeComponent();
            loaddata(id);
            idd = id;
        }
        private void btnGoiXe_Click(object sender, EventArgs e)
        {
            XeCuuHoa xe = dsXeCuuHoa.Where(x => x.id == int.Parse(ma)).FirstOrDefault();
            xe.status = "busy";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                var postTask = client.PutAsJsonAsync<XeCuuHoa>("xecuuhoa", xe);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("gọi xe thành công");
                    loaddata(idd);
                }
            }


        }

        private void dgvSoXeTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvSoXeTrong.Rows[0].Clone();
            row.Cells[0].Value = (Convert.ToString(dgvSoXeTrong.CurrentRow.Cells[0].Value));
            row.Cells[1].Value = (Convert.ToString(dgvSoXeTrong.CurrentRow.Cells[1].Value));
            row.Cells[2].Value = (Convert.ToString(dgvSoXeTrong.CurrentRow.Cells[2].Value));
            row.Cells[3].Value = (Convert.ToString(dgvSoXeTrong.CurrentRow.Cells[3].Value));
            row.Cells[4].Value = (Convert.ToString(dgvSoXeTrong.CurrentRow.Cells[4].Value));
            row.Cells[5].Value = (Convert.ToString(dgvSoXeTrong.CurrentRow.Cells[5].Value));
            ma = Convert.ToString(row.Cells[0].Value);
            string text = list.Find(item => item == ma);
            if (text == null)
            {
                list.Add(ma);
            }
            else
            {
                MessageBox.Show("Xe này đã được chọn");
                return;
            }
            dgvXeDuocChon.Rows.Add(row);
            btnGoiXe.Enabled = true;
        }

        private void frmSoXeTrong_Load(object sender, EventArgs e)
        {
            btnGoiXe.Enabled = false;
        }
    }
}
