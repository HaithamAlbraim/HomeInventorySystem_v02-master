using HomeInventorySystem_v01.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeInventorySystem_v01.GUI
{
    public partial class frmStatisticsAndCharts : Form
    {
        public frmStatisticsAndCharts()
        {
            InitializeComponent();
        }

        private void frmStatisticsAndCharts_Load(object sender, EventArgs e)
        {
            lbItems.Items.Add(ItemsDAL.Statistics(frmLogin.CurentUser.UserId).ItemName);
        }
    }
}
