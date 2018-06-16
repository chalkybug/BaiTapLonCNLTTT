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

namespace GoogleMap
{
    public partial class UserControlMap : UserControl
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
        public UserControlMap()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(lat, lng);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 15;
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

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            MessageBox.Show(item.ToolTipText.ToString());
        }
    }
}
