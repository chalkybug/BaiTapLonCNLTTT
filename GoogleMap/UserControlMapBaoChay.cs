using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Net.Http;

namespace GoogleMap
{
    public partial class UserControlMapBaoChay : UserControl
    {
        public string baseAddress = "http://localhost:8177/api/";
        double lattt = 21.036237;
        double lnggg = 105.790583;
        GMarkerGoogle marker;
        GMapOverlay markerOverday;
        DataTable dt;
        List<PointLatLng> point = new List<PointLatLng>();
        PointLatLng start;
        PointLatLng end;
        public UserControlMapBaoChay()
        {
            InitializeComponent();
        }
        public void ShowTramCuuHoa()
        {
            // try
            //{
            //SqlConnection conn = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=qlPCCC;Integrated Security=True");
            //conn.Open();
            //SqlDataAdapter da = new SqlDataAdapter("select * from TramCuuHoa", conn);
            //dt = new DataTable();
            //da.Fill(dt);
            //conn.Close();
            //dataGridView1.DataSource = dt;
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
                    var dt = readTask.Result;
                    dataGridView1.DataSource = dt;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        double a = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                        double b = double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                        string diachi = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        point.Add(new PointLatLng(a, b));
                    }
                    List<double> kc = new List<double>();
                    dt.Columns.Add("KC");
                    try
                    {
                        foreach (var item in point)
                        {
                            GMarkerGoogle marker1 = new GMarkerGoogle(item, GMarkerGoogleType.red);
                            markerOverday.Markers.Add(marker1);
                            end = new PointLatLng(item.Lat, item.Lng);
                            MapRoute route = OpenStreetMapProvider.Instance.GetRoute(start, end, false, false, 15);
                            GMapRoute r = new GMapRoute(route.Points, "a");
                            GMapOverlay routesOverlay = new GMapOverlay("a");
                            routesOverlay.Routes.Add(r);
                            gMapControl1.Overlays.Add(routesOverlay);
                            gMapControl1.Zoom = gMapControl1.Zoom + 1;
                            gMapControl1.Zoom = gMapControl1.Zoom - 1;
                            r.Stroke.Width = 5;
                            r.Stroke.Color = Color.SeaGreen;
                            kc.Add(r.Distance);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Lỗi nhà cung cấp google map, vui lòng thoát chương trình và chạy lại");
                    }
                    
                    //  }
                    //  catch (System.Exception ex)
                    // {
                    //     MessageBox.Show("adas");
                    //  }

                    //     kc.Sort();

                    //for (int i = 0,count=kc1.Count; i <= count; i++)
                    //{
                    //    dt.Rows[i]["KC"] = kc1[i];
                    //}
                    int j = 0;
                    foreach (var item in kc)
                    {
                        dt.Rows[j]["KC"] = item;
                        j++;

                    }
                    dataGridView1.DataSource = dt;
                }
            }


            //    List<double> kc = new List<double>();
            //GDirections direction;

            //  dt.Columns.Add("KC", typeof(double));
            //    //start = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text));
            //   try
            //  {




            // MessageBox.Show(item1.ToString());
            //var path = GMapProviders.GoogleMap.GetDirections(out direction, start, end, true, true, true, true, true);
            //     //GMapRoute router = new GMapRoute(direction.Route, "Router");
            //     // router.Stroke.Width = 5;
            //     // router.Stroke.Color = Color.Yellow;
            //  }
            // }
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show("loi");
            //}


        }
        private void btnBaoChay_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            ShowTramCuuHoa();
        }

        private void UserControlMapBaoChay_Load(object sender, EventArgs e)
        {
            btnChonXe.Enabled = false;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(lattt, lnggg);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 13;
            gMapControl1.AutoScroll = true;
            markerOverday = new GMapOverlay("Marker");
            marker = new GMarkerGoogle(new PointLatLng(lattt, lnggg), GMarkerGoogleType.green);
            // ShowTramCuuHoa();
            markerOverday.Markers.Add(marker);

            //// tooltip mode
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = $"Location: {lat} and {lng}";

            //// add to map
            gMapControl1.Overlays.Add(markerOverday);
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            txtLat.Text = lat.ToString();
            txtLng.Text = lng.ToString();
            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = $"Location: {lat} and {lng}";
            start = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text));
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtSDT.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txtKC.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            txtDiaChi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtLat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txtLng.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            marker.Position = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text));
            gMapControl1.Position = marker.Position;
            marker.ToolTipText = $"Thông tin:{txtDiaChi.Text}\n SĐT: {txtSDT.Text} \n Lat: {txtLat.Text}\n Lng: {txtLng.Text}\n Khoảng cách: {txtKC.Text} km";
            btnChonXe.Enabled = true;
        }

        private void btnChonXe_Click(object sender, EventArgs e)
        {
            frmSoXeTrong map = new frmSoXeTrong(txtID.Text);
            map.Show();
        }
    }
}
