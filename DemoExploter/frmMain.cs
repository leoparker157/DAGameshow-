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

        List<Question> lstQuestions = new List<Question>();
        private void LayDanhSachCauHoi()
        {
            StreamReader sr = new StreamReader(duongDan);
            
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

                    lstQuestions.Add(cauHoi);
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            t = new Thread(DoWork);
            t.Start();

            LayDanhSachCauHoi();

            rtbNoiDung.Text = lstQuestions[0].Content;
        }

        public void DoWork()
        {
            byte[] bytes = new byte[1024];

            listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();

            client = listener.AcceptTcpClient();

            ns = client.GetStream();

            while (true)
            {
                int bytesRead = ns.Read(bytes, 0, bytes.Length);
                this.SetText(Encoding.ASCII.GetString(bytes, 0, bytesRead));
                //MessageBox.Show(Encoding.ASCII.GetString(bytes, 0, bytesRead));

            }

        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {

            // InvokeRequired required compares the thread ID of the

            // calling thread to the thread ID of the creating thread.

            // If these threads are different, it returns true.

            if (this.textBox1.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetText);

                this.Invoke(d, new object[] { text });

            }

            else

            {

                this.textBox1.Text = this.textBox1.Text + text;

            }

        }

        Question curQuestion = null;
        int questionNum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            questionNum++;
            curQuestion = lstQuestions[questionNum];
            HienThiCauHoi(curQuestion);

            //String s = textBox2.Text;

            byte[] byteTime = Utils.ObjectToByteArray(curQuestion);

            //byte[] byteTime = Encoding.ASCII.GetBytes(s);

            ns.Write(byteTime, 0, byteTime.Length);
        }

        void HienThiCauHoi(Question question)
        {
            rtbNoiDung.Text = question.Content;

            ///
        }
    }
}
