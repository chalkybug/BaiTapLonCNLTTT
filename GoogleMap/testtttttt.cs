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
    public partial class testtttttt : Form
    {
        public string baseAddress = "http://localhost:8177/api/";
        public testtttttt(string id)
        {
            InitializeComponent();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("SoXeTrong?id=" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    var xe = readTask.Result;
                    dataGridView1.DataSource = xe;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        //private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
        //    {
        //        // If the mouse moves outside the rectangle, start the drag.
        //        if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
        //        {
        //            // Proceed with the drag and drop, passing in the list item.                    
        //            dataGridView1.DoDragDrop(dataGridView1.Rows[rowIndexFromMouseDown], DragDropEffects.Copy);
        //            // DragDropEffects dropEffect = dataGridView1.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);

        //        }



        //    }
        //}
        //private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    // Get the index of the item the mouse is below.
        //    rowIndexFromMouseDown = dataGridView1.HitTest(e.X, e.Y).RowIndex;

        //    if (rowIndexFromMouseDown != -1)
        //    {
        //        Size dragSize = SystemInformation.DragSize;
        //        dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
        //    }
        //    else
        //        // Re   set the rectangle if the mouse is not over an item in the ListBox.
        //        dragBoxFromMouseDown = Rectangle.Empty;
        //}


        private void testtttttt_Load(object sender, EventArgs e)
        {

        }

        //private void dataGridView2_DragOver(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Copy;
        //}

        //private void dataGridView2_DragDrop(object sender, DragEventArgs e)
        //{
        //    try
        //    {
        //        DataGridViewRow rowmove = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
        //        for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
        //        {
        //            if (rowmove.Cells[0].Value.ToString() == dataGridView2.Rows[i].Cells[0].Value.ToString())
        //            {
        //                MessageBox.Show("Xe này đã tồn tại");
        //                return;
        //            }
        //        }


        //        dataGridView2.Rows.Add(rowmove.Cells[0].Value, rowmove.Cells[1].Value, rowmove.Cells[2].Value, rowmove.Cells[3].Value, rowmove.Cells[4].Value, rowmove.Cells[5].Value);

        //        //dataGridView1.Rows.RemoveAt(rowIndexFromMouseDown);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        MessageBox.Show("loi ke tha");
        //    }

        //}
        // string[] mang = new string[10];
        List<string> list = new List<string>();
        string ma;
        private void button2_Click(object sender, EventArgs e)
        {
            //for (int i=0;i<dataGridView1.RowCount-1;i++)
            //{
            //    DataGridViewRow row = dataGridView1.Rows[i];
            //    if (Convert.ToBoolean(row.Cells[0].Value))
            //    {
            //        dataGridView2.Rows.Add(row.DataBoundItem);
            //        dataGridView1.Rows.RemoveAt(row.Index);
            //    }
            //}
            SqlConnection conn = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=qlPCCC;Integrated Security=True");



            DataTable dt = new DataTable();
            foreach (var item in list)
            {
                SqlDataAdapter da = new SqlDataAdapter("update XeCuuHoa set status='busy' where id='" + item + "'", conn);
                da.Fill(dt);
            }
            MessageBox.Show("goi xe thanh cong");
            string id = "1";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("SoXeTrong?id=" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<DataTable>();
                    readTask.Wait();
                    var xe = readTask.Result;
                    dataGridView1.DataSource = xe;
                }
            }
            //for (int i = 0; i < dataGridView2.RowCount; i++)
            //{
            //    DataGridViewRow row = dataGridView2.Rows[i];
            //    dataGridView2.Rows.RemoveAt(row.Index);
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = (Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
            row.Cells[1].Value = (Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value));
            row.Cells[2].Value = (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value));
            row.Cells[3].Value = (Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value));
            row.Cells[4].Value = (Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value));
            row.Cells[5].Value = (Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value));
             ma = Convert.ToString(row.Cells[0].Value);
            //for (int j = 0; j <= i; j++)
            //{
            //    if (mang[0] == null)
            //    {
            //        mang[i] = ma;
            //        i++;
            //        break;
            //    }
            //    if (mang[j] ==ma)
            //    {
            //        MessageBox.Show("da chon cai nay roi");
            //        //i++;
            //        return;
            //    }
            //    else
            //    {

            //        mang[i] = ma;
            //        i++;

            //    }

            //}
            //for (int j = 0; j <= i; j++)
            //{
            //    if (mang[0] == null)
            //    {
            //        mang[i] = ma;
            //        i++;
            //        break;
            //    }
            //    else if (mang[j] != ma)
            //    {
            //        mang[i] = ma;
            //        i++;
            //        //MessageBox.Show("da chon cai nay roi");
            //        //i++;
            //        return;
            //    }
            //}
            string text = list.Find(item => item == ma);
            if (text==null)
            {
                list.Add(ma);
            }
            else
            {
                MessageBox.Show("da chon cai nay roi");
                return;
            }
            dataGridView2.Rows.Add(row);
            //dataGridView2.Rows.Add(Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
            //dataGridView2.Rows.Add(Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value));
            //dataGridView2.Rows.Add(Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value));
            //dataGridView2.Rows.Add(Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value));
            //dataGridView2.Rows.Add(Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value));
            //dataGridView2.Rows.Add(Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value));

            //dataGridView2.CurrentRow.Cells[0].Value = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            //dataGridView2.CurrentRow.Cells[1].Value = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            //dataGridView2.CurrentRow.Cells[2].Value = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            //dataGridView2.CurrentRow.Cells[3].Value = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            //dataGridView2.CurrentRow.Cells[4].Value = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            //dataGridView2.CurrentRow.Cells[5].Value = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
