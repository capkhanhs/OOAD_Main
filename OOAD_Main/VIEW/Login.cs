using System;
using OOAD_Main.BLL;
using OOAD_Main.DAL;
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
    public partial class Login : Form
    {
        public static String id_nd { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_tk.Text) || String.IsNullOrEmpty(txt_mk.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập tài khoản và mật khẩu",
                    "Thông Báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                BLL_Calendar bll = new BLL_Calendar();
                Console.WriteLine(txt_tk.Text + " " + txt_mk.Text + "C2K");
                id_nd = bll.check_dangNhap(txt_tk.Text.Trim(), txt_mk.Text.Trim());
                if (id_nd != "NULL")
                {
                    this.Hide();
                    Main main = new Main();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                    txt_mk.Text = "";
                }

            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btn_dn_Click(sender, e);
            }
        }
    }
}
