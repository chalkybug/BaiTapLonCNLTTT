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
    public partial class UserControlThongKe : UserControl
    {
        public void AnHien(bool e)
        {
            palDanhSach.Visible = e;
            palBieuDo.Visible = e;
        }
        public UserControlThongKe()
        {
            InitializeComponent();
            AnHien(false);
            palBieuDo.Visible = true;
        }

        private void btnTramCuuHoa_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palDanhSach.Visible = true;
            userControlThongKeDanhSach1.BringToFront();
        }

        private void btnTruNuoc_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palBieuDo.Visible = true;
            userControlThongKeBieuDo1.BringToFront();
        }

        private void userControlThongKeBieuDo1_Load(object sender, EventArgs e)
        {

        }
    }
}
