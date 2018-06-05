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
    public partial class frmMain2 : Form
    {
        public void AnHien(bool e)
        {
            palHome.Visible = e;
            palMap.Visible = e;
            palLienHe.Visible = e;
            palThoat.Visible = e;
            palThongKe.Visible = e;
            palQuanLy.Visible = e;
        }
        public frmMain2()
        {
            InitializeComponent();
            AnHien(false);
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palHome.Visible = true;
            userControlHome1.BringToFront();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palMap.Visible = true;
            userControlMap1.BringToFront();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palQuanLy.Visible = true;
            userControlQuanLy1.BringToFront();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palThongKe.Visible = true;
            userControlThongKe1.BringToFront();
        }

        private void btnLienHe_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palLienHe.Visible = true;
            userControlLienHe1.BringToFront();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palThoat.Visible = true;
            Application.Exit();
        }

        private void userControlQuanLy1_Load(object sender, EventArgs e)
        {

        }

        private void userControlHome1_Load(object sender, EventArgs e)
        {

        }
    }
}
