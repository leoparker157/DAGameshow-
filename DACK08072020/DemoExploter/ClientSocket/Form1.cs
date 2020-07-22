using DTOProj;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSocket
{
    public partial class Form1 : Form
    {
        private const int portNum = 13000;

        delegate void SetTextCallback(string text);

        TcpClient client;
        NetworkStream ns;
        Thread t = null;

        private const string hostName = "localhost";

        public Form1()
        {
            InitializeComponent();

            client = new TcpClient(hostName, portNum);

            ns = client.GetStream();

            String s = "Connected";

            byte[] byteTime = Encoding.ASCII.GetBytes(s);

            ns.Write(byteTime, 0, byteTime.Length);

            t = new Thread(DoWork);

            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            String s = textBox2.Text;

            byte[] byteTime = Encoding.ASCII.GetBytes(s);

            ns.Write(byteTime, 0, byteTime.Length);
        }

        // This is run as a thread

        public void DoWork()
        {

            byte[] bytes = new byte[1024];

            while (true)
            {

                int bytesRead = ns.Read(bytes, 0, bytes.Length);

                var question = (Question)Utils.ByteArrayToObject(bytes);

                this.SetText(question.Content);

                //MessageBox.Show(Encoding.ASCII.GetString(bytes, 0, bytesRead));

            }

        }

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
    }
}
