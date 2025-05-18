using OOAD_Main.BLL;
using OOAD_Main.DAL;
using OOAD_Main.VIEW;
using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Main
{
    public partial class Main : Form
    {
        private BLL_Calendar bll;
        private System.Timers.Timer reminderTimer;
        public Main()
        {
            InitializeComponent();
            bll = new BLL_Calendar();   
            pn_ch.FlowDirection = FlowDirection.TopDown;
            pn_ch.HorizontalScroll.Visible = false;
            btn_reload_Click(this, EventArgs.Empty);
            setup_reminderTimer();
        }

        private void setup_reminderTimer()
        {
            reminderTimer = new System.Timers.Timer(60000); // 1 minute interval
            reminderTimer.Elapsed += ReminderTimer_Check;
            reminderTimer.AutoReset = true;
            reminderTimer.Enabled = true;
            reminderTimer.Start();
        }

        private void ReminderTimer_Check(Object source, ElapsedEventArgs e)
        {
            //vì nó chạy trên luồng riêng nên cần chỉnh cho nó về chạy trên luồng chính của form chính
            this.Invoke((MethodInvoker)delegate
            {
                bll.check_reminder();
                Console.WriteLine("Timer chạy lúc: " + DateTime.Now.ToString("HH:mm:ss"));
            });
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DateTime dt_now = DateTime.Now;
            DateTime dt_select = date.SelectionStart;

            if(dt_select < dt_now.Date)
            {
                MessageBox.Show(
                    "Ngày không hợp lệ"
                    ,"Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                DateTime txt = dt_select; ;
                Appoinment app = new Appoinment(txt);
                app.ShowDialog();
            }

            btn_reload_Click(this, EventArgs.Empty);
        }

        public void btn_reload_Click(object sender, EventArgs e)
        {
            pn_ch.Controls.Clear();
            pn_ch.AutoScroll = true;
            pn_ch.WrapContents = false;

            List<UC> li = bll.show_app();
            foreach (var i in li)
            {
                pn_ch.Controls.Add(i);
            }
        }
    }
}
