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

        }
        delegate void SetTextCallback(string text);
        List<Question> lstCauHoi = new List<Question>();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
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
            GrvSchedule.Columns[2].Name = "End Date";
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
                dt.Columns.Add("End Date");

                string newline;
                while ((newline = sr.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    var y = string.Join(" ", newline.Split(',').Skip(1));
                    string[] values = y.Split(' ');
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
        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
        List<Question> ListCauHoi = new List<Question>();

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

        private void PnQuest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CBAnswerA_CheckedChanged(object sender, EventArgs e)
        {

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
        TcpListener ServerSocket = null;
        IPEndPoint IP;
        List<Connection> clientList;
        int numclient = -1;
        bool IsListen = false;
        private void btnServer_Click(object sender, EventArgs e)
        {
            PnQuest.Visible = false;
            PnQuest.Enabled = false;
            PnSchedule.Visible = false;
            PnSchedule.Enabled = false;
            PnServer.Visible = true;
            PnServer.Enabled = true;
            //Khởi động Server
           
            
            List<Connection> clientList = new List<Connection>();

            IsListen = true;
            ServerSocket = new TcpListener(IPAddress.Any, 13000);
            ServerSocket.Start();
            
            //Nhận thông tin từ client
            Thread thread = new Thread(XuLyKetNoi);
            
            thread.Start();
            
        }
        NetworkStream ns;
        Connection[] ClientConnect = new Connection[100];
        void XuLyKetNoi()
        {
            try
            {
                while (true)
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
                 
                    ClientConnect[numclient].ns.Write(MyLib.Utils.Serialize(lstCauHoi),0, MyLib.Utils.Serialize(lstCauHoi).Length);





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
        }
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
        public void DoWork(object obj)
        {
            TcpClient client = obj as TcpClient;
            int myTaskNumber = numclient;
            ns = client.GetStream();
            try {
                while (true)
                {
                    byte[] bytes = new byte[1024];
                    String mess;

                    int bytesRead = ns.Read(bytes, 0, bytes.Length);



                    mess = Encoding.ASCII.GetString(bytes, 0, bytesRead);

                    String ss = client.Client.Handle + ":" + mess;

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
        //private void LayDanhSachCauHoi()
        //{
        //    StreamReader sr = new StreamReader(duongDan);

        //    List<Question> lstCauHoi = new List<Question>();

        //    string line = null;
        //    Question cauHoi = null;
        //    while ((line = sr.ReadLine()) != null)
        //    {
        //        if (line.StartsWith("@"))
        //        {
        //            cauHoi = new Question();
        //            cauHoi.Content = line.Substring(1);
        //        }
        //        if (line.StartsWith("&"))
        //        {
        //            cauHoi.DanhSachCauTraLoi.Add(line.Substring(1));
        //        }
        //        if (line.StartsWith("#"))
        //        {
        //            cauHoi.Answer = line.Substring(1);

        //            lstCauHoi.Add(cauHoi);
        //        }
        //    }

        //    grvQuanLy.DataSource = lstCauHoi;
        //}
        public void SendQuestion()
        {
           
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
        private void btnLoadQuest_Click(object sender, EventArgs e)
        {
            LayDanhSachCauHoi();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsListen == true)
            { ServerSocket.Stop(); }
            
        }
    }
}
