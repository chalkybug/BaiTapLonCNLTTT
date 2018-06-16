﻿using MapData.DTO;
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
        public void loaddata(string id)
        {
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri(baseAddress);
            //    //HTTP GET
            //    var responseTask = client.GetAsync("SoXeTrong?id=" + id);
            //    responseTask.Wait();
            //    var result = responseTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        var readTask = result.Content.ReadAsAsync<DataTable>();
            //        readTask.Wait();
            //        var xe = readTask.Result;
            //        dgvSoXeTrong.DataSource = xe;
            //    }
            //}


            List<XeCuuHoa> listXe = new List<XeCuuHoa>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("XeCuuHoa");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<XeCuuHoa>>();
                    readTask.Wait();
                    listXe = readTask.Result;

                }
            }
            List<XeCuuHoa> xeCuuHoaTrong = listXe.Where(x => x.status == "free" && x.idTramCuuHoa==Convert.ToInt32(id)).ToList();
            dgvSoXeTrong.DataSource = xeCuuHoaTrong;
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
            foreach(var item in list)
            {
                int id1 = int.Parse(item);
                XeCuuHoa soxetrong = new XeCuuHoa(){id = id1};
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);
                    var postTask = client.PutAsJsonAsync<XeCuuHoa>("xecuuhoa/SuaTrangThaiXe", soxetrong);

                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("gọi xe thành công");
                        loaddata(idd);
                    }
                }
            }
            
            //SqlConnection conn = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=qlPCCC;Integrated Security=True");



            //DataTable dt = new DataTable();
            //foreach (var item in list)
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("update XeCuuHoa set status='busy' where id='" + item + "'", conn);
            //    da.Fill(dt);
            //}
           
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
            row.Cells[6].Value = (Convert.ToString(dgvSoXeTrong.CurrentRow.Cells[6].Value));
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
