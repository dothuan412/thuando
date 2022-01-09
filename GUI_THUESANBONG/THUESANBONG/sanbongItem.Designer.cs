
namespace THUESANBONG
{
    partial class sanbongItem
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
            this.lblTensanbong = new System.Windows.Forms.Label();
            this.lblloaisanbong = new System.Windows.Forms.Label();
            this.lblMasanbong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).BeginInit();
            this.SuspendLayout();
            // 
            // anh
            // 
            this.anh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.anh.Location = new System.Drawing.Point(0, 0);
            this.anh.Margin = new System.Windows.Forms.Padding(2);
            this.anh.Name = "anh";
            this.anh.Size = new System.Drawing.Size(148, 82);
            this.anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anh.TabIndex = 1;
            this.anh.TabStop = false;
            // 
            // lblTensanbong
            // 
            this.lblTensanbong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTensanbong.AutoSize = true;
            this.lblTensanbong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensanbong.Location = new System.Drawing.Point(31, 116);
            this.lblTensanbong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTensanbong.Name = "lblTensanbong";
            this.lblTensanbong.Size = new System.Drawing.Size(64, 22);
            this.lblTensanbong.TabIndex = 3;
            this.lblTensanbong.Text = "label2";
            this.lblTensanbong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblloaisanbong
            // 
            this.lblloaisanbong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblloaisanbong.AutoSize = true;
            this.lblloaisanbong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloaisanbong.ForeColor = System.Drawing.Color.Red;
            this.lblloaisanbong.Location = new System.Drawing.Point(31, 94);
            this.lblloaisanbong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblloaisanbong.Name = "lblloaisanbong";
            this.lblloaisanbong.Size = new System.Drawing.Size(58, 22);
            this.lblloaisanbong.TabIndex = 4;
            this.lblloaisanbong.Text = "label1";
            this.lblloaisanbong.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblloaisanbong.Click += new System.EventHandler(this.lblloaisanbong_Click_1);
            // 
            // lblMasanbong
            // 
            this.lblMasanbong.AutoSize = true;
            this.lblMasanbong.Location = new System.Drawing.Point(2, 137);
            this.lblMasanbong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMasanbong.Name = "lblMasanbong";
            this.lblMasanbong.Size = new System.Drawing.Size(35, 13);
            this.lblMasanbong.TabIndex = 5;
            this.lblMasanbong.Text = "label1";
            this.lblMasanbong.Visible = false;
            // 
            // sanbongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMasanbong);
            this.Controls.Add(this.lblloaisanbong);
            this.Controls.Add(this.lblTensanbong);
            this.Controls.Add(this.anh);
            this.Name = "sanbongItem";
            ((System.ComponentModel.ISupportInitialize)(this.anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.PictureBox anh;
        private System.Windows.Forms.Label lblTensanbong;
        private System.Windows.Forms.Label lblloaisanbong;
        private System.Windows.Forms.Label lblMasanbong;
    }
}
