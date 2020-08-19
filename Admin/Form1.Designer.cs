namespace Admin
{
    partial class Admin
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbHelp = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lbNextGame = new System.Windows.Forms.Label();
            this.lbNextGameTime = new System.Windows.Forms.Label();
            this.btnLoadQuest = new System.Windows.Forms.Button();
            this.btnQuest = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.lbFunc = new System.Windows.Forms.Label();
            this.PnServer = new System.Windows.Forms.Panel();
            this.lbNumberUser = new System.Windows.Forms.Label();
            this.btnAdminSendText = new System.Windows.Forms.Button();
            this.TBAdminChat = new System.Windows.Forms.TextBox();
            this.RTBServer = new System.Windows.Forms.RichTextBox();
            this.RTBChat = new System.Windows.Forms.RichTextBox();
            this.PnQuest = new System.Windows.Forms.Panel();
            this.CBAnswerD = new System.Windows.Forms.CheckBox();
            this.CBAnswerC = new System.Windows.Forms.CheckBox();
            this.CBAnswerB = new System.Windows.Forms.CheckBox();
            this.CBAnswerA = new System.Windows.Forms.CheckBox();
            this.lbSelectD = new System.Windows.Forms.Label();
            this.lbSelectC = new System.Windows.Forms.Label();
            this.lbSelectB = new System.Windows.Forms.Label();
            this.lbSelectA = new System.Windows.Forms.Label();
            this.lbQuest = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtQuest = new System.Windows.Forms.TextBox();
            this.btnAddquest = new System.Windows.Forms.Button();
            this.PnSchedule = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.GrvSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PnServer.SuspendLayout();
            this.PnQuest.SuspendLayout();
            this.PnSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbHelp);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuit);
            this.splitContainer1.Panel1.Controls.Add(this.lbNextGame);
            this.splitContainer1.Panel1.Controls.Add(this.lbNextGameTime);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadQuest);
            this.splitContainer1.Panel1.Controls.Add(this.btnQuest);
            this.splitContainer1.Panel1.Controls.Add(this.btnSchedule);
            this.splitContainer1.Panel1.Controls.Add(this.btnServer);
            this.splitContainer1.Panel1.Controls.Add(this.lbFunc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PnServer);
            this.splitContainer1.Panel2.Controls.Add(this.PnQuest);
            this.splitContainer1.Panel2.Controls.Add(this.PnSchedule);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHelp.Location = new System.Drawing.Point(3, 9);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(16, 19);
            this.lbHelp.TabIndex = 8;
            this.lbHelp.Text = "?";
            this.lbHelp.Click += new System.EventHandler(this.lbHelp_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(12, 252);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(155, 43);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lbNextGame
            // 
            this.lbNextGame.AutoSize = true;
            this.lbNextGame.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextGame.Location = new System.Drawing.Point(8, 338);
            this.lbNextGame.Name = "lbNextGame";
            this.lbNextGame.Size = new System.Drawing.Size(155, 21);
            this.lbNextGame.TabIndex = 6;
            this.lbNextGame.Text = "next game starts in";
            // 
            // lbNextGameTime
            // 
            this.lbNextGameTime.AutoSize = true;
            this.lbNextGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextGameTime.Location = new System.Drawing.Point(27, 368);
            this.lbNextGameTime.Name = "lbNextGameTime";
            this.lbNextGameTime.Size = new System.Drawing.Size(0, 37);
            this.lbNextGameTime.TabIndex = 5;
            // 
            // btnLoadQuest
            // 
            this.btnLoadQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadQuest.Location = new System.Drawing.Point(12, 202);
            this.btnLoadQuest.Name = "btnLoadQuest";
            this.btnLoadQuest.Size = new System.Drawing.Size(155, 43);
            this.btnLoadQuest.TabIndex = 4;
            this.btnLoadQuest.Text = "LoadQuest";
            this.btnLoadQuest.UseVisualStyleBackColor = true;
            this.btnLoadQuest.Click += new System.EventHandler(this.btnLoadQuest_Click);
            // 
            // btnQuest
            // 
            this.btnQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuest.Location = new System.Drawing.Point(12, 153);
            this.btnQuest.Name = "btnQuest";
            this.btnQuest.Size = new System.Drawing.Size(155, 43);
            this.btnQuest.TabIndex = 3;
            this.btnQuest.Text = "Question";
            this.btnQuest.UseVisualStyleBackColor = true;
            this.btnQuest.Click += new System.EventHandler(this.btnQuest_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(12, 104);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(155, 43);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnServer
            // 
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.Location = new System.Drawing.Point(12, 55);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(155, 43);
            this.btnServer.TabIndex = 1;
            this.btnServer.Text = "ServerStart";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // lbFunc
            // 
            this.lbFunc.AutoSize = true;
            this.lbFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFunc.Location = new System.Drawing.Point(28, 9);
            this.lbFunc.Name = "lbFunc";
            this.lbFunc.Size = new System.Drawing.Size(119, 31);
            this.lbFunc.TabIndex = 0;
            this.lbFunc.Text = "Function";
            // 
            // PnServer
            // 
            this.PnServer.Controls.Add(this.lbNumberUser);
            this.PnServer.Controls.Add(this.btnAdminSendText);
            this.PnServer.Controls.Add(this.TBAdminChat);
            this.PnServer.Controls.Add(this.RTBServer);
            this.PnServer.Controls.Add(this.RTBChat);
            this.PnServer.Enabled = false;
            this.PnServer.Location = new System.Drawing.Point(0, 0);
            this.PnServer.Name = "PnServer";
            this.PnServer.Size = new System.Drawing.Size(601, 438);
            this.PnServer.TabIndex = 17;
            this.PnServer.Visible = false;
            // 
            // lbNumberUser
            // 
            this.lbNumberUser.AutoSize = true;
            this.lbNumberUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberUser.Location = new System.Drawing.Point(14, 4);
            this.lbNumberUser.Name = "lbNumberUser";
            this.lbNumberUser.Size = new System.Drawing.Size(45, 16);
            this.lbNumberUser.TabIndex = 20;
            this.lbNumberUser.Text = "User:";
            this.lbNumberUser.Click += new System.EventHandler(this.lbNumberUser_Click);
            // 
            // btnAdminSendText
            // 
            this.btnAdminSendText.Location = new System.Drawing.Point(265, 394);
            this.btnAdminSendText.Name = "btnAdminSendText";
            this.btnAdminSendText.Size = new System.Drawing.Size(75, 23);
            this.btnAdminSendText.TabIndex = 19;
            this.btnAdminSendText.Text = "Send";
            this.btnAdminSendText.UseVisualStyleBackColor = true;
            this.btnAdminSendText.Click += new System.EventHandler(this.btnAdminSendText_Click);
            // 
            // TBAdminChat
            // 
            this.TBAdminChat.Location = new System.Drawing.Point(25, 368);
            this.TBAdminChat.Name = "TBAdminChat";
            this.TBAdminChat.Size = new System.Drawing.Size(538, 20);
            this.TBAdminChat.TabIndex = 18;
            // 
            // RTBServer
            // 
            this.RTBServer.Location = new System.Drawing.Point(3, 23);
            this.RTBServer.Name = "RTBServer";
            this.RTBServer.Size = new System.Drawing.Size(262, 344);
            this.RTBServer.TabIndex = 0;
            this.RTBServer.Text = "";
            // 
            // RTBChat
            // 
            this.RTBChat.Location = new System.Drawing.Point(265, 23);
            this.RTBChat.Name = "RTBChat";
            this.RTBChat.Size = new System.Drawing.Size(345, 344);
            this.RTBChat.TabIndex = 17;
            this.RTBChat.Text = "";
            // 
            // PnQuest
            // 
            this.PnQuest.Controls.Add(this.CBAnswerD);
            this.PnQuest.Controls.Add(this.CBAnswerC);
            this.PnQuest.Controls.Add(this.CBAnswerB);
            this.PnQuest.Controls.Add(this.CBAnswerA);
            this.PnQuest.Controls.Add(this.lbSelectD);
            this.PnQuest.Controls.Add(this.lbSelectC);
            this.PnQuest.Controls.Add(this.lbSelectB);
            this.PnQuest.Controls.Add(this.lbSelectA);
            this.PnQuest.Controls.Add(this.lbQuest);
            this.PnQuest.Controls.Add(this.btnSave);
            this.PnQuest.Controls.Add(this.txtD);
            this.PnQuest.Controls.Add(this.txtC);
            this.PnQuest.Controls.Add(this.txtB);
            this.PnQuest.Controls.Add(this.txtA);
            this.PnQuest.Controls.Add(this.txtQuest);
            this.PnQuest.Controls.Add(this.btnAddquest);
            this.PnQuest.Enabled = false;
            this.PnQuest.Location = new System.Drawing.Point(0, 0);
            this.PnQuest.Name = "PnQuest";
            this.PnQuest.Size = new System.Drawing.Size(607, 444);
            this.PnQuest.TabIndex = 6;
            this.PnQuest.Visible = false;
            // 
            // CBAnswerD
            // 
            this.CBAnswerD.AutoSize = true;
            this.CBAnswerD.Location = new System.Drawing.Point(416, 268);
            this.CBAnswerD.Name = "CBAnswerD";
            this.CBAnswerD.Size = new System.Drawing.Size(61, 17);
            this.CBAnswerD.TabIndex = 16;
            this.CBAnswerD.Text = "Answer";
            this.CBAnswerD.UseVisualStyleBackColor = true;
            this.CBAnswerD.Click += new System.EventHandler(this.CBAnswerD_Click);
            // 
            // CBAnswerC
            // 
            this.CBAnswerC.AutoSize = true;
            this.CBAnswerC.Location = new System.Drawing.Point(416, 230);
            this.CBAnswerC.Name = "CBAnswerC";
            this.CBAnswerC.Size = new System.Drawing.Size(61, 17);
            this.CBAnswerC.TabIndex = 15;
            this.CBAnswerC.Text = "Answer";
            this.CBAnswerC.UseVisualStyleBackColor = true;
            this.CBAnswerC.Click += new System.EventHandler(this.CBAnswerC_Click);
            // 
            // CBAnswerB
            // 
            this.CBAnswerB.AutoSize = true;
            this.CBAnswerB.Location = new System.Drawing.Point(416, 186);
            this.CBAnswerB.Name = "CBAnswerB";
            this.CBAnswerB.Size = new System.Drawing.Size(61, 17);
            this.CBAnswerB.TabIndex = 14;
            this.CBAnswerB.Text = "Answer";
            this.CBAnswerB.UseVisualStyleBackColor = true;
            this.CBAnswerB.Click += new System.EventHandler(this.CBAnswerB_Click);
            // 
            // CBAnswerA
            // 
            this.CBAnswerA.AutoSize = true;
            this.CBAnswerA.Location = new System.Drawing.Point(416, 138);
            this.CBAnswerA.Name = "CBAnswerA";
            this.CBAnswerA.Size = new System.Drawing.Size(61, 17);
            this.CBAnswerA.TabIndex = 13;
            this.CBAnswerA.Text = "Answer";
            this.CBAnswerA.UseVisualStyleBackColor = true;
            this.CBAnswerA.Click += new System.EventHandler(this.CBAnswerA_Click);
            // 
            // lbSelectD
            // 
            this.lbSelectD.AutoSize = true;
            this.lbSelectD.Location = new System.Drawing.Point(132, 250);
            this.lbSelectD.Name = "lbSelectD";
            this.lbSelectD.Size = new System.Drawing.Size(45, 13);
            this.lbSelectD.TabIndex = 11;
            this.lbSelectD.Text = "SelectD";
            // 
            // lbSelectC
            // 
            this.lbSelectC.AutoSize = true;
            this.lbSelectC.Location = new System.Drawing.Point(132, 211);
            this.lbSelectC.Name = "lbSelectC";
            this.lbSelectC.Size = new System.Drawing.Size(44, 13);
            this.lbSelectC.TabIndex = 10;
            this.lbSelectC.Text = "SelectC";
            // 
            // lbSelectB
            // 
            this.lbSelectB.AutoSize = true;
            this.lbSelectB.Location = new System.Drawing.Point(132, 158);
            this.lbSelectB.Name = "lbSelectB";
            this.lbSelectB.Size = new System.Drawing.Size(44, 13);
            this.lbSelectB.TabIndex = 9;
            this.lbSelectB.Text = "SelectB";
            // 
            // lbSelectA
            // 
            this.lbSelectA.AutoSize = true;
            this.lbSelectA.Location = new System.Drawing.Point(132, 119);
            this.lbSelectA.Name = "lbSelectA";
            this.lbSelectA.Size = new System.Drawing.Size(44, 13);
            this.lbSelectA.TabIndex = 8;
            this.lbSelectA.Text = "SelectA";
            // 
            // lbQuest
            // 
            this.lbQuest.AutoSize = true;
            this.lbQuest.Location = new System.Drawing.Point(135, 66);
            this.lbQuest.Name = "lbQuest";
            this.lbQuest.Size = new System.Drawing.Size(49, 13);
            this.lbQuest.TabIndex = 7;
            this.lbQuest.Text = "Question";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(153, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(126, 266);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(284, 20);
            this.txtD.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(126, 227);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(284, 20);
            this.txtC.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(126, 183);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(284, 20);
            this.txtB.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(126, 135);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(284, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtQuest
            // 
            this.txtQuest.Location = new System.Drawing.Point(126, 85);
            this.txtQuest.Name = "txtQuest";
            this.txtQuest.Size = new System.Drawing.Size(284, 20);
            this.txtQuest.TabIndex = 1;
            // 
            // btnAddquest
            // 
            this.btnAddquest.Location = new System.Drawing.Point(14, 13);
            this.btnAddquest.Name = "btnAddquest";
            this.btnAddquest.Size = new System.Drawing.Size(106, 23);
            this.btnAddquest.TabIndex = 0;
            this.btnAddquest.Text = "Add question";
            this.btnAddquest.UseVisualStyleBackColor = true;
            this.btnAddquest.Click += new System.EventHandler(this.btnAddquest_Click);
            // 
            // PnSchedule
            // 
            this.PnSchedule.AutoSize = true;
            this.PnSchedule.Controls.Add(this.btnImport);
            this.PnSchedule.Controls.Add(this.btnExport);
            this.PnSchedule.Controls.Add(this.btnDelete);
            this.PnSchedule.Controls.Add(this.GrvSchedule);
            this.PnSchedule.Enabled = false;
            this.PnSchedule.Location = new System.Drawing.Point(3, 3);
            this.PnSchedule.Name = "PnSchedule";
            this.PnSchedule.Size = new System.Drawing.Size(607, 444);
            this.PnSchedule.TabIndex = 1;
            this.PnSchedule.Visible = false;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(22, 13);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(98, 33);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(135, 13);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 33);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(239, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GrvSchedule
            // 
            this.GrvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvSchedule.Location = new System.Drawing.Point(3, 52);
            this.GrvSchedule.Name = "GrvSchedule";
            this.GrvSchedule.Size = new System.Drawing.Size(592, 186);
            this.GrvSchedule.TabIndex = 0;
            this.GrvSchedule.Visible = false;
            this.GrvSchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrvSchedule_CellClick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PnServer.ResumeLayout(false);
            this.PnServer.PerformLayout();
            this.PnQuest.ResumeLayout(false);
            this.PnQuest.PerformLayout();
            this.PnSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrvSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Label lbFunc;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView GrvSchedule;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnQuest;
        private System.Windows.Forms.Panel PnSchedule;
        private System.Windows.Forms.Panel PnQuest;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtQuest;
        private System.Windows.Forms.Button btnAddquest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.CheckBox CBAnswerD;
        private System.Windows.Forms.CheckBox CBAnswerC;
        private System.Windows.Forms.CheckBox CBAnswerB;
        private System.Windows.Forms.CheckBox CBAnswerA;
        private System.Windows.Forms.Label lbSelectD;
        private System.Windows.Forms.Label lbSelectC;
        private System.Windows.Forms.Label lbSelectB;
        private System.Windows.Forms.Label lbSelectA;
        private System.Windows.Forms.Label lbQuest;
        private System.Windows.Forms.Panel PnServer;
        private System.Windows.Forms.RichTextBox RTBServer;
        private System.Windows.Forms.Button btnLoadQuest;
        private System.Windows.Forms.RichTextBox RTBChat;
        private System.Windows.Forms.Label lbNextGame;
        private System.Windows.Forms.Label lbNextGameTime;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnAdminSendText;
        private System.Windows.Forms.TextBox TBAdminChat;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.Label lbNumberUser;
    }
}

