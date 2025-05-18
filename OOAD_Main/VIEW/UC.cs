using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Main.VIEW
{
    public partial class UC : System.Windows.Forms.UserControl
    {
        public UC()
        {
            InitializeComponent();
        }

        public void get_info(String tenCH, String DiaDiem, DateTime startTime, DateTime endTime, String id_host)
        {
            lb_tench.Text = tenCH;
            lb_rs_dd.Text = DiaDiem;
            lb_rs_bd.Text = startTime.ToString("dd/MM/yyyy HH:mm");
            lb_rs_kt.Text = endTime.ToString("dd/MM/yyyy HH:mm");
            lb_rs_host.Text = id_host;
        }

        private void UC_DoubleClick(object sender, EventArgs e)
        {
            AppEdit app2 = new AppEdit(this.Name.ToString());
            app2.ShowDialog();
        }
    }
}
