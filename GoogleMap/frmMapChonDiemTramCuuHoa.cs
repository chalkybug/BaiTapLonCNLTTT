using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMap
{
    public partial class frmMapChonDiemTramCuuHoa : Form
    {
        double lat = 21.036237;
        double lng = 105.790583;
        GMarkerGoogle marker;
        GMapOverlay markerOverday;
        public frmMapChonDiemTramCuuHoa()
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
        public UserControlTramCuuHoa tch;
        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double latt = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lngg = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            marker.Position = new PointLatLng(latt, lngg);
            marker.ToolTipText = $"Location: {latt} and {lngg}";
            tch.txtLat.Text = latt.ToString();
            tch.txtLng.Text = lngg.ToString();
            this.Hide();
        }
    }
}
