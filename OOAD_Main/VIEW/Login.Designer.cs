namespace OOAD_Main
{
    partial class Login
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
            this.pic_bg = new System.Windows.Forms.PictureBox();
            this.pic_tk = new System.Windows.Forms.PictureBox();
            this.pic_mk = new System.Windows.Forms.PictureBox();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.btn_dn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mk)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_bg
            // 
            this.pic_bg.BackColor = System.Drawing.Color.Transparent;
            this.pic_bg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_bg.Location = new System.Drawing.Point(242, 42);
            this.pic_bg.Name = "pic_bg";
            this.pic_bg.Size = new System.Drawing.Size(184, 126);
            this.pic_bg.TabIndex = 0;
            this.pic_bg.TabStop = false;
            // 
            // pic_tk
            // 
            this.pic_tk.BackColor = System.Drawing.Color.Transparent;
            this.pic_tk.BackgroundImage = global::OOAD_Main.Properties.Resources.AC;
            this.pic_tk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_tk.Location = new System.Drawing.Point(256, 55);
            this.pic_tk.Name = "pic_tk";
            this.pic_tk.Size = new System.Drawing.Size(30, 30);
            this.pic_tk.TabIndex = 1;
            this.pic_tk.TabStop = false;
            // 
            // pic_mk
            // 
            this.pic_mk.BackColor = System.Drawing.Color.Transparent;
            this.pic_mk.BackgroundImage = global::OOAD_Main.Properties.Resources.PW;
            this.pic_mk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_mk.Location = new System.Drawing.Point(256, 91);
            this.pic_mk.Name = "pic_mk";
            this.pic_mk.Size = new System.Drawing.Size(30, 30);
            this.pic_mk.TabIndex = 2;
            this.pic_mk.TabStop = false;
            // 
            // txt_tk
            // 
            this.txt_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(292, 59);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(123, 26);
            this.txt_tk.TabIndex = 3;
            this.txt_tk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_mk
            // 
            this.txt_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk.Location = new System.Drawing.Point(292, 95);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Size = new System.Drawing.Size(123, 26);
            this.txt_mk.TabIndex = 4;
            this.txt_mk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btn_dn
            // 
            this.btn_dn.Image = global::OOAD_Main.Properties.Resources.Login3;
            this.btn_dn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dn.Location = new System.Drawing.Point(303, 127);
            this.btn_dn.Name = "btn_dn";
            this.btn_dn.Size = new System.Drawing.Size(94, 31);
            this.btn_dn.TabIndex = 5;
            this.btn_dn.Text = "Đăng Nhập";
            this.btn_dn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dn.UseVisualStyleBackColor = true;
            this.btn_dn.Click += new System.EventHandler(this.btn_dn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOAD_Main.Properties.Resources.BG3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(438, 180);
            this.Controls.Add(this.btn_dn);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.pic_mk);
            this.Controls.Add(this.pic_tk);
            this.Controls.Add(this.pic_bg);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_bg;
        private System.Windows.Forms.PictureBox pic_tk;
        private System.Windows.Forms.PictureBox pic_mk;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Button btn_dn;
    }
}