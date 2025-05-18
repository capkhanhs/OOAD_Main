namespace OOAD_Main.VIEW
{
    partial class AppEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_reminder = new System.Windows.Forms.CheckBox();
            this.lb_date = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_dd = new System.Windows.Forms.TextBox();
            this.lb_dd = new System.Windows.Forms.Label();
            this.txt_tenCH = new System.Windows.Forms.TextBox();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.lb_end = new System.Windows.Forms.Label();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.lb_start = new System.Windows.Forms.Label();
            this.lb_tenCH = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_reminder
            // 
            this.cb_reminder.AutoSize = true;
            this.cb_reminder.BackColor = System.Drawing.Color.Transparent;
            this.cb_reminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_reminder.Location = new System.Drawing.Point(556, 324);
            this.cb_reminder.Name = "cb_reminder";
            this.cb_reminder.Size = new System.Drawing.Size(121, 29);
            this.cb_reminder.TabIndex = 23;
            this.cb_reminder.Text = "Reminder";
            this.cb_reminder.UseVisualStyleBackColor = false;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.BackColor = System.Drawing.Color.Transparent;
            this.lb_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(535, 58);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(39, 27);
            this.lb_date.TabIndex = 22;
            this.lb_date.Text = ".....";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(503, 359);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 35);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(180, 359);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(110, 35);
            this.btn_ok.TabIndex = 20;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_dd
            // 
            this.txt_dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dd.Location = new System.Drawing.Point(376, 288);
            this.txt_dd.Name = "txt_dd";
            this.txt_dd.Size = new System.Drawing.Size(301, 30);
            this.txt_dd.TabIndex = 19;
            // 
            // lb_dd
            // 
            this.lb_dd.AutoSize = true;
            this.lb_dd.BackColor = System.Drawing.Color.Transparent;
            this.lb_dd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_dd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dd.Location = new System.Drawing.Point(128, 293);
            this.lb_dd.Name = "lb_dd";
            this.lb_dd.Size = new System.Drawing.Size(93, 27);
            this.lb_dd.TabIndex = 18;
            this.lb_dd.Text = "Địa Điểm";
            // 
            // txt_tenCH
            // 
            this.txt_tenCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenCH.Location = new System.Drawing.Point(376, 107);
            this.txt_tenCH.Name = "txt_tenCH";
            this.txt_tenCH.ReadOnly = true;
            this.txt_tenCH.Size = new System.Drawing.Size(301, 30);
            this.txt_tenCH.TabIndex = 17;
            // 
            // dt_end
            // 
            this.dt_end.CustomFormat = "hh:mm tt";
            this.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_end.Location = new System.Drawing.Point(376, 231);
            this.dt_end.Name = "dt_end";
            this.dt_end.ShowUpDown = true;
            this.dt_end.Size = new System.Drawing.Size(301, 26);
            this.dt_end.TabIndex = 16;
            // 
            // lb_end
            // 
            this.lb_end.AutoSize = true;
            this.lb_end.BackColor = System.Drawing.Color.Transparent;
            this.lb_end.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_end.Location = new System.Drawing.Point(128, 232);
            this.lb_end.Name = "lb_end";
            this.lb_end.Size = new System.Drawing.Size(184, 27);
            this.lb_end.TabIndex = 15;
            this.lb_end.Text = "Thời Gian Kết Thúc";
            // 
            // dt_start
            // 
            this.dt_start.CustomFormat = "hh:mm tt";
            this.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_start.Location = new System.Drawing.Point(376, 166);
            this.dt_start.Name = "dt_start";
            this.dt_start.ShowUpDown = true;
            this.dt_start.Size = new System.Drawing.Size(301, 26);
            this.dt_start.TabIndex = 14;
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.BackColor = System.Drawing.Color.Transparent;
            this.lb_start.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_start.Location = new System.Drawing.Point(128, 167);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(174, 27);
            this.lb_start.TabIndex = 13;
            this.lb_start.Text = "Thời Gian Bắt Đầu";
            // 
            // lb_tenCH
            // 
            this.lb_tenCH.AutoSize = true;
            this.lb_tenCH.BackColor = System.Drawing.Color.Transparent;
            this.lb_tenCH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_tenCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenCH.Location = new System.Drawing.Point(128, 110);
            this.lb_tenCH.Name = "lb_tenCH";
            this.lb_tenCH.Size = new System.Drawing.Size(142, 27);
            this.lb_tenCH.TabIndex = 12;
            this.lb_tenCH.Text = "Tên Cuộc Họp";
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.Transparent;
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Location = new System.Drawing.Point(339, 359);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(116, 35);
            this.btn_huy.TabIndex = 24;
            this.btn_huy.Text = "Hủy CH";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // App2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOAD_Main.Properties.Resources.BG_App;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(805, 453);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.cb_reminder);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_dd);
            this.Controls.Add(this.lb_dd);
            this.Controls.Add(this.txt_tenCH);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.lb_end);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.lb_start);
            this.Controls.Add(this.lb_tenCH);
            this.Name = "App2";
            this.Text = "Appoinment Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_reminder;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_dd;
        private System.Windows.Forms.Label lb_dd;
        private System.Windows.Forms.TextBox txt_tenCH;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.Label lb_end;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lb_tenCH;
        private System.Windows.Forms.Button btn_huy;
    }
}