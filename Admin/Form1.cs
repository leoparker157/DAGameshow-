using DTOProj;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Data.SqlTypes;
using System.Globalization;
namespace Admin
{
   
    public partial class Form1 : Form
    {
        Thread T = null;
        public Form1()
        {
            InitializeComponent();


        }
        class Connection

        {

            public TcpClient client;

            public NetworkStream ns;
            public string name;
        }
        delegate void SetTextCallback(string text);
        List<Question> lstCauHoi = new List<Question>();
        List<Question> ListCauHoi = new List<Question>();
        TcpListener ServerSocket = null;
        TcpListener ScheduleToClient = null;
        TcpListener ReceivePoint = null;
        List<Connection> clientList;
        NetworkStream ns;
        Connection[] ClientConnect = new Connection[100];
        List<ScheduleGame> SendSchedule = new List<ScheduleGame>();
        List<Player> ListPoint = new List<Player>();
        System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer gamestartAfter = new System.Windows.Forms.Timer();
        int numclient = -1;
        bool IsListen = false;
        int OrigTime = 1800;
        int ThoiGianBatDau = 30;
        bool serversocketStop = false;
        int ClientPoint = -1;
        Connection[] ClientConnectPoint = new Connection[100];
        DateTimePicker oDateTimePicker = null;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            PnQuest.Visible = false;
            PnQuest.Enabled = false;
            PnSchedule.Enabled = true;
            PnSchedule.Visible = true;
            GrvSchedule.Visible = true;
            GrvSchedule.DataSource = null;
            GrvSchedule.ColumnCount = 3;

