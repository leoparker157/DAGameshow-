namespace DemoExploter
{
    partial class frmGameShow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameShow));
            this.grvGameShow = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLich = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LbTime = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnConnectServer = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.tbSetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvGameShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvGameShow
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.grvGameShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.grvGameShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.grvGameShow.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grvGameShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGameShow.GridColor = System.Drawing.SystemColors.Highlight;
            this.grvGameShow.Location = new System.Drawing.Point(112, 315);
            this.grvGameShow.Name = "grvGameShow";
            this.grvGameShow.RowHeadersVisible = false;
            this.grvGameShow.Size = new System.Drawing.Size(308, 96);
            this.grvGameShow.TabIndex = 0;
            this.grvGameShow.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblName.Location = new System.Drawing.Point(342, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "#Name";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(342, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "#Time";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::DemoExploter.Properties.Resources.start;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(142, 473);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(225, 80);
            this.btnStart.TabIndex = 4;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLich
            // 
            this.btnLich.BackColor = System.Drawing.Color.Transparent;
            this.btnLich.BackgroundImage = global::DemoExploter.Properties.Resources.schedule;
            this.btnLich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLich.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLich.ForeColor = System.Drawing.Color.Black;
            this.btnLich.Location = new System.Drawing.Point(126, 392);
            this.btnLich.Name = "btnLich";
            this.btnLich.Size = new System.Drawing.Size(258, 71);
            this.btnLich.TabIndex = 5;
            this.btnLich.UseVisualStyleBackColor = false;
            this.btnLich.Click += new System.EventHandler(this.btnLich_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 130);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.BackColor = System.Drawing.Color.Transparent;
            this.LbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LbTime.Location = new System.Drawing.Point(465, 12);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(0, 16);
            this.LbTime.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::DemoExploter.Properties.Resources.go_back_icon;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 29);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "\r\n";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = global::DemoExploter.Properties.Resources.quit;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuit.Location = new System.Drawing.Point(168, 559);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(179, 58);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnConnectServer
            // 
            this.btnConnectServer.BackColor = System.Drawing.Color.Transparent;
            this.btnConnectServer.BackgroundImage = global::DemoExploter.Properties.Resources.connect;
            this.btnConnectServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnectServer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConnectServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnConnectServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectServer.Location = new System.Drawing.Point(126, 254);
            this.btnConnectServer.Name = "btnConnectServer";
            this.btnConnectServer.Size = new System.Drawing.Size(273, 55);
            this.btnConnectServer.TabIndex = 10;
            this.btnConnectServer.UseVisualStyleBackColor = false;
            this.btnConnectServer.Click += new System.EventHandler(this.btnConnectServer_Click);
            // 
            // btnName
            // 
            this.btnName.BackColor = System.Drawing.Color.Transparent;
            this.btnName.BackgroundImage = global::DemoExploter.Properties.Resources.cooltext358832290952836;
            this.btnName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName.ForeColor = System.Drawing.Color.Transparent;
            this.btnName.Location = new System.Drawing.Point(168, 314);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(179, 55);
            this.btnName.TabIndex = 11;
            this.btnName.UseVisualStyleBackColor = false;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // tbSetName
            // 
            this.tbSetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSetName.Location = new System.Drawing.Point(142, 376);
            this.tbSetName.Name = "tbSetName";
            this.tbSetName.Size = new System.Drawing.Size(225, 35);
            this.tbSetName.TabIndex = 12;
            this.tbSetName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Set Name";
            this.label1.Visible = false;
            // 
            // frmGameShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(524, 706);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnConnectServer);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.LbTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLich);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grvGameShow);
            this.Controls.Add(this.tbSetName);
            this.Controls.Add(this.label1);
            this.Name = "frmGameShow";
            this.Text = "frmGameShow";
            this.Load += new System.EventHandler(this.frmGameShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvGameShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvGameShow;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLich;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnConnectServer;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox tbSetName;
        private System.Windows.Forms.Label label1;
    }
}