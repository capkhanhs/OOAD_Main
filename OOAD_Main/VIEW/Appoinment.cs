using System;
using OOAD_Main.DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOAD_Main.DTO;
using OOAD_Main.BLL;

namespace OOAD_Main.VIEW
{
    public partial class Appoinment : Form
    {
        private DateTime dt_select;
        public Appoinment(DateTime txt)
        {
            InitializeComponent();
            lb_date.Text = txt.ToString("dd/MM/yyyy");
            dt_select = txt;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DateTime dt_now = DateTime.Now;
            BLL_Calendar bll = new BLL_Calendar();

            String idCh = bll.next_id_ch().ToString().Trim();
            String tenCH = txt_tenCH.Text.Trim();
            DateTime start = new DateTime(
                dt_select.Year,
                dt_select.Month,
                dt_select.Day,
                dt_start.Value.Hour,
                dt_start.Value.Minute,
                0
                );
            DateTime end = new DateTime(
                dt_select.Year,
                dt_select.Month,
                dt_select.Day,
                dt_end.Value.Hour,
                dt_end.Value.Minute,
                0
                );
            String diadiem = txt_dd.Text.Trim();
            Boolean loinhac;

            if (start < dt_now || end < start)
            {
                MessageBox.Show(
                    "Giờ không hợp lệ!",
                    "Thông Báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                loinhac = cb_reminder.Checked;

                CuocHop ch = new CuocHop();
                ch.id_ch = idCh;
                ch.ten_ch = tenCH;
                ch.dia_diem = diadiem;
                ch.tg_batdau = start;
                ch.tg_ketthuc = end;
                ch.id_host = Login.id_nd;
                ch.loi_nhac = loinhac == true ? true : false ;

                CuocHop ch2 = bll.get_info_ch_by_tenCH(tenCH);
                if(ch2 != null)
                {
                    if (ch2.ten_ch == ch.ten_ch && ch2.tg_batdau == ch.tg_batdau && ch2.tg_ketthuc == ch2.tg_ketthuc)
                    {
                        bll.xuLy_CH_Nhom(ch2);
                        this.Close();
                        return;
                    }
                }

                //true là trùng lịch
                if (bll.xuLy_tgCH(ch))
                {
                    DialogResult rs = MessageBox.Show(
                        "Thời gian của cuộc họp này đã trùng với cuộc họp sẵn có!\n" +
                        "Chọn 'Yes' để tiếp tục thêm cuộc họp, 'No' để chỉnh thời gian!",
                        "Cảnh Báo!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                        );

                    if (rs == DialogResult.No) 
                    {
                        return;
                    }
                }

                bll.add_appoinment(ch);

                if (loinhac)
                {
                    MessageBox.Show(
                    "Thêm lịch thành công!\nLời nhắc sẽ thông báo trước 5 phút!",
                    "Thông Báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                    "Thêm lịch thành công!",
                    "Thông Báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                }    
            }

            this.Close();
        }
    }
}
