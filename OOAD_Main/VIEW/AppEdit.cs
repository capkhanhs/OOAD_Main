using OOAD_Main.DTO;
using OOAD_Main.BLL;
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
    public partial class AppEdit : Form
    {
        private String id_ch;
        private BLL_Calendar bll = new BLL_Calendar();
        public AppEdit(string id_ch)
        {
            InitializeComponent();
            this.id_ch = id_ch;
            get_info();
        }

        public void get_info()
        {
            CuocHop ch = bll.get_info_ch(id_ch);
            if(ch == null)
            {
                MessageBox.Show(
                    "Không tìm thấy cuộc họp",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                txt_tenCH.Text = ch.ten_ch.ToString();
                txt_dd.Text = ch.dia_diem.ToString();
                dt_start.Value = ch.tg_batdau.Value;
                dt_end.Value = ch.tg_ketthuc.Value;
                cb_reminder.Checked = ch.loi_nhac.Value == true ? true : false;
            }    
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            bll.delete_appoinment(id_ch);
            MessageBox.Show(
                "Xóa thành công",
                "Thông Báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            String ten_ch = txt_tenCH.Text.Trim();
            String dia_diem = txt_dd.Text.Trim();
            DateTime tg_batdau = dt_start.Value;
            DateTime tg_ketthuc = dt_end.Value;
            Boolean loi_nhac = cb_reminder.Checked;

            bool result = bll.update_appoinment(id_ch, ten_ch, dia_diem, tg_batdau, tg_ketthuc, loi_nhac);

            if (result)
            {
                MessageBox.Show(
                    "Cập nhật thành công",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                get_info();
            }
            else
            {
                MessageBox.Show(
                    "Cập nhật thất bại",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

            this.Close();
        }
    }
}
