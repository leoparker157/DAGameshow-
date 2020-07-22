using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSocket
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);

        TcpListener listener;

        TcpClient client;

        NetworkStream ns;

        Thread t = null;
        public Form1()
        {
            InitializeComponent();

            t = new Thread(DoWork);
            t.Start();
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

        public void DoWork()
        {
            byte[] bytes = new byte[1024];

            listener = new TcpListener(IPAddress.Any, 13000);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = textBox2.Text;

            byte[] byteTime = Encoding.ASCII.GetBytes(s);

            ns.Write(byteTime, 0, byteTime.Length);
        }
    }
}
