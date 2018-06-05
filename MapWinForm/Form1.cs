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

namespace MapWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loaddata();
        }

        private void loaddata()
        {
            DataTable dt = new DataTable();

            dt = DamChayBUS.Instance.ShowTable();
            dataGridView1.DataSource = dt;
        }
        public string baseAddress = "http://localhost:8177/api/";
        private void button1_Click(object sender, EventArgs e)
        {
            // giả sử truyền vào là một tramcuuhoa
            TramCuuHoa tramcuuhoa = new TramCuuHoa() { name = "tram a", address = "tay ho", phone ="343234",lat=2112,lng=2323};



            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP POST
                var postTask = client.PostAsJsonAsync<TramCuuHoa>("tramcuuhoa", tramcuuhoa);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
