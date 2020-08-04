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
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using DTOProj;
using System.Media;
using System.Windows.Media;
namespace DemoExploter
{

    public partial class frmGameShow : Form
    {
       


        public frmGameShow()
        {
            InitializeComponent();
            btnLich.Enabled = false;
        }
        TcpClient client;

        NetworkStream ns;
        Timer gameTimer = new Timer();
        public static string NameUser;
        int OrigTime = 1800;
        public static DateTime newDateGame;
        List<ScheduleGame> ReceiveScheduleFromServer = new List<ScheduleGame>();

        private void frmGameShow_Load(object sender, EventArgs e)
        {

            
            

            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            
        }
       
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeX_Tick(sender, e);
        }

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
  
        private async void btnConnectServer_Click(object sender, EventArgs e)
        {
            
            byte[] bytes = new byte[1024*5000];
            try
            {
                //listener = new TcpListener(IPAddress.Any, 13000);
                //listener.Start();
                client = new TcpClient(Dns.GetHostName(), 14000);
                ns = client.GetStream();

                MemoryStream memStream = new MemoryStream();
                BinaryFormatter binForm = new BinaryFormatter();

                // Wait for data to begin coming in for up to 20 secs

                var receivedData = (List<ScheduleGame>)null;

                using (var networkStream = ns)
                {
                    do
                    {
                        receivedData = (List<ScheduleGame>)binForm.Deserialize(networkStream);
                    }
                    while (networkStream.DataAvailable);
                    ReceiveScheduleFromServer = receivedData;
                }
                client.Close();
               
                //////////////////////////////////
                grvGameShow.DataSource = ReceiveScheduleFromServer;
                //var nearestGameShow = lst[0];
                var nearestGameShow = ReceiveScheduleFromServer[0];
                lblName.Text = nearestGameShow.NameGame;
                string dateAndTime;
                dateAndTime = nearestGameShow.Date + " " + nearestGameShow.Time;
               
                newDateGame = Convert.ToDateTime(dateAndTime);
                int DateCount = 0;
               while(newDateGame<DateTime.Now && DateCount< ReceiveScheduleFromServer.Count)
                {
                     nearestGameShow = ReceiveScheduleFromServer[DateCount];
                    lblName.Text = nearestGameShow.NameGame;
                    
                    dateAndTime = nearestGameShow.Date + " " + nearestGameShow.Time;
                    
                    newDateGame = Convert.ToDateTime(dateAndTime);
                    DateCount++;
                }
                lblTime.Text = newDateGame.ToString("dd/MM/yyyy hh:mm:ss");
                
                OrigTime = (int)Math.Round((newDateGame - DateTime.Now).TotalSeconds, 0);

                gameTimer.Enabled = true;
                btnLich.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Server chưa mở hoặc đã đóng ");

            }
        }
    
        private void btnBack_Click(object sender, EventArgs e)
        {
            btnName.Visible = true;
            btnConnectServer.Visible = true;
            btnLich.Visible = true;
            btnQuit.Visible = true;
            btnStart.Visible = true;
            grvGameShow.Visible = false;
            tbSetName.Visible = false;
            label1.Visible = false;
            NameUser = tbSetName.Text;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnName_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            btnName.Visible = false;
            btnConnectServer.Visible = false;
            btnLich.Visible = false;
            btnQuit.Visible = false;
            btnStart.Visible = false;
            tbSetName.Visible = true;
            label1.Visible = true;

        }
    }
}
