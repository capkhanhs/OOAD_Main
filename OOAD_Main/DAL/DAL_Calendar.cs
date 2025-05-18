using OOAD_Main.DTO;
using System.Data.SqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD_Main.DAL
{
    public class DAL_Calendar
    {
        private calendarConText db = new calendarConText();

        public List<NguoiDung> getAll_NguoiDung()
        {
            List<NguoiDung> li = new List<NguoiDung>();

            li.AddRange(db.NguoiDungs.ToList());

            return li;
        }

        public List<CuocHop> show_appoinment()
        {
            refresh_conection();
            refresh_entities();

            List<CuocHop> li = new List<CuocHop>();
            DateTime dt_now = DateTime.Now;

            var ds_ch = db.CuocHops
                .Where(ch => (ch.id_host == Login.id_nd || ch.NguoiDungs.Any(nd => nd.id == Login.id_nd))
                && ch.tg_ketthuc > dt_now)
                .Select(ch => ch)
                .ToList();

            li = ds_ch;
            return li;
        }

        public void sql_Appoinment(string sql, params object[] parameters)
        {
            try
            {
                db.Database.ExecuteSqlCommand(sql, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi SQL: " + ex.Message);
            }
        }

        public int next_idCH()
        {
            refresh_conection();

            var maxID = db.CuocHops.Select(p => p.id_ch).OrderByDescending(id => id).FirstOrDefault();
            int nextID = 1; //nếu chưa có cuộc họp nào
            if (maxID != null)
            {
                nextID = int.Parse(maxID.Substring(2)) + 1;
            }
            return nextID;
        }

        public int count_appoinment()
        {

            refresh_conection();

            int count = db.CuocHops
                .Where(ch => ch.id_host == Login.id_nd || ch.NguoiDungs.Any(nd => nd.id == Login.id_nd))
                .Count();
            return count;
        }

        public CuocHop get_info_cuochop(String id_ch)
        {
            refresh_conection();

            return db.CuocHops
                .Where(c => c.id_ch == id_ch)
                .FirstOrDefault();
        }

        public CuocHop get_info_cuochop_by_tenCH(String ten_ch)
        {
            refresh_conection();

            ten_ch = ten_ch.Trim();
            return db.CuocHops
                .Where(c => c.ten_ch == ten_ch)
                .FirstOrDefault();
        }

        public void save_change()
        {
            using (var transaction = db.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                try
                {
                    db.SaveChanges();
                    transaction.Commit();

                    refresh_conection();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi thực thi SQL: " + ex.Message);
                    throw;
                }
            }
        }

        public void refresh_conection()
        {
            //db.Database.Connection.Close();
            //db.Database.Connection.Open();
            db.Dispose();
            db = new calendarConText();
        }

        public void refresh_entities() // reload loại các thực thể 
        {
            foreach (var entity in db.ChangeTracker.Entries())
            {
                entity.Reload(); // Tải lại dữ liệu từ cơ sở dữ liệu
            }
        }

        //kiểm tra xem người dùng đã tham gia cuộc họp hay chưa
        public bool da_thamGia(String id_ch, String id)
        {
            try
            {
                string sql = @"SELECT COUNT(*)
                   FROM NguoiDung_CuocHop   
                   WHERE id_ch = @id_ch AND id = @id";

                int count = db.Database.SqlQuery<int>(sql,
                    new SqlParameter("@id_ch", id_ch),
                    new SqlParameter("@id", id)).Single();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra tham gia: " + ex.Message);
                return false;
            }
        }

        public bool isHost(String id_ch, String id)
        {
            try
            {
                string sql = @"SELECT COUNT(*)
                   FROM CuocHop   
                   WHERE id_ch = @id_ch AND id_host = @id";
                int count = db.Database.SqlQuery<int>(sql,
                    new SqlParameter("@id_ch", id_ch),
                    new SqlParameter("@id", id)).Single();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra host: " + ex.Message);
                return false;
            }
        }
    }
}