            GrvSchedule.Columns[0].Name = "Name";
            GrvSchedule.Columns[1].Name = "Start Date";
            GrvSchedule.Columns[2].Name = "TIME";
           

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (this.GrvSchedule.SelectedRows.Count > 0 && this.GrvSchedule.SelectedRows[0].Index != this.GrvSchedule.Rows.Count - 1)
            {
                this.GrvSchedule.Rows.RemoveAt(
                    this.GrvSchedule.SelectedRows[0].Index);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            using (TextWriter tw = new StreamWriter(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Schedule.txt"))
            {

                for (int i = 0; i < GrvSchedule.Rows.Count - 1; i++)
                {
                    tw.Write(i + 1);
                    tw.Write(",");
                    for (int j = 0; j < GrvSchedule.Columns.Count; j++)
                    {
                        tw.Write($"{GrvSchedule.Rows[i].Cells[j].Value.ToString() }");

                        if (j != GrvSchedule.Columns.Count - 1)
                        {
                            tw.Write(",");
                        }
                    }
                    tw.WriteLine();
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Schedule.txt"))
            {
                GrvSchedule.DataSource = null;
                GrvSchedule.Rows.Clear();
                GrvSchedule.Columns.Clear();
                GrvSchedule.Refresh();
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");

                dt.Columns.Add("Start Date");
                dt.Columns.Add("TIME");
              
                string newline;
                while ((newline = sr.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    var y = string.Join(".", newline.Split(',').Skip(1));
                    string[] values = y.Split('.');
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                    }
                    dt.Rows.Add(dr);
                }
                sr.Close();
                GrvSchedule.DataSource = dt;
            }
        }

        private void btnQuest_Click(object sender, EventArgs e)
        {
            PnSchedule.Enabled = false;
            PnSchedule.Visible = false;
            PnQuest.Enabled = true;
            PnQuest.Visible = true;



        }
        private string FileCreate()
        {
            string fullPath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\DanhSachCauHoi.txt");
            int count = 1;

            string fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
            string extension = Path.GetExtension(fullPath);
            string path = Path.GetDirectoryName(fullPath);
            string newFullPath = fullPath;

            while (File.Exists(newFullPath))
            {
                string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                newFullPath = Path.Combine(path, tempFileName + extension);

            }
            return newFullPath;



        }
       
      

        private void btnAddquest_Click(object sender, EventArgs e)
        {


            Question Cauhoi = null;
            Cauhoi = new Question();

            Cauhoi.Content = "@" + txtQuest.Text;
            if (CBAnswerA.Checked == true)
            {
                Cauhoi.Answer = ("#" + txtA.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtB.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtC.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtD.Text);
            }
            else if ((CBAnswerB.Checked == true))
            {
                Cauhoi.Answer = ("#" + txtB.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtA.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtC.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtD.Text);
            }
            else if ((CBAnswerC.Checked == true))
            {
                Cauhoi.Answer = ("#" + txtC.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtA.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtB.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtD.Text);
            }
            else if ((CBAnswerD.Checked == true))
            {
                Cauhoi.Answer = ("#" + txtD.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtA.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtC.Text);
                Cauhoi.DanhSachCauTraLoi.Add("&" + txtB.Text);
            }
            ListCauHoi.Add(Cauhoi);


        }


        private void CBAnswerA_Click(object sender, EventArgs e)
        {
            CBAnswerB.Checked = false;
            CBAnswerC.Checked = false;
            CBAnswerD.Checked = false;
        }

        private void CBAnswerB_Click(object sender, EventArgs e)
        {
            CBAnswerA.Checked = false;
            CBAnswerC.Checked = false;
            CBAnswerD.Checked = false;
        }

        private void CBAnswerC_Click(object sender, EventArgs e)
        {
            CBAnswerA.Checked = false;
            CBAnswerB.Checked = false;
            CBAnswerD.Checked = false;
        }

        private void CBAnswerD_Click(object sender, EventArgs e)
        {
            CBAnswerA.Checked = false;
            CBAnswerB.Checked = false;
            CBAnswerC.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter(FileCreate()))
            {
                for(int i=0;i<ListCauHoi.Count();i++)
                {
                    tw.WriteLine(ListCauHoi[i].Content);
                    foreach (string chonLua in ListCauHoi[i].DanhSachCauTraLoi)
                    {
                        tw.WriteLine(chonLua);
                    }
                    tw.WriteLine(ListCauHoi[i].Answer);
                }
            }
        }


        //TimeWaitForClient
        void timeX_Tick(object sender, EventArgs e)
        {
            OrigTime--;
            lbNextGameTime.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            if (OrigTime <= 0)
            {
                gameTimer.Enabled = false;
                ScheduleToClient.Stop();
                lbNextGame.Text = "Start in ";
                OrigTime = (int)Math.Round((DateTime.Now.AddSeconds(ThoiGianBatDau) -DateTime.Now).TotalSeconds, 0);
                gamestartAfter.Enabled = true;
                List<Connection> clientList = new List<Connection>();

                IsListen = true;
                ServerSocket = new TcpListener(IPAddress.Any, 13000);
                ServerSocket.Start();

                //Nhận thông tin từ client
                Thread thread = new Thread(XuLyKetNoi);

                thread.Start();
                gamestartAfter.Interval = 1000;
                gamestartAfter.Tick += gamestartAfter_Tick;
               
                gamestartAfter.Enabled = true;
               

            }
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeX_Tick(sender, e);

        }
        //TimeBeforeNextGame
        private void gamestartAfter_Tick(object sender, EventArgs e)
        {
            
            gamestartafter_Tick(sender, e);

        }
      
        void gamestartafter_Tick(object sender, EventArgs e)
        {
            OrigTime--;
            lbNextGameTime.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            if (OrigTime <= 0)
            {
                gamestartAfter.Enabled = false;
                ServerSocket.Stop();
            }
        }

        //Server Start
        private void btnServer_Click(object sender, EventArgs e)
        {
           
            PnQuest.Visible = false;
            PnQuest.Enabled = false;
            PnSchedule.Visible = false;
            PnSchedule.Enabled = false;
            PnServer.Visible = true;
            PnServer.Enabled = true;
            //Khởi động Server

            using (StreamReader sr = new StreamReader(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Schedule.txt"))
            {
                gameTimer.Interval = 1000;
                gameTimer.Tick += GameTimer_Tick;
                string newline;
                newline = sr.ReadLine();            
                    var y = string.Join(".", newline.Split(',').Skip(1));
                    string[] values = y.Split('.');
                DateTime dateGame;
                dateGame = Convert.ToDateTime(values[1]);
                TimeSpan time = TimeSpan.Parse(values[2]);
                string dateAndTime;
                dateAndTime = values[1] + " " + values[2];
                DateTime newDateGame;
                newDateGame = Convert.ToDateTime(dateAndTime);
                while(newDateGame<DateTime.Now)
                {
                    
                    newline = sr.ReadLine();
                    var b  = string.Join(".", newline.Split(',').Skip(1));
                     values = b.Split('.');
                    dateGame = Convert.ToDateTime(values[1]);
                     time = TimeSpan.Parse(values[2]);            
                    dateAndTime = values[1] + " " + values[2];
                    newDateGame = Convert.ToDateTime(dateAndTime);
                }
                lbNextGameTime.Text = newDateGame.ToString(("dd/MM/yyyy hh:mm:ss"));
                OrigTime = (int)Math.Round((newDateGame - DateTime.Now).TotalSeconds, 0);
                gameTimer.Enabled = true;
                ScheduleToClient = new TcpListener(IPAddress.Any, 14000);
                ScheduleToClient.Start();
                Thread threadSchedule = new Thread(SendScheduleToClient);
                threadSchedule.Start();
                

            }

          
            
        }
    
        //Send Schedule to Client
        void SendScheduleToClient()
        {

            byte[] bytes = new byte[1024];
           
            ScheduleGame SCG = null;
            
            using (StreamReader sr = new StreamReader(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Schedule.txt"))
            {
                string newline;
                while ((newline = sr.ReadLine()) != null)
                {
                    SCG = new ScheduleGame();
                    var y = string.Join(".", newline.Split(',').Skip(1));
                    string[] values = y.Split('.');

                    SCG.NameGame = values[0];
                    SCG.Date = values[1];
                    SCG.Time = values[2];
                    SendSchedule.Add(SCG);


                }

                bool Outloop = true;
                while (Outloop == true)
                {
                    try
                    {


                        TcpClient client = ScheduleToClient.AcceptTcpClient();
                        ns = client.GetStream();

                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(ns, SendSchedule);
                        client.Close();

                    }
                    catch (Exception e)
                    {
                        if (e is InvalidOperationException || e is SocketException)
                        {
                            Outloop = false;
                        }


                    }
                }
            }
            
            
        }
        //Send Question to client and open receive point
        void XuLyKetNoi()
        {
            try
            {
                while (serversocketStop==false)
                {
                    
                    byte[] bytes = new byte[1024];
                    this.SetText("Waiting for client");
                   
                    //RTBServer.Text = "Waiting for client";
                    TcpClient client = ServerSocket.AcceptTcpClient();
                    numclient++;
                    this.SetText("User" + client.Client.Handle + " connected");
                    ClientConnect[numclient] = new Connection();
                    ClientConnect[numclient].client = client;
                    ClientConnect[numclient].ns = client.GetStream();  
                    BinaryFormatter binform = new BinaryFormatter();
                    ClientConnect[numclient].name= (string)binform.Deserialize(ClientConnect[numclient].ns);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ClientConnect[numclient].ns, lstCauHoi);
                    Thread Receive = new Thread(DoWork);
                    Receive.IsBackground = true;
                    Receive.Start(client);
                   

                    //this.SetText("User "+ client.Client.Handle+ " connected") ;

                    //if (!_danhSachPlayer.ContainsKey(client.Client.Handle))
                    //    _danhSachPlayer.Add(client.Client.Handle, client);

                    //Console.WriteLine("User {0} connected", client.Client.Handle);
                    ////Nhận và gởi thông tin giữa server và client
                    //NetworkStream stream = client.GetStream();
                    //byte[] buffer = new byte[1024];
                    //int byte_count = stream.Read(buffer, 0, buffer.Length);

                    //string data = Encoding.ASCII.GetString(buffer, 0, byte_count);
                    //Console.WriteLine(data);

                    //Server gởi thông tin cho Client
                    //byte[] msg = Encoding.ASCII.GetBytes(data + Environment.NewLine);
                    //stream.Write(msg, 0, buffer.Length);
                    //Gởi object(Câu hỏi) xuống client


                }
            }
            catch(Exception e)
            {
                this.SetText(e.Message);
                clientList = new List<Connection>();
                ServerSocket = new TcpListener(IPAddress.Any, 13000);
            }
            finally
            {
                ReceivePoint = new TcpListener(IPAddress.Any, 15000);
                ReceivePoint.Start();
                Thread T_ReceivePoint = new Thread(ReceivePointFromClient);
                T_ReceivePoint.Start();
                //ReceivePoint = new TcpListener(IPAddress.Any, 14000);
                //ReceivePoint.Start();
                //Thread threadReceivePoint = new Thread(ReceivePointFromClient);
                //threadReceivePoint.Start();




            }
        }
        //ChatBox
        public void DoWork(object obj)
        {
            TcpClient client = obj as TcpClient;
            int myTaskNumber = numclient;

            ns = client.GetStream();
            try
            {
                while (true)
                {
                    byte[] bytes = new byte[1024];
                    String mess;

                    int bytesRead = ns.Read(bytes, 0, bytes.Length);



                    mess = Encoding.ASCII.GetString(bytes, 0, bytesRead);

                    String ss = /*client.Client.Handle*/ ClientConnect[myTaskNumber].name + ":" + mess;

                    this.SetTextChat(ss);

                    bytes = Encoding.ASCII.GetBytes(ss);

                    for (int i = 0; i < ClientConnect.Count(); i++)
                    {
                        if (ClientConnect[i] != null)
                        {

                            ClientConnect[i].ns.Write(bytes, 0, bytes.Length);
                        }
                    }
                }

            }
            catch
            {
                this.SetText("Client " + client.Client.Handle + " Disconect");
                client.Close();
                client = null;
                ClientConnect[myTaskNumber].client.Close();
                ClientConnect[myTaskNumber] = null;
            }
        }
     
      //ReceivePoint from client
        private async void ReceivePointFromClient()
        {

            while (true)
            {
                TcpClient clientPoint = ReceivePoint.AcceptTcpClient();
                ClientPoint++;
                ClientConnectPoint[ClientPoint] = new Connection();
                ClientConnectPoint[ClientPoint].client = clientPoint;
                ClientConnectPoint[ClientPoint].ns = clientPoint.GetStream();

                Player User = new Player();
                byte[] bytes = new byte[1024];

                await Task.Delay(5000);
                ClientConnectPoint[ClientPoint].ns.Read(bytes, 0, bytes.Length);
                MemoryStream memStream = new MemoryStream();
                BinaryFormatter binForm = new BinaryFormatter();
                memStream.Write(bytes, 0, bytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                User = (Player)binForm.Deserialize(memStream);
                ListPoint.Add(User);
                await Task.Delay(2000);
                if (!ReceivePoint.Pending())
                {
                    break;
                }
            }
            List<Player> SortedList = ListPoint.OrderByDescending(o => o.Point).ToList();
            for (int i = 0; i < ClientConnectPoint.Count(); i++)
            {
                if (ClientConnectPoint[i] != null)
                {

                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ClientConnectPoint[i].ns, SortedList);
                }
            }


        }


     //invoke RTB Server
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.

            if (this.RTBServer.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);

                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.RTBServer.Text = this.RTBServer.Text + text + "\r\n";

            }           
        }
        // invoke RTB chatbox
        private void SetTextChat(string text)
        {
            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.
            if (this.RTBChat.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextChat);

                this.Invoke(d, new object[] { text });
            }
            else

            {
                this.RTBChat.Text = this.RTBChat.Text + text + "\r\n";
            }
        }
       

        //Load Quest
        private void btnLoadQuest_Click(object sender, EventArgs e)
        {
            LayDanhSachCauHoi();
        }
        private void LayDanhSachCauHoi()
        {
            string fullPath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\DanhSachCauHoi.txt");
            StreamReader sr = new StreamReader(fullPath);
            string line = null;
            Question cauHoi = null;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("@"))
                {
                    cauHoi = new Question();
                    cauHoi.Content = line.Substring(1);
                }
                if (line.StartsWith("&"))
                {
                    cauHoi.DanhSachCauTraLoi.Add(line.Substring(1));
                }
                if (line.StartsWith("#"))
                {
                    cauHoi.Answer = line.Substring(1);

                    lstCauHoi.Add(cauHoi);
                }
            }
        }
        //Input Schedule
        private void GrvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // If any cell is clicked on the Second column which is our date Column  
            if (e.ColumnIndex == 1 )
            {
                //Initialized a new DateTimePicker Control  
                oDateTimePicker = new DateTimePicker();

                //Adding DateTimePicker control into DataGridView   
                GrvSchedule.Controls.Add(oDateTimePicker);

                // Setting the format (i.e. 2014-10-10)  
                oDateTimePicker.Format = DateTimePickerFormat.Short;



                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = GrvSchedule.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                // An event attached to dateTimePicker Control which is fired when any date is selected  
                oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // Now make it visible  
                oDateTimePicker.Visible = true;
            }
            if(e.ColumnIndex == 2)
            {
                //Initialized a new DateTimePicker Control  
                oDateTimePicker = new DateTimePicker();

                //Adding DateTimePicker control into DataGridView   
                GrvSchedule.Controls.Add(oDateTimePicker);

                // Setting the format (i.e. 2014-10-10)  
                oDateTimePicker.Format = DateTimePickerFormat.Custom;
                oDateTimePicker.CustomFormat = "HH:mm:ss";

                oDateTimePicker.ShowUpDown = true;



                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = GrvSchedule.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                // An event attached to dateTimePicker Control which is fired when any date is selected  
                oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // Now make it visible  
                oDateTimePicker.Visible = true;
               
            }


        }
        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            GrvSchedule.CurrentCell.Value = oDateTimePicker.Text.ToString();
        }
        void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use   
            oDateTimePicker.Visible = false;
        }

        //Quit
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsListen == true)
            { ServerSocket.Stop(); }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (IsListen == true)
            {
                this.Close();
            }
        }
        bool AdminChat = false;
     
    }
}
