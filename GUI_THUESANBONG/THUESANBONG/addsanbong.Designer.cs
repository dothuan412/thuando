
namespace THUESANBONG
{
    partial class addsanbong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.anh = new System.Windows.Forms.PictureBox();
            this.lblKhuvuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).BeginInit();
            this.SuspendLayout();
            // 
            // anh
            // 
            this.anh.Location = new System.Drawing.Point(0, 2);
            this.anh.Margin = new System.Windows.Forms.Padding(2);
            this.anh.Name = "anh";
            this.anh.Size = new System.Drawing.Size(148, 146);
            this.anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anh.TabIndex = 1;
            this.anh.TabStop = false;
            this.anh.Click += new System.EventHandler(this.anh_Click);
            // 
            // lblKhuvuc
            // 
            this.lblKhuvuc.AutoSize = true;
            this.lblKhuvuc.Location = new System.Drawing.Point(50, 61);
            this.lblKhuvuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhuvuc.Name = "lblKhuvuc";
            this.lblKhuvuc.Size = new System.Drawing.Size(35, 13);
            this.lblKhuvuc.TabIndex = 2;
            this.lblKhuvuc.Text = "label1";
            this.lblKhuvuc.Visible = false;
            // 
            // addsanbong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblKhuvuc);
            this.Controls.Add(this.anh);
            this.Name = "addsanbong";
            ((System.ComponentModel.ISupportInitialize)(this.anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox anh;
        private System.Windows.Forms.Label lblKhuvuc;
    }
}
