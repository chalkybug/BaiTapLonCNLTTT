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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void quảnLýTrạmCứuHỏaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTramCuuHoa tramcuuhoa = new frmTramCuuHoa();
            tramcuuhoa.ShowDialog();
        }

        private void quảnLýĐámCháyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDamChay damchay = new frmDamChay();
            damchay.ShowDialog();
        }

        private void báoCháyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMapBaoChay mapbaochay = new frmMapBaoChay();
            mapbaochay.MdiParent = this;
            mapbaochay.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }
    }
}
