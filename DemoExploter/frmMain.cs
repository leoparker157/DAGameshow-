using DTOProj;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Linq.Expressions;

namespace DemoExploter
{
    public enum GAMESHOW_STATE
    {
        GAMESHOW_START ,
        GAMESHOW_INPROCESS ,
        GAMESHOW_PENDING,
        GAMESHOW_END 
    }
    public partial class frmMain : Form
    {
        TcpListener listener;

        TcpClient client;

        NetworkStream ns;

        Thread t = null;
        public frmMain()
        {
            InitializeComponent();
        }
       
        string duongDan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+ "\\DanhSachCauHoi.txt";

        
        private System.Windows.Forms.Timer timer1;
        private int counter = 5;
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            PnEndGame.Enabled = false;
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;

            pictureBox2.Enabled = false;
            pictureBox2.Visible = false;
            t = new Thread(DoWork);
            t.Start();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            lbBeforeGameTime.Text = counter.ToString();
            

            
        }

        private const string hostName = "LocalHost";
        List<Question> lstQuestionsfromServer = new List<Question>();

        public void DoWork()
        {
            byte[] bytes = new byte[1024];

            //listener = new TcpListener(IPAddress.Any, 13000);
            //listener.Start();
            client = new TcpClient(Dns.GetHostName(), 13000);
            ns = client.GetStream();

            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            ns.Read(bytes, 0, bytes.Length);
            memStream.Write(bytes, 0, bytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            lstQuestionsfromServer = (List<Question>)binForm.Deserialize(memStream);


            while (true)
            {
                
                int bytesRead = ns.Read(bytes, 0, bytes.Length);
                this.SetText(Encoding.ASCII.GetString(bytes, 0, bytesRead));
                //MessageBox.Show(Encoding.ASCII.GetString(bytes, 0, bytesRead));

            }

        }
        private void btnBeforeGameSend_Click(object sender, EventArgs e)
        {
            string text = TBChatClient.Text;
            byte[] byteTime = Encoding.ASCII.GetBytes(text);
            ns.Write(byteTime, 0, byteTime.Length);
        }


        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            
            if (this.RTBChatClient.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetText);

                this.Invoke(d, new object[] { text });

            }

            else

            {

                this.RTBChatClient.Text = this.RTBChatClient.Text + text + "\r\n";

            }

            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.

            //if (this.textBox1.InvokeRequired)

            //{

            //    SetTextCallback d = new SetTextCallback(SetText);

            //    this.Invoke(d, new object[] { text });

            //}

            //else

            //{

            //    this.textBox1.Text = this.textBox1.Text + text;

