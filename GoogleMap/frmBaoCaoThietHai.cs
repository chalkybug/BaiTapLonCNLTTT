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
    public partial class frmBaoCaoThietHai : Form
    {
        public frmThongKe tk;
        public frmBaoCaoThietHai()
        {
            InitializeComponent();
        }

        private void frmBaoCaoThietHai_Load(object sender, EventArgs e)
        {
            string a = tk.date1.Text;
            string b = tk.date2.Text;
            string c = tk.cmbKhuVuc.Text;
            // TODO: This line of code loads data into the 'DataSetBaoCaoThietHai.DamChay' table. You can move, or remove it, as needed.
            this.DamChayTableAdapter.Fill(this.DataSetBaoCaoThietHai.DamChay,a ,b,c);

            this.reportViewer1.RefreshReport();
        }
    }
}
