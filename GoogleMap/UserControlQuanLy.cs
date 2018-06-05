using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMap
{
    public partial class UserControlQuanLy : UserControl
    {
        public void AnHien(bool e)
        {
            palDamChay.Visible = e;
            palTramCuuHoa.Visible = e;
            palTruNuoc.Visible = e;
            palXeCuuHoa.Visible = e;
        }
        public UserControlQuanLy()
        {
            InitializeComponent();
            AnHien(false);
            palTramCuuHoa.Visible = true;
        }

        private void btnDamChay_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palDamChay.Visible = true;
            userControlDamChay1.BringToFront();
        }

        private void btnTramCuuHoa_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palTramCuuHoa.Visible = true;
            userControlTramCuuHoa1.BringToFront();
        }

        private void btnTruNuoc_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palTruNuoc.Visible = true;
        }

        private void btnXeCuuHoa_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palXeCuuHoa.Visible = true;
        }
    }
}
