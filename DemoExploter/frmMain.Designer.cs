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
            this.rtbNoiDung = new System.Windows.Forms.RichTextBox();
            this.RTBChatClient = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChooseA = new System.Windows.Forms.Button();
            this.btnChooseB = new System.Windows.Forms.Button();
            this.btnChooseC = new System.Windows.Forms.Button();
            this.btnChooseD = new System.Windows.Forms.Button();
            this.PnBeforeGame = new System.Windows.Forms.Panel();
            this.lbBeforeGameTime = new System.Windows.Forms.Label();
            this.TBChatClient = new System.Windows.Forms.TextBox();
            this.btnBeforeGameSend = new System.Windows.Forms.Button();
            this.PnBeforeGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbNoiDung
            // 
            this.rtbNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNoiDung.Location = new System.Drawing.Point(0, 1);
            this.rtbNoiDung.Name = "rtbNoiDung";
            this.rtbNoiDung.Size = new System.Drawing.Size(523, 231);
            this.rtbNoiDung.TabIndex = 0;
            this.rtbNoiDung.Text = "";
            // 
            // RTBChatClient
            // 
            this.RTBChatClient.BackColor = System.Drawing.SystemColors.Info;
            this.RTBChatClient.Location = new System.Drawing.Point(0, 457);
            this.RTBChatClient.Name = "RTBChatClient";
            this.RTBChatClient.Size = new System.Drawing.Size(523, 176);
            this.RTBChatClient.TabIndex = 1;
            this.RTBChatClient.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChooseA
            // 
            this.btnChooseA.Location = new System.Drawing.Point(12, 238);
            this.btnChooseA.Name = "btnChooseA";
            this.btnChooseA.Size = new System.Drawing.Size(221, 57);
            this.btnChooseA.TabIndex = 9;
            this.btnChooseA.Text = "A";
            this.btnChooseA.UseVisualStyleBackColor = true;
            // 
            // btnChooseB
            // 
            this.btnChooseB.Location = new System.Drawing.Point(269, 238);
            this.btnChooseB.Name = "btnChooseB";
            this.btnChooseB.Size = new System.Drawing.Size(221, 57);
            this.btnChooseB.TabIndex = 10;
            this.btnChooseB.Text = "B";
            this.btnChooseB.UseVisualStyleBackColor = true;
            // 
            // btnChooseC
            // 
            this.btnChooseC.Location = new System.Drawing.Point(12, 356);
            this.btnChooseC.Name = "btnChooseC";
            this.btnChooseC.Size = new System.Drawing.Size(221, 57);
            this.btnChooseC.TabIndex = 11;
            this.btnChooseC.Text = "C";
            this.btnChooseC.UseVisualStyleBackColor = true;
            // 
            // btnChooseD
            // 
            this.btnChooseD.Location = new System.Drawing.Point(269, 356);
            this.btnChooseD.Name = "btnChooseD";
            this.btnChooseD.Size = new System.Drawing.Size(221, 57);
            this.btnChooseD.TabIndex = 12;
            this.btnChooseD.Text = "D";
            this.btnChooseD.UseVisualStyleBackColor = true;
            this.btnChooseD.Click += new System.EventHandler(this.btnChooseD_Click);
            // 
            // PnBeforeGame
            // 
            this.PnBeforeGame.Controls.Add(this.lbBeforeGameTime);
            this.PnBeforeGame.Location = new System.Drawing.Point(0, 1);
            this.PnBeforeGame.Name = "PnBeforeGame";
            this.PnBeforeGame.Size = new System.Drawing.Size(523, 412);
            this.PnBeforeGame.TabIndex = 13;
            // 
            // lbBeforeGameTime
            // 
            this.lbBeforeGameTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbBeforeGameTime.AutoSize = true;
            this.lbBeforeGameTime.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeforeGameTime.Location = new System.Drawing.Point(128, 172);
            this.lbBeforeGameTime.Name = "lbBeforeGameTime";
            this.lbBeforeGameTime.Size = new System.Drawing.Size(257, 125);
            this.lbBeforeGameTime.TabIndex = 0;
            this.lbBeforeGameTime.Text = "time";
            this.lbBeforeGameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBeforeGameTime.Click += new System.EventHandler(this.lbBeforeGameTime_Click);
            // 
            // TBChatClient
            // 
            this.TBChatClient.Location = new System.Drawing.Point(12, 639);
            this.TBChatClient.Name = "TBChatClient";
            this.TBChatClient.Size = new System.Drawing.Size(272, 20);
            this.TBChatClient.TabIndex = 14;
            // 
            // btnBeforeGameSend
            // 
            this.btnBeforeGameSend.Location = new System.Drawing.Point(361, 636);
            this.btnBeforeGameSend.Name = "btnBeforeGameSend";
            this.btnBeforeGameSend.Size = new System.Drawing.Size(75, 23);
            this.btnBeforeGameSend.TabIndex = 15;
            this.btnBeforeGameSend.Text = "send";
            this.btnBeforeGameSend.UseVisualStyleBackColor = true;
            this.btnBeforeGameSend.Click += new System.EventHandler(this.btnBeforeGameSend_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 706);
            this.Controls.Add(this.btnBeforeGameSend);
            this.Controls.Add(this.TBChatClient);
            this.Controls.Add(this.btnChooseD);
            this.Controls.Add(this.btnChooseC);
            this.Controls.Add(this.btnChooseB);
            this.Controls.Add(this.btnChooseA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RTBChatClient);
            this.Controls.Add(this.rtbNoiDung);
            this.Controls.Add(this.PnBeforeGame);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.PnBeforeGame.ResumeLayout(false);
            this.PnBeforeGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbNoiDung;
        private System.Windows.Forms.RichTextBox RTBChatClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChooseA;
        private System.Windows.Forms.Button btnChooseB;
        private System.Windows.Forms.Button btnChooseC;
        private System.Windows.Forms.Button btnChooseD;
        private System.Windows.Forms.Panel PnBeforeGame;
        private System.Windows.Forms.Label lbBeforeGameTime;
        private System.Windows.Forms.TextBox TBChatClient;
        private System.Windows.Forms.Button btnBeforeGameSend;
    }
}