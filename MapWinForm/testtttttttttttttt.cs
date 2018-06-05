using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapWinForm
{
    public partial class testtttttttttttttt : Form
    {
        //int panelwidth;
        //bool hidden;
        
        public void AnHien(bool e)
        {
            palHome.Visible = e;
            palMap.Visible = e;
            palLienHe.Visible = e;
            palThoat.Visible = e;
            palThongKe.Visible = e;
            palQuanLy.Visible = e;
        }
        public testtttttttttttttt()
        {
            InitializeComponent();
            AnHien(false);
            //palHome.Visible = true;
            //panelwidth = panelSlide.Width;
            //panelSlide.Visible = false;
            //hidden = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palHome.Visible = true;

        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palMap.Visible = true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            AnHien(false);
            palThongKe.Visible = true;
            userThongKe1.BringToFront();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palLienHe.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palThoat.Visible = true;
            Application.Exit();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            AnHien(false);
            palQuanLy.Visible = true;
            //timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (hidden)
            //{
            //    panelSlide.Width = panelSlide.Width + 10;
            //    if (panelSlide.Width >= panelwidth)
            //    {
            //        timer1.Stop();
            //        hidden = false;
            //        this.Refresh();
            //    }
            //}
            //else
            //{

            //    panelSlide.Width = panelSlide.Width - 10;
            //    if (panelSlide.Width <= 0)
            //    {
            //        timer1.Stop();
            //        hidden = true;
            //        this.Refresh();
            //    }
            //}
        }

        private void userThongKe1_Load(object sender, EventArgs e)
        {

        }
    }
}
