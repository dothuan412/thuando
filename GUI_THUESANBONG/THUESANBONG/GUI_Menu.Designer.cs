
namespace THUESANBONG
{
    partial class GUI_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSodosanbong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanlithuesanbong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuesanbong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhsachthuesanbong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLichsuthuesanbong = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuSodosanbong,
            this.mnuQuanlithuesanbong,
            this.mnuLichsuthuesanbong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangnhap,
            this.mnuDangxuat,
            this.mnuThoat});
            this.mnuSystem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSystem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(77, 25);
            this.mnuSystem.Text = "System";
            this.mnuSystem.Click += new System.EventHandler(this.mnuSystem_Click);
            // 
            // mnuDangnhap
            // 
            this.mnuDangnhap.Name = "mnuDangnhap";
            this.mnuDangnhap.Size = new System.Drawing.Size(164, 26);
            this.mnuDangnhap.Text = "Đăng nhập";
            this.mnuDangnhap.Click += new System.EventHandler(this.mnuDangnhap_Click);
            // 
            // mnuDangxuat
            // 
            this.mnuDangxuat.Name = "mnuDangxuat";
            this.mnuDangxuat.Size = new System.Drawing.Size(164, 26);
            this.mnuDangxuat.Text = "Đăng xuất";
            this.mnuDangxuat.Click += new System.EventHandler(this.mnuDangxuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(164, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuSodosanbong
            // 
            this.mnuSodosanbong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSodosanbong.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mnuSodosanbong.Name = "mnuSodosanbong";
            this.mnuSodosanbong.Size = new System.Drawing.Size(139, 25);
            this.mnuSodosanbong.Text = "Sơ đồ sân bóng";
            this.mnuSodosanbong.Click += new System.EventHandler(this.mnuSodosanbong_Click);
            // 
            // mnuQuanlithuesanbong
            // 
            this.mnuQuanlithuesanbong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThuesanbong,
            this.mnuDanhsachthuesanbong});
            this.mnuQuanlithuesanbong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQuanlithuesanbong.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mnuQuanlithuesanbong.Name = "mnuQuanlithuesanbong";
            this.mnuQuanlithuesanbong.Size = new System.Drawing.Size(190, 25);
            this.mnuQuanlithuesanbong.Text = "Quản lí thuê sân bóng";
            // 
            // mnuThuesanbong
            // 
            this.mnuThuesanbong.Name = "mnuThuesanbong";
            this.mnuThuesanbong.Size = new System.Drawing.Size(272, 26);
            this.mnuThuesanbong.Text = "Thuê sân bóng";
            this.mnuThuesanbong.Click += new System.EventHandler(this.mnuThuesanbong_Click);
            // 
            // mnuDanhsachthuesanbong
            // 
            this.mnuDanhsachthuesanbong.Name = "mnuDanhsachthuesanbong";
            this.mnuDanhsachthuesanbong.Size = new System.Drawing.Size(272, 26);
            this.mnuDanhsachthuesanbong.Text = "Danh sách thuê sân bóng";
            this.mnuDanhsachthuesanbong.Click += new System.EventHandler(this.mnuTrasan_Click);
            // 
            // mnuLichsuthuesanbong
            // 
            this.mnuLichsuthuesanbong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuLichsuthuesanbong.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mnuLichsuthuesanbong.Name = "mnuLichsuthuesanbong";
            this.mnuLichsuthuesanbong.Size = new System.Drawing.Size(188, 25);
            this.mnuLichsuthuesanbong.Text = "Lịch sử thuê sân bóng";
            this.mnuLichsuthuesanbong.Click += new System.EventHandler(this.mnuLichsuthuesanbong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 423);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(143, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ SÂN BÓNG";
            // 
            // GUI_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "GUI_Menu";
            this.Text = "GUI_Menu";
            this.Activated += new System.EventHandler(this.GUI_Menu_Activated);
            this.Load += new System.EventHandler(this.GUI_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuDangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuSodosanbong;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanlithuesanbong;
        private System.Windows.Forms.ToolStripMenuItem mnuThuesanbong;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhsachthuesanbong;
        private System.Windows.Forms.ToolStripMenuItem mnuLichsuthuesanbong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}