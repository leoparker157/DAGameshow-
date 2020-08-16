namespace DemoExploter
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.RTBChatClient = new System.Windows.Forms.RichTextBox();
            this.btnChoose1 = new System.Windows.Forms.Button();
            this.btnChoose2 = new System.Windows.Forms.Button();
            this.btnChoose3 = new System.Windows.Forms.Button();
            this.btnChoose4 = new System.Windows.Forms.Button();
            this.PnBeforeGame = new System.Windows.Forms.Panel();
            this.lbBeforeGameTime = new System.Windows.Forms.Label();
            this.PnGame = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPoint = new System.Windows.Forms.Label();
            this.lbTimelimit = new System.Windows.Forms.Label();
            this.lbCountDownGame = new System.Windows.Forms.Label();
            this.TBChatClient = new System.Windows.Forms.TextBox();
            this.btnBeforeGameSend = new System.Windows.Forms.Button();
            this.PnEndGame = new System.Windows.Forms.Panel();
            this.btnRanking = new System.Windows.Forms.Button();
            this.PBGameOver = new System.Windows.Forms.PictureBox();
            this.PBPoint = new System.Windows.Forms.PictureBox();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.PnRanking = new System.Windows.Forms.Panel();
            this.RTBRanking = new System.Windows.Forms.RichTextBox();
            this.ILPoint = new System.Windows.Forms.ImageList(this.components);
            this.lbPointText = new System.Windows.Forms.Label();
            this.PnBeforeGame.SuspendLayout();
            this.PnGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnEndGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPoint)).BeginInit();
            this.PnRanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNoiDung.Location = new System.Drawing.Point(0, 46);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(523, 186);
            this.rtbNoiDung.TabIndex = 0;
            this.rtbNoiDung.Text = "";
            // 
            // RTBChatClient
            // 
            this.RTBChatClient.BackColor = System.Drawing.Color.Cornsilk;
            this.RTBChatClient.Location = new System.Drawing.Point(0, 457);
            this.RTBChatClient.Name = "RTBChatClient";
            this.RTBChatClient.Size = new System.Drawing.Size(523, 176);
            this.RTBChatClient.TabIndex = 1;
            this.RTBChatClient.Text = "";
            // 
            // btnChoose1
            // 
            this.btnChoose1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose1.Location = new System.Drawing.Point(12, 269);
            this.btnChoose1.Name = "btnChoose1";
            this.btnChoose1.Size = new System.Drawing.Size(221, 57);
            this.btnChoose1.TabIndex = 9;
            this.btnChoose1.Text = "A";
            this.btnChoose1.UseVisualStyleBackColor = true;
            this.btnChoose1.Click += new System.EventHandler(this.btnChoose1_Click);
            // 
            // btnChoose2
            // 
            this.btnChoose2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose2.Location = new System.Drawing.Point(269, 270);
            this.btnChoose2.Name = "btnChoose2";
            this.btnChoose2.Size = new System.Drawing.Size(221, 57);
            this.btnChoose2.TabIndex = 10;
            this.btnChoose2.Text = "B";
            this.btnChoose2.UseVisualStyleBackColor = true;
            this.btnChoose2.Click += new System.EventHandler(this.btnChoose1_Click);
            // 
            // btnChoose3
            // 
            this.btnChoose3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose3.Location = new System.Drawing.Point(12, 356);
            this.btnChoose3.Name = "btnChoose3";
            this.btnChoose3.Size = new System.Drawing.Size(221, 57);
            this.btnChoose3.TabIndex = 11;
            this.btnChoose3.Text = "C";
            this.btnChoose3.UseVisualStyleBackColor = true;
            this.btnChoose3.Click += new System.EventHandler(this.btnChoose1_Click);
            // 
            // btnChoose4
            // 
            this.btnChoose4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose4.Location = new System.Drawing.Point(269, 356);
            this.btnChoose4.Name = "btnChoose4";
            this.btnChoose4.Size = new System.Drawing.Size(221, 57);
            this.btnChoose4.TabIndex = 12;
            this.btnChoose4.Text = "D";
            this.btnChoose4.UseVisualStyleBackColor = true;
            this.btnChoose4.Click += new System.EventHandler(this.btnChoose1_Click);
            // 
            // PnBeforeGame
            // 
            this.PnBeforeGame.Controls.Add(this.lbBeforeGameTime);
            this.PnBeforeGame.Location = new System.Drawing.Point(0, 0);
            this.PnBeforeGame.Name = "PnBeforeGame";
            this.PnBeforeGame.Size = new System.Drawing.Size(523, 429);
            this.PnBeforeGame.TabIndex = 13;
            // 
            // lbBeforeGameTime
            // 
            this.lbBeforeGameTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbBeforeGameTime.AutoSize = true;
            this.lbBeforeGameTime.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeforeGameTime.Location = new System.Drawing.Point(167, 163);
            this.lbBeforeGameTime.Name = "lbBeforeGameTime";
            this.lbBeforeGameTime.Size = new System.Drawing.Size(257, 125);
            this.lbBeforeGameTime.TabIndex = 0;
            this.lbBeforeGameTime.Text = "time";
            this.lbBeforeGameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnGame
            // 
            this.PnGame.Controls.Add(this.pictureBox1);
            this.PnGame.Controls.Add(this.pictureBox2);
            this.PnGame.Controls.Add(this.lbPointText);
            this.PnGame.Controls.Add(this.lbPoint);
            this.PnGame.Controls.Add(this.lbTimelimit);
            this.PnGame.Controls.Add(this.lbCountDownGame);
            this.PnGame.Controls.Add(this.rtbNoiDung);
            this.PnGame.Controls.Add(this.btnChoose2);
            this.PnGame.Controls.Add(this.btnChoose3);
            this.PnGame.Controls.Add(this.btnChoose4);
            this.PnGame.Controls.Add(this.btnChoose1);
            this.PnGame.Location = new System.Drawing.Point(0, 0);
            this.PnGame.Name = "PnGame";
            this.PnGame.Size = new System.Drawing.Size(520, 426);
            this.PnGame.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(520, 447);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoint.Location = new System.Drawing.Point(61, 12);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(20, 24);
            this.lbPoint.TabIndex = 15;
            this.lbPoint.Text = "0";
            this.lbPoint.Click += new System.EventHandler(this.lbPoint_Click);
            // 
            // lbTimelimit
            // 
            this.lbTimelimit.AutoSize = true;
            this.lbTimelimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimelimit.Location = new System.Drawing.Point(474, 12);
            this.lbTimelimit.Name = "lbTimelimit";
            this.lbTimelimit.Size = new System.Drawing.Size(0, 16);
            this.lbTimelimit.TabIndex = 14;
            // 
            // lbCountDownGame
            // 
            this.lbCountDownGame.AutoSize = true;
            this.lbCountDownGame.Location = new System.Drawing.Point(467, 9);
            this.lbCountDownGame.Name = "lbCountDownGame";
            this.lbCountDownGame.Size = new System.Drawing.Size(0, 13);
            this.lbCountDownGame.TabIndex = 13;
            // 
            // TBChatClient
            // 
            this.TBChatClient.Location = new System.Drawing.Point(12, 650);
            this.TBChatClient.Name = "TBChatClient";
            this.TBChatClient.Size = new System.Drawing.Size(272, 20);
            this.TBChatClient.TabIndex = 14;
            // 
            // btnBeforeGameSend
            // 
            this.btnBeforeGameSend.BackColor = System.Drawing.Color.Transparent;
            this.btnBeforeGameSend.BackgroundImage = global::DemoExploter.Properties.Resources.send;
            this.btnBeforeGameSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeforeGameSend.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBeforeGameSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBeforeGameSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeforeGameSend.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeforeGameSend.ForeColor = System.Drawing.Color.SpringGreen;
            this.btnBeforeGameSend.Location = new System.Drawing.Point(296, 650);
            this.btnBeforeGameSend.Name = "btnBeforeGameSend";
            this.btnBeforeGameSend.Size = new System.Drawing.Size(95, 31);
            this.btnBeforeGameSend.TabIndex = 15;
            this.btnBeforeGameSend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBeforeGameSend.UseVisualStyleBackColor = false;
            this.btnBeforeGameSend.Click += new System.EventHandler(this.btnBeforeGameSend_Click);
            // 
            // PnEndGame
            // 
            this.PnEndGame.Controls.Add(this.btnRanking);
            this.PnEndGame.Controls.Add(this.PBGameOver);
            this.PnEndGame.Controls.Add(this.PBPoint);
            this.PnEndGame.Controls.Add(this.btnQuitGame);
            this.PnEndGame.Location = new System.Drawing.Point(0, 0);
            this.PnEndGame.Name = "PnEndGame";
            this.PnEndGame.Size = new System.Drawing.Size(523, 459);
            this.PnEndGame.TabIndex = 1;
            // 
            // btnRanking
            // 
            this.btnRanking.Enabled = false;
            this.btnRanking.Location = new System.Drawing.Point(296, 432);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(128, 23);
            this.btnRanking.TabIndex = 17;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // PBGameOver
            // 
            this.PBGameOver.Image = ((System.Drawing.Image)(resources.GetObject("PBGameOver.Image")));
            this.PBGameOver.Location = new System.Drawing.Point(0, 0);
            this.PBGameOver.Name = "PBGameOver";
            this.PBGameOver.Size = new System.Drawing.Size(523, 196);
            this.PBGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBGameOver.TabIndex = 0;
            this.PBGameOver.TabStop = false;
            // 
            // PBPoint
            // 
            this.PBPoint.BackgroundImage = global::DemoExploter.Properties.Resources._0;
            this.PBPoint.Image = global::DemoExploter.Properties.Resources._20;
            this.PBPoint.Location = new System.Drawing.Point(0, 163);
            this.PBPoint.Name = "PBPoint";
            this.PBPoint.Size = new System.Drawing.Size(523, 266);
            this.PBPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBPoint.TabIndex = 1;
            this.PBPoint.TabStop = false;
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.Location = new System.Drawing.Point(33, 434);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(128, 23);
            this.btnQuitGame.TabIndex = 16;
            this.btnQuitGame.Text = "Quit";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // PnRanking
            // 
            this.PnRanking.Controls.Add(this.RTBRanking);
            this.PnRanking.Enabled = false;
            this.PnRanking.Location = new System.Drawing.Point(0, 0);
            this.PnRanking.Name = "PnRanking";
            this.PnRanking.Size = new System.Drawing.Size(523, 429);
            this.PnRanking.TabIndex = 1;
            // 
            // RTBRanking
            // 
            this.RTBRanking.Font = new System.Drawing.Font("Pokemon GB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBRanking.Location = new System.Drawing.Point(0, 0);
            this.RTBRanking.Name = "RTBRanking";
            this.RTBRanking.Size = new System.Drawing.Size(520, 429);
            this.RTBRanking.TabIndex = 0;
            this.RTBRanking.Text = "";
            // 
            // ILPoint
            // 
            this.ILPoint.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILPoint.ImageStream")));
            this.ILPoint.TransparentColor = System.Drawing.Color.Transparent;
            this.ILPoint.Images.SetKeyName(0, "10.gif");
            this.ILPoint.Images.SetKeyName(1, "20.gif");
            this.ILPoint.Images.SetKeyName(2, "30.gif");
            this.ILPoint.Images.SetKeyName(3, "40.gif");
            this.ILPoint.Images.SetKeyName(4, "50.gif");
            this.ILPoint.Images.SetKeyName(5, "60.gif");
            this.ILPoint.Images.SetKeyName(6, "70.gif");
            this.ILPoint.Images.SetKeyName(7, "80.gif");
            this.ILPoint.Images.SetKeyName(8, "90.gif");
            this.ILPoint.Images.SetKeyName(9, "100.gif");
            this.ILPoint.Images.SetKeyName(10, "GameOver.gif");
            // 
            // lbPointText
            // 
            this.lbPointText.AutoSize = true;
            this.lbPointText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPointText.Location = new System.Drawing.Point(3, 12);
            this.lbPointText.Name = "lbPointText";
            this.lbPointText.Size = new System.Drawing.Size(52, 24);
            this.lbPointText.TabIndex = 17;
            this.lbPointText.Text = "Point";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DemoExploter.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(524, 694);
            this.Controls.Add(this.PnBeforeGame);
            this.Controls.Add(this.PnGame);
            this.Controls.Add(this.btnBeforeGameSend);
            this.Controls.Add(this.TBChatClient);
            this.Controls.Add(this.RTBChatClient);
            this.Controls.Add(this.PnEndGame);
            this.Controls.Add(this.PnRanking);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.PnBeforeGame.ResumeLayout(false);
            this.PnBeforeGame.PerformLayout();
            this.PnGame.ResumeLayout(false);
            this.PnGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnEndGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPoint)).EndInit();
            this.PnRanking.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.RichTextBox RTBChatClient;
        private System.Windows.Forms.Button btnChoose1;
        private System.Windows.Forms.Button btnChoose2;
        private System.Windows.Forms.Button btnChoose3;
        private System.Windows.Forms.Button btnChoose4;
        private System.Windows.Forms.Panel PnBeforeGame;
        private System.Windows.Forms.Label lbBeforeGameTime;
        private System.Windows.Forms.TextBox TBChatClient;
        private System.Windows.Forms.Button btnBeforeGameSend;
        private System.Windows.Forms.Panel PnGame;
        private System.Windows.Forms.Label lbCountDownGame;
        private System.Windows.Forms.Label lbTimelimit;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel PnEndGame;
        private System.Windows.Forms.ImageList ILPoint;
        private System.Windows.Forms.PictureBox PBPoint;
        private System.Windows.Forms.PictureBox PBGameOver;
        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Panel PnRanking;
        private System.Windows.Forms.RichTextBox RTBRanking;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.Label lbPointText;
    }
}