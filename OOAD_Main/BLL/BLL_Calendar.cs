using OOAD_Main.DAL;
using OOAD_Main.DTO;
using OOAD_Main.VIEW;
using System;
using System.Media;
using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOAD_Main.BLL
{
    public class BLL_Calendar
    {
        private DAL_Calendar dal = new DAL_Calendar();

        public String check_dangNhap(String tk, String mk)
        {
            List<NguoiDung> li = new List<NguoiDung>();
            li.AddRange(dal.getAll_NguoiDung());

            foreach (var item in li)
            {
                if (tk == item.tk.ToString().Trim() && mk == item.mk.ToString().Trim())
                {
                    return item.id.ToString().Trim();
                }
            }
            return "NULL";
        }

        public List<UC> show_app()
        {
            int count = dal.count_appoinment();
            List<UC> li = new List<UC>();

            List<CuocHop> ds_ch = new List<CuocHop>();
            ds_ch = dal.show_appoinment();

            foreach (var i in ds_ch)
            {
                UC uc = new UC();
                uc.get_info(i.ten_ch.ToString(), i.dia_diem.ToString(), i.tg_batdau.Value, i.tg_ketthuc.Value, i.id_host.ToString());
                uc.Name = i.id_ch.ToString();
                uc.Text = i.ten_ch.ToString();

                uc.AutoSize = false; //set k tự thay đổi kích thước

                uc.Size = new Size(600, 120);

                uc.Margin = new Padding(10); //set k/c

                li.Add(uc);
            }
            return li;
        }

        public CuocHop get_info_ch(String id_ch)
        {
            CuocHop p = dal.get_info_cuochop(id_ch);

            if (p == null) return null;
            return p;
        }

        public CuocHop get_info_ch_by_tenCH(String ten_ch)
        {
            CuocHop p = dal.get_info_cuochop_by_tenCH(ten_ch);

            if (p == null) return null;
            return p;
        }

        public void add_appoinment(CuocHop ch)
        {
            try
            {
                int loinhac = ch.loi_nhac.Value == true ? 1 : 0;
                string sql = @"INSERT INTO CuocHop (id_ch, ten_ch, dia_diem, tg_batdau, tg_ketthuc, id_host, loi_nhac)
                               VALUES (@id_ch, @ten_ch, @dia_diem, @tg_batdau, @tg_ketthuc, @id_host, @loi_nhac)";

                dal.sql_Appoinment(sql,
                    new SqlParameter("@id_ch", ch.id_ch),
                    new SqlParameter("@ten_ch", ch.ten_ch),
                    new SqlParameter("@dia_diem", ch.dia_diem),
                    new SqlParameter("@tg_batdau", ch.tg_batdau),
                    new SqlParameter("@tg_ketthuc", ch.tg_ketthuc),
                    new SqlParameter("@id_host", Login.id_nd),
                    new SqlParameter("@loi_nhac", loinhac)
                );

                dal.save_change(); // Thêm để đảm bảo lưu thay đổi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi add SQL: " + ex.Message);
            }
        }

        public String next_id_ch()
        {
            return "CH" + dal.next_idCH().ToString();
        }

        public void delete_appoinment(String id_ch)
        {
            try
            {
                string sql = $@"DELETE FROM CuocHop WHERE id_ch = '{id_ch}'";
                dal.sql_Appoinment(sql);
                dal.save_change(); // Thêm để đảm bảo lưu thay đổi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi delete SQL: " + ex.Message);
            }
        }

        public bool update_appoinment(String id_ch, String ten_ch, String dia_chi, DateTime start, DateTime end, Boolean reminder)
        {
            try
            {
                int reminderValue = reminder ? 1 : 0;
                string sql = @"UPDATE CuocHop
                       SET ten_ch = @ten_ch,
                           dia_diem = @dia_diem,
                           tg_batdau = @tg_batdau,
                           tg_ketthuc = @tg_ketthuc,
                           loi_nhac = @loi_nhac
                       WHERE id_ch = @id_ch";

                dal.sql_Appoinment(sql,
                    new SqlParameter("@ten_ch", ten_ch),
                    new SqlParameter("@dia_diem", dia_chi),
                    new SqlParameter("@tg_batdau", start),
                    new SqlParameter("@tg_ketthuc", end),
                    new SqlParameter("@loi_nhac", reminderValue),
                    new SqlParameter("@id_ch", id_ch)
                );
                dal.save_change(); // Lưu thay đổi
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi update SQL: " + ex.Message);
                return false;
            }
        }


        // Code test nhắc nhở lịch
        public void check_reminder()
        {
            try
            {
                var li = dal.show_appoinment().Where(p => p.loi_nhac == true).ToList();
                DateTime dt_now = DateTime.Now;

                //if(li.Count == 0)
                //{
                //    MessageBox.Show("Không có cuộc họp nào có nhắc nhở!");
                //    return;
                //}  

                foreach (var i in li)
                {
                    DateTime reminderTime = i.tg_batdau.Value.AddMinutes(-5);

                    //nằm trong vòng 15p thì nhắc nhở
                    if(dt_now >= reminderTime && dt_now <= i.tg_batdau.Value)
                    {
                        try
                        {
                            string soundPath = @"C:\Users\Lenovo\source\repos\OOAD_Main\OOAD_Main\Chuong.wav"; // Đường dẫn tuyệt đối
                            if (!File.Exists(soundPath))
                            {
                                MessageBox.Show($"Không tìm thấy file âm thanh: {soundPath}");
                                return;
                            }
                            SoundPlayer player = new SoundPlayer(soundPath);
                            player.Play();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi phát âm thanh: " + ex.Message);
                        }

                        MessageBox.Show(
                            "Bạn có cuộc họp: " + i.ten_ch.ToString() + "\n" +
                            "Địa điểm: " + i.dia_diem.ToString() + "\n" +
                            "Thời gian: " + i.tg_batdau.Value.ToString("dd/MM/yyyy HH:mm:ss") +
                            " đến " + i.tg_ketthuc.Value.ToString("dd/MM/yyyy HH:mm:ss") + "\n" +
                            "Người tổ chức: " + i.id_host.ToString() + "\n",
                            "Thông Báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

                        //Cập nhật lại
                        string sql = @"UPDATE CuocHop
                                       SET loi_nhac = 0
                                       WHERE id_ch = @id_ch";
                        dal.sql_Appoinment(sql, new SqlParameter("@id_ch", i.id_ch));
                        dal.save_change();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi check nhắc nhở: " + ex.Message);
            }
        }

        public void xuLy_CH_Nhom(CuocHop ch)
        {
            DialogResult rs = MessageBox.Show(
                            "Tên cuộc họp: " + ch.ten_ch.ToString() + "\n" +
                            "Địa điểm: " + ch.dia_diem.ToString() + "\n" +
                            "Thời gian: " + ch.tg_batdau.Value.ToString("dd/MM/yyyy HH:mm:ss") +
                            " đến " + ch.tg_ketthuc.Value.ToString("dd/MM/yyyy HH:mm:ss") + "\n" +
                            "Người tổ chức: " + ch.id_host.ToString() + "\n",
                            "Thông Báo Tham Gia Cuộc Họp!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information
                            );
            if(rs == DialogResult.Yes)
            {
                bool alreadyJoined = dal.da_thamGia(ch.id_ch, Login.id_nd);
                Console.WriteLine("Người dùng đã tham gia cuộc họp này?: " + alreadyJoined);

                if(dal.isHost(ch.id_ch, Login.id_nd))
                {
                    MessageBox.Show(
                        "Bạn không thể tham gia cuộc họp này vì bạn là người tổ chức!",
                        "Thông Báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (alreadyJoined)
                {
                    MessageBox.Show("Bạn đã tham gia cuộc họp này rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Tham gia cuộc họp
                MessageBox.Show(
                    "Bạn đã tham gia cuộc họp thành công!",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                // Cập nhật lại thông tin cuộc họp
                string sql = @"INSERT INTO NguoiDung_CuocHop (id_ch, id)
                               VALUES (@id_ch, @id)";
                dal.sql_Appoinment(sql, 
                    new SqlParameter("@id_ch", ch.id_ch), 
                    new SqlParameter("@id", Login.id_nd));
                dal.save_change();
            }
            else
            {
                // Không tham gia cuộc họp
                MessageBox.Show(
                    "Bạn đã từ chối tham gia cuộc họp!",
                    "Thông Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        public Boolean xuLy_tgCH(CuocHop ch)
        {
            List<CuocHop> ds_ch = dal.show_appoinment();

            foreach (var i in ds_ch)
            {
                if (ch.tg_batdau.Value < i.tg_ketthuc.Value && ch.tg_ketthuc.Value > i.tg_batdau.Value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
