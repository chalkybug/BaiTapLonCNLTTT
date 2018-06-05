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
    public partial class testbaocao : Form
    {
        public testbaocao()
        {
            InitializeComponent();
        }

        private void testbaocao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BaoCaoThietHai.DamChay' table. You can move, or remove it, as needed.
            this.DamChayTableAdapter.Fill(this.BaoCaoThietHai.DamChay, "2018-01-1", "2018-05-23", "Nam Từ Liêm");

            this.reportViewer1.RefreshReport();
        }
    }
}
