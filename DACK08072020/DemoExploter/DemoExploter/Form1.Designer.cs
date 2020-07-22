namespace DemoExploter
{
    partial class Form1
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
            this.grvQuanLy = new System.Windows.Forms.DataGridView();
            this.rtbCauHoi = new System.Windows.Forms.RichTextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pnlCacChonLua = new System.Windows.Forms.Panel();
            this.btnThemLuaChon = new System.Windows.Forms.Button();
            this.btnChuyenCauHoi = new System.Windows.Forms.Button();
            this.btnKhoiDongServer = new System.Windows.Forms.Button();
            this.ucCauTraLoiA = new DemoExploter.ucCauTraLoi();
            this.ucCauTraLoiB = new DemoExploter.ucCauTraLoi();
            this.btnDemoThread = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuanLy)).BeginInit();
            this.pnlCacChonLua.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvQuanLy
            // 
            this.grvQuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvQuanLy.Location = new System.Drawing.Point(13, 410);
            this.grvQuanLy.Name = "grvQuanLy";
            this.grvQuanLy.Size = new System.Drawing.Size(1081, 322);
            this.grvQuanLy.TabIndex = 0;
            // 
            // rtbCauHoi
            // 
            this.rtbCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCauHoi.Location = new System.Drawing.Point(12, 13);
            this.rtbCauHoi.Name = "rtbCauHoi";
            this.rtbCauHoi.Size = new System.Drawing.Size(1081, 93);
            this.rtbCauHoi.TabIndex = 1;
            this.rtbCauHoi.Text = "";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 370);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(202, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(447, 370);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(202, 23);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(891, 370);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(202, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // pnlCacChonLua
            // 
            this.pnlCacChonLua.AutoScroll = true;
            this.pnlCacChonLua.Controls.Add(this.ucCauTraLoiA);
            this.pnlCacChonLua.Controls.Add(this.ucCauTraLoiB);
            this.pnlCacChonLua.Location = new System.Drawing.Point(12, 112);
            this.pnlCacChonLua.Name = "pnlCacChonLua";
            this.pnlCacChonLua.Size = new System.Drawing.Size(530, 251);
            this.pnlCacChonLua.TabIndex = 13;
            // 
            // btnThemLuaChon
            // 
            this.btnThemLuaChon.Location = new System.Drawing.Point(572, 113);
            this.btnThemLuaChon.Name = "btnThemLuaChon";
            this.btnThemLuaChon.Size = new System.Drawing.Size(178, 36);
            this.btnThemLuaChon.TabIndex = 14;
            this.btnThemLuaChon.Text = "Thêm Lựa Chọn";
            this.btnThemLuaChon.UseVisualStyleBackColor = true;
            this.btnThemLuaChon.Click += new System.EventHandler(this.btnThemLuaChon_Click);
            // 
            // btnChuyenCauHoi
            // 
            this.btnChuyenCauHoi.Location = new System.Drawing.Point(576, 232);
            this.btnChuyenCauHoi.Name = "btnChuyenCauHoi";
            this.btnChuyenCauHoi.Size = new System.Drawing.Size(176, 42);
            this.btnChuyenCauHoi.TabIndex = 15;
            this.btnChuyenCauHoi.Text = "Chuyển Câu Hỏi";
            this.btnChuyenCauHoi.UseVisualStyleBackColor = true;
            this.btnChuyenCauHoi.Click += new System.EventHandler(this.btnChuyenCauHoi_Click);
            // 
            // btnKhoiDongServer
            // 
            this.btnKhoiDongServer.Location = new System.Drawing.Point(574, 166);
            this.btnKhoiDongServer.Name = "btnKhoiDongServer";
            this.btnKhoiDongServer.Size = new System.Drawing.Size(178, 48);
            this.btnKhoiDongServer.TabIndex = 16;
            this.btnKhoiDongServer.Text = "Khởi động Server";
            this.btnKhoiDongServer.UseVisualStyleBackColor = true;
            this.btnKhoiDongServer.Click += new System.EventHandler(this.btnKhoiDongServer_Click);
            // 
            // ucCauTraLoiA
            // 
            this.ucCauTraLoiA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucCauTraLoiA.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucCauTraLoiA.LaCauTraLoi = false;
            this.ucCauTraLoiA.Location = new System.Drawing.Point(0, 45);
            this.ucCauTraLoiA.Name = "ucCauTraLoiA";
            this.ucCauTraLoiA.NoiDung = "";
            this.ucCauTraLoiA.Size = new System.Drawing.Size(530, 45);
            this.ucCauTraLoiA.TabIndex = 11;
            this.ucCauTraLoiA.TieuDe = "1";
            // 
            // ucCauTraLoiB
            // 
            this.ucCauTraLoiB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucCauTraLoiB.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucCauTraLoiB.LaCauTraLoi = false;
            this.ucCauTraLoiB.Location = new System.Drawing.Point(0, 0);
            this.ucCauTraLoiB.Name = "ucCauTraLoiB";
            this.ucCauTraLoiB.NoiDung = "";
            this.ucCauTraLoiB.Size = new System.Drawing.Size(530, 45);
            this.ucCauTraLoiB.TabIndex = 12;
            this.ucCauTraLoiB.TieuDe = "2";
            // 
            // btnDemoThread
            // 
            this.btnDemoThread.Location = new System.Drawing.Point(783, 113);
            this.btnDemoThread.Name = "btnDemoThread";
            this.btnDemoThread.Size = new System.Drawing.Size(193, 44);
            this.btnDemoThread.TabIndex = 17;
            this.btnDemoThread.Text = "Demo Thread";
            this.btnDemoThread.UseVisualStyleBackColor = true;
            this.btnDemoThread.Click += new System.EventHandler(this.btnDemoThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 744);
            this.Controls.Add(this.btnDemoThread);
            this.Controls.Add(this.btnKhoiDongServer);
            this.Controls.Add(this.btnChuyenCauHoi);
            this.Controls.Add(this.btnThemLuaChon);
            this.Controls.Add(this.pnlCacChonLua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rtbCauHoi);
            this.Controls.Add(this.grvQuanLy);
            this.Name = "Form1";
            this.Text = "Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvQuanLy)).EndInit();
            this.pnlCacChonLua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvQuanLy;
        private System.Windows.Forms.RichTextBox rtbCauHoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private ucCauTraLoi ucCauTraLoiA;
        private ucCauTraLoi ucCauTraLoiB;
        private System.Windows.Forms.Panel pnlCacChonLua;
        private System.Windows.Forms.Button btnThemLuaChon;
        private System.Windows.Forms.Button btnChuyenCauHoi;
        private System.Windows.Forms.Button btnKhoiDongServer;
        private System.Windows.Forms.Button btnDemoThread;
    }
}