            //}

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
          
           
            counter--;
            if (counter == 0)
            {
                StartGame();
                timer1.Stop();
                PnBeforeGame.Visible = false;
                PnBeforeGame.Enabled = false;
                
            }
            lbBeforeGameTime.Text = counter.ToString();
        }
        private async void timer2_Tick(object sender, EventArgs e)
        {


            counterGame--;
            if (counterGame == 0)
            {


                questionNum++;
                timer2.Stop();
                if (questionNum < lstQuestionsfromServer.Count)
                {
                    if (TrueOrWrong == true)
                    {
                        pictureBox1.Visible = true;
                        pictureBox1.Enabled = true;
                        await Task.Delay(5000);
                    }
                    else
                    {
                        pictureBox2.Visible = true;
                        pictureBox2.Enabled = true;
                        await Task.Delay(5000);
                    }
                    pictureBox1.Visible = false;
                    pictureBox1.Enabled = false;
                    pictureBox2.Visible = false;
                    pictureBox2.Enabled = false;
                    
                    lbPoint.Text = point.ToString();
                   
                    StartGame();
                }
                else
                {
                    if (TrueOrWrong == true)
                    {
                        pictureBox1.Visible = true;
                        pictureBox1.Enabled = true;
                        await Task.Delay(5000);
                    }
                    else
                    {
                        pictureBox2.Visible = true;
                        pictureBox2.Enabled = true;
                        await Task.Delay(5000);
                    }
                    EndGame();
                }
            }
            lbTimelimit.Text = counterGame.ToString();
        }
    


        void HienThiCauHoi(Question question)
        {
            PnBeforeGame.Visible = false;
            rtbNoiDung.Text = question.Content;
            Random rnd = new Random();
            string[] MyRandomArray = listRandomAnswer.OrderBy(x => rnd.Next()).ToArray();
            for (int i = 0; i < listRandomAnswer.Count; i++)
            {
                Controls.Find("btnChoose" + (i + 1), true).FirstOrDefault().Text = MyRandomArray[i];
            }
            ///
        }
       
        private void button2_Click(object sender, EventArgs e)
        {

        }
      
       

        private void lbBeforeGameTime_Click(object sender, EventArgs e)
        {

        }
        Question curQuestion = null;
        
        int questionNum = 0;
        
        List<string> listRandomAnswer = new List<string>();
        private System.Windows.Forms.Timer timer2;
        int point = 0;
        
        private int counterGame = 15;
        private void StartGame()
        {
            counterGame = 15;
            listRandomAnswer.Clear();
            curQuestion = new Question();
            curQuestion = lstQuestionsfromServer[questionNum];
            foreach (var random in curQuestion.DanhSachCauTraLoi)
            {
                listRandomAnswer.Add(random.ToString());
            }
            listRandomAnswer.Add(curQuestion.Answer);
            HienThiCauHoi(curQuestion);
            
                
                timer2 = new System.Windows.Forms.Timer();
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Interval = 1000; // 1 second
                timer2.Start();
            btnChoose1.Enabled = true;
            btnChoose2.Enabled = true;
            btnChoose3.Enabled = true;
            btnChoose4.Enabled = true;

        }
        private void EndGame()
        {
            PnGame.Enabled = false;
            PnGame.Visible = false;
            PnEndGame.Enabled = true;
            PnEndGame.Visible = true;
            PBGameOver.Visible = true;
            switch(lbPoint.Text)
            {
                case "10":
                    PBPoint.Image = Properties.Resources._10;
                    PBPoint.Visible = true;
                    break;
                case "20":
                    PBPoint.Image = Properties.Resources._20;
                    PBPoint.Visible = true;
                    break;
                case "30":
                    PBPoint.Image = Properties.Resources._30;
                    PBPoint.Visible = true;
                    break;
                case "40":
                    PBPoint.Image = Properties.Resources._40;
                    PBPoint.Visible = true;
                    break;
                case "50":
                    PBPoint.Image = Properties.Resources._50;
                    PBPoint.Visible = true;
                    break;
                case "60":
                    PBPoint.Image = Properties.Resources._60;
                    PBPoint.Visible = true;
                    break;
                case "70":
                    PBPoint.Image = Properties.Resources._70;
                    PBPoint.Visible = true;
                    break;
                case "80":
                    PBPoint.Image = Properties.Resources._80;
                    PBPoint.Visible = true;
                    break;
                case "90":
                    PBPoint.Image = Properties.Resources._90;
                    PBPoint.Visible = true;
                    break;
                case "100":
                    PBPoint.Image = Properties.Resources._100;
                    PBPoint.Visible = true;
                    break;

            }
        }
        bool TrueOrWrong = false;
        private void btnChoose1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if(clickedButton.Text==curQuestion.Answer)
            {

                point += 10;
                TrueOrWrong = true;
            }
            else
            {
                TrueOrWrong = false;
            }
            btnChoose1.Enabled = false;
            btnChoose2.Enabled = false;
            btnChoose3.Enabled = false;
            btnChoose4.Enabled = false;
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            PnEndGame.Enabled = false;
            client.Close();
            this.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            client.Close();
           
        }
        
    }
}
