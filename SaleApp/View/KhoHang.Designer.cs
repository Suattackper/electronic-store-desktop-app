namespace SaleApp.View
{
    partial class frmKhoHang
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tHangTon = new System.Windows.Forms.TabPage();
            this.tNhapKho = new System.Windows.Forms.TabPage();
            this.tXuatKho = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tHangTon);
            this.tabControl1.Controls.Add(this.tNhapKho);
            this.tabControl1.Controls.Add(this.tXuatKho);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1167, 773);
            this.tabControl1.TabIndex = 0;
            // 
            // tHangTon
            // 
            this.tHangTon.Location = new System.Drawing.Point(4, 29);
            this.tHangTon.Name = "tHangTon";
            this.tHangTon.Padding = new System.Windows.Forms.Padding(3);
            this.tHangTon.Size = new System.Drawing.Size(1159, 740);
            this.tHangTon.TabIndex = 0;
            this.tHangTon.Text = "Hàng tồn";
            this.tHangTon.UseVisualStyleBackColor = true;
            // 
            // tNhapKho
            // 
            this.tNhapKho.Location = new System.Drawing.Point(4, 29);
            this.tNhapKho.Name = "tNhapKho";
            this.tNhapKho.Padding = new System.Windows.Forms.Padding(3);
            this.tNhapKho.Size = new System.Drawing.Size(1186, 793);
            this.tNhapKho.TabIndex = 1;
            this.tNhapKho.Text = "Nhập kho";
            this.tNhapKho.UseVisualStyleBackColor = true;
            // 
            // tXuatKho
            // 
            this.tXuatKho.Location = new System.Drawing.Point(4, 29);
            this.tXuatKho.Name = "tXuatKho";
            this.tXuatKho.Padding = new System.Windows.Forms.Padding(3);
            this.tXuatKho.Size = new System.Drawing.Size(1186, 793);
            this.tXuatKho.TabIndex = 2;
            this.tXuatKho.Text = "Xuất kho";
            this.tXuatKho.UseVisualStyleBackColor = true;
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 770);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhoHang";
            this.Text = "KhoHang";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tHangTon;
        private TabPage tNhapKho;
        private TabPage tXuatKho;
    }
}