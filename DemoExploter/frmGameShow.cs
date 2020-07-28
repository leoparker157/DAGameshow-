using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExploter
{
    public partial class frmGameShow : Form
    {
        public frmGameShow()
        {
            InitializeComponent();
        }

        Timer gameTimer = new Timer();
        private void frmGameShow_Load(object sender, EventArgs e)
        {
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            List<GameShow> lst = new List<GameShow>();
            lst.Add(
               new GameShow()
               {
                   Id = 1,
                   Name = "Nhanh như chớp",
                   StartDate = DateTime.Now.AddSeconds(10),
                   EndDate = DateTime.Now.AddMinutes(30)
               });

            lst.Add(
               new GameShow()
               {
                   Id = 2,
                   Name = "Nhanh như chớp",
                   StartDate = DateTime.Now.AddDays(1),
                   EndDate = DateTime.Now.AddDays(1).AddMinutes(30)
               });

            lst.Add(
               new GameShow()
               {
                   Id = 3,
                   Name = "Nhanh như chớp",
                   StartDate = DateTime.Now.AddDays(2),
                   EndDate = DateTime.Now.AddDays(2).AddMinutes(30)
               });

            lst.Add(
               new GameShow()
               {
                   Id = 4,
                   Name = "Nhanh như chớp",
                   StartDate = DateTime.Now.AddDays(3),
                   EndDate = DateTime.Now.AddDays(3).AddMinutes(30)
               });

            grvGameShow.DataSource = lst;

            var nearestGameShow = lst[0];
            lblName.Text = nearestGameShow.Name;
            lblTime.Text = nearestGameShow.StartDate.ToString("dd/MM/yyyy hh:mm:ss");

            OrigTime = (int)Math.Round((nearestGameShow.StartDate - DateTime.Now).TotalSeconds, 0);

            gameTimer.Enabled = true;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeX_Tick(sender, e);
        }

        int OrigTime = 1800;
        void timeX_Tick(object sender, EventArgs e)
        {
            OrigTime--;
           LbTime.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            if(OrigTime<=0)
            {
                gameTimer.Enabled = false;
                btnStart.Enabled = true;
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();

            this.WindowState = FormWindowState.Minimized;
        }

        private void grvGameShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

       

        private void lblTime_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLich_Click(object sender, EventArgs e)
        {


            grvGameShow.Width = 0;
            grvGameShow.Height = 0;
            grvGameShow.AutoSize = true;
            grvGameShow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grvGameShow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grvGameShow.DataBindings.Clear();
            grvGameShow.DataBindings.Add(nameof(DataGrid.BackgroundColor), this,nameof(Control.BackColor));
            grvGameShow.BorderStyle = BorderStyle.None;
            grvGameShow.Visible = true;
            btnStart.Visible = false;
            btnLich.Visible = false;
            btnBack.Visible = true;

        }

        private void txtCountDown_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            btnLich.Visible = true;
            btnBack.Visible = false;
            grvGameShow.Visible = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
