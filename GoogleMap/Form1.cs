using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;

namespace GoogleMap
{
    public partial class Form1 : Form
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverday;
        DataTable dt;
        int index;

        double lat = 21.036237;
        double lng = 105.790583;

        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        

        private void loadData()
        {
            List<PointLatLng> point = new List<PointLatLng>();
            point.Add(new PointLatLng(21.1357452550306, 105.827178955078));
            point.Add(new PointLatLng(21.1235761292987, 105.969314575195));
            point.Add(new PointLatLng(21.0345190208582, 105.78254699707));
            point.Add(new PointLatLng(21.0361212383399, 105.837135314941));
            point.Add(new PointLatLng(21.023783719337, 105.806407928467));

            point.Add(new PointLatLng(21.0468756771067, 105.783276557922));
            point.Add(new PointLatLng(21.0466353629359, 105.804948806763));
            point.Add(new PointLatLng(21.0654387742564, 105.786237716675));
            point.Add(new PointLatLng(21.0374029999189, 105.774221420288));

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
            gMapControl1.Position = new PointLatLng(lat, lng);
            gMapControl1.AutoScroll = true;
            gMapControl1.Zoom = 13;
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;

            markerOverday = new GMapOverlay("Marker");
            marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.green);
            // load fire station
            foreach (var item in point)
            {
                GMarkerGoogle marker1 = new GMarkerGoogle(item, GMarkerGoogleType.red);
                markerOverday.Markers.Add(marker1);
            }
            markerOverday.Markers.Add(marker);

            // tooltip mode
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = $"Location: {lat} and {lng}";

            // add to map
            gMapControl1.Overlays.Add(markerOverday);

            // add datatable
            dt = new DataTable();
            dt.Columns.Add("địa chỉ", typeof(string));
            dt.Columns.Add("lat", typeof(double));
            dt.Columns.Add("lon", typeof(double));

            dt.Rows.Add("cầu giấy", lat, lng);
            dt.Rows.Add("Tây hồ", 21.081121, 105.818031);
            dt.Rows.Add("Tàu", 35.86166, 104.195397);
            dataGridView1.DataSource = dt;





        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            txtAddress.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtLat.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtLng.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

            marker.Position = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text));
            gMapControl1.Position = marker.Position;

        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            txtLat.Text = lat.ToString();
            txtLng.Text = lng.ToString();
            marker.Position = new PointLatLng(lat, lng);
          //  marker.ToolTipText = $"Lat: {lat} and Lng: {lng}";

            SearchPath(lat, lng);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtAddress.Text, Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text));
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dt.Rows.RemoveAt(index);
        }



        PointLatLng start;
        PointLatLng end;
        int indexPath = 0;
        bool isSearch;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            isSearch = true;
            btnSearch.Enabled = false;
        }

        //search path
        public void SearchPath(double lat, double lng)
        {
            try
            {
                if (isSearch)
                {
                    switch (indexPath)
                    {
                        case 0:
                            indexPath++;
                            start = new PointLatLng(lat, lng);
                            break;
                        case 1:
                            indexPath++;
                            end = new PointLatLng(lat, lng);

                            GDirections direction;
                            var path = GMapProviders.GoogleMap.GetDirections(out direction, start, end, false, false, false, false, false);
                            GMapRoute router = new GMapRoute(direction.Route, "Router");
                            router.Stroke.Width = 5;
                            router.Stroke.Color = Color.BlueViolet;

                            GMapOverlay overlay = new GMapOverlay("Overlay");
                            overlay.Routes.Add(router);
                            gMapControl1.Overlays.Add(overlay);

                            gMapControl1.Zoom = gMapControl1.Zoom + 1;
                            gMapControl1.Zoom = gMapControl1.Zoom - 1;
                            txtDistance.Text = router.Distance.ToString();
                            // set default
                            isSearch = false;
                            indexPath = 0;
                            btnSearch.Enabled = true;
                            break;
                        default:
                            indexPath = 0;
                            break;
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("null");
            }
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(gMapControl1.Zoom);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackBar1.Value;
        }
    }
}
