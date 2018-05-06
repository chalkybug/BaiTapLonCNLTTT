using MapData.BUS;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loaddata();
        }

        private void loaddata()
        {
            DataTable dt = new DataTable();
            dt = DamChayBUS.Instance.ShowTable();
            dataGridView1.DataSource = dt;
        }
    }
}
