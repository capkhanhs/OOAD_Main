namespace OOAD_Main
{
    partial class Main
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
            this.date = new System.Windows.Forms.MonthCalendar();
            this.pic_at = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ch = new System.Windows.Forms.Label();
            this.pn_ch = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_at)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(215, 5);
            this.date.Margin = new System.Windows.Forms.Padding(14);
            this.date.Name = "date";
            this.date.TabIndex = 0;
            // 
            // pic_at
            // 
            this.pic_at.BackColor = System.Drawing.Color.Transparent;
            this.pic_at.BackgroundImage = global::OOAD_Main.Properties.Resources.AtTy;
            this.pic_at.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_at.Location = new System.Drawing.Point(13, 5);
            this.pic_at.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_at.Name = "pic_at";
            this.pic_at.Size = new System.Drawing.Size(198, 280);
            this.pic_at.TabIndex = 1;
            this.pic_at.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Gold;
            this.btn_add.BackgroundImage = global::OOAD_Main.Properties.Resources.Plus;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add.Location = new System.Drawing.Point(570, 14);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(45, 46);
            this.btn_add.TabIndex = 2;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Appoinment";
            // 
            // lb_ch
            // 
            this.lb_ch.AutoSize = true;
            this.lb_ch.BackColor = System.Drawing.Color.Transparent;
            this.lb_ch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ch.Location = new System.Drawing.Point(856, 260);
            this.lb_ch.Name = "lb_ch";
            this.lb_ch.Size = new System.Drawing.Size(108, 25);
            this.lb_ch.TabIndex = 6;
            this.lb_ch.Text = "Cuộc Họp";
            // 
            // pn_ch
            // 
            this.pn_ch.BackColor = System.Drawing.Color.Transparent;
            this.pn_ch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_ch.Location = new System.Drawing.Point(12, 293);
            this.pn_ch.Name = "pn_ch";
            this.pn_ch.Size = new System.Drawing.Size(952, 344);
            this.pn_ch.TabIndex = 7;
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.Color.Gold;
            this.btn_reload.BackgroundImage = global::OOAD_Main.Properties.Resources.Reload;
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reload.Location = new System.Drawing.Point(804, 239);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(45, 46);
            this.btn_reload.TabIndex = 8;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOAD_Main.Properties.Resources.BG_Main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(976, 649);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.pn_ch);
            this.Controls.Add(this.lb_ch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_at);
            this.Controls.Add(this.date);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_at)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar date;
        private System.Windows.Forms.PictureBox pic_at;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ch;
        private System.Windows.Forms.FlowLayoutPanel pn_ch;
        private System.Windows.Forms.Button btn_reload;
    }
}

