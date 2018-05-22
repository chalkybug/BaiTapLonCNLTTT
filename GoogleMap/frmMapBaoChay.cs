using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GoogleMap
{
    public partial class frmMapBaoChay : Form
    { 
        int index = 0;
        double lat = 21.036237;
        double lng = 105.790583;
        GMarkerGoogle marker;
        GMapOverlay markerOverday;
        DataTable dt;
        List<PointLatLng> point = new List<PointLatLng>();
        PointLatLng start;
        PointLatLng end;
        public frmMapBaoChay()
        {
            InitializeComponent();
        }
        public void ShowTramCuuHoa()
        {
           // try
            //{
                SqlConnection conn = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=qlPCCC;Integrated Security=True");
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from TramCuuHoa", conn);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                dataGridView1.DataSource = dt;

                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    double a = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    double b = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    string diachi = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    point.Add(new PointLatLng(a, b));
                }
                List<double> kc = new List<double>();
                GDirections direction;
                //start = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text));

                foreach (var item in point)
                {
                    GMarkerGoogle marker1 = new GMarkerGoogle(item, GMarkerGoogleType.red);
                    markerOverday.Markers.Add(marker1);
                    end = new PointLatLng(item.Lat, item.Lng);

                    var path = GMapProviders.GoogleMap.GetDirections(out direction, start, end, true, true, true, true, true);
                    GMapRoute router = new GMapRoute(direction.Route, "Router");
                    kc.Add(router.Distance);
                }
                 kc.Sort();
            dt.Columns.Add("Khoang cach");
              //  foreach (double item1 in kc)
               //  {
                    //dt.Rows.Add(item1);
                   // MessageBox.Show(item1.ToString());
                //     //var path = GMapProviders.GoogleMap.GetDirections(out direction, start, end, true, true, true, true, true);
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
        private void frmMapBaoChay_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(lat, lng);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom =15;
            gMapControl1.AutoScroll = true;
            markerOverday = new GMapOverlay("Marker");
            marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.green);
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
            index = e.RowIndex;
            txtDiaChi.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtLat.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txtLng.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            marker.Position = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text));
            gMapControl1.Position = marker.Position;
            marker.ToolTipText = $"Thông tin:{txtDiaChi.Text}\n Lat: {txtLat.Text}\n Lng: {txtLng.Text}";
        }

        private void btnBaoChay_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            ShowTramCuuHoa();
        }
    }
}
