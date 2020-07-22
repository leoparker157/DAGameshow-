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
    
    public partial class Form1 : Form
    {
        string duongDan = "H:\\projectnam2\\c#\\DACK08072020\\DanhSachCauHoi.txt";
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Question cauHoi = LayNoiDungCauHoi();
            if(cauHoi != null)
            {
                bool luuThanhCong = LuuVaoTapTin(cauHoi);
                if(luuThanhCong)
                {
                    MessageBox.Show("Lưu thành công");
                    LayDanhSachCauHoi();
                }
            }
        }

        private bool LuuVaoTapTin(Question cauHoi)
        {
            StreamWriter sw = new StreamWriter(duongDan, true);

            sw.WriteLine("@" + cauHoi.Content);
            foreach(string chonLua in cauHoi.DanhSachCauTraLoi)
            {
                sw.WriteLine("&" + chonLua);
            }
            sw.WriteLine("#" + cauHoi.Answer);

            sw.Close();

            return true;
        }

        private Question LayNoiDungCauHoi()
        {
            Question cauHoi = new Question();

            cauHoi.Content = rtbCauHoi.Text;
            cauHoi.DanhSachCauTraLoi = new List<string>();
            cauHoi.DanhSachCauTraLoi.Add(ucCauTraLoiA.NoiDung);
            cauHoi.DanhSachCauTraLoi.Add(ucCauTraLoiB.NoiDung);

            foreach(Control ctl in pnlCacChonLua.Controls)
            {
                ucCauTraLoi uc = (ucCauTraLoi)ctl;
                //Chọn lựa nào có check thì lấy ra
                if (uc.LaCauTraLoi) cauHoi.Answer = uc.NoiDung;
            }

            return cauHoi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LayDanhSachCauHoi();
        }

        private void LayDanhSachCauHoi()
        {
            StreamReader sr = new StreamReader(duongDan);

            List<Question> lstCauHoi = new List<Question>();

            string line = null;
            Question cauHoi = null;
            while ((line = sr.ReadLine()) != null)
            {
                if(line.StartsWith("@"))
                {
                    cauHoi = new Question();
                    cauHoi.Content = line.Substring(1);
                }
                if(line.StartsWith("&"))
                {
                    cauHoi.DanhSachCauTraLoi.Add(line.Substring(1));
                }
                if (line.StartsWith("#"))
                {
                    cauHoi.Answer = line.Substring(1);

                    lstCauHoi.Add(cauHoi);
                }
            }

            grvQuanLy.DataSource = lstCauHoi;
        }

        private void btnThemLuaChon_Click(object sender, EventArgs e)
        {
            ucCauTraLoi uc = new ucCauTraLoi();
            uc.Dock = DockStyle.Top;
            pnlCacChonLua.Controls.Add(uc);
        }

        private void btnChuyenCauHoi_Click(object sender, EventArgs e)
        {

        }

        TcpListener ServerSocket = null;
        private void btnKhoiDongServer_Click(object sender, EventArgs e)
        {
            //Khởi động Server
            ServerSocket = new TcpListener(IPAddress.Any, 5000);
            ServerSocket.Start();
            //Nhận thông tin từ client
            Thread thread = new Thread(XuLyKetNoi);
            thread.Start();
        }

        Dictionary<IntPtr, TcpClient> _danhSachPlayer = new Dictionary<IntPtr, TcpClient>();
        void XuLyKetNoi()
        {
            while (true)
            {
                TcpClient client = ServerSocket.AcceptTcpClient();

                if (!_danhSachPlayer.ContainsKey(client.Client.Handle))
                    _danhSachPlayer.Add(client.Client.Handle, client);

                Console.WriteLine("User {0} connected", client.Client.Handle);
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

        void GoiThongDiep(TcpClient client, string message)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            byte[] msg = Encoding.ASCII.GetBytes(message + Environment.NewLine);
            stream.Write(msg, 0, buffer.Length);
        }

        void GoiCauHoi()
        {
            Question ch = new Question();
            ch.Content = "1 + 1 = ?";
            ch.DanhSachCauTraLoi.Add("2");
            ch.DanhSachCauTraLoi.Add("3");
            ch.DanhSachCauTraLoi.Add("4");
            ch.Answer = "2";

            var msg = Utils.ObjectToByteArray(ch);
            //stream.Write(msg, 0, msg.Length);
        }

        private void btnDemoThread_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(HienThiThongBao);
            thread.Start();
        }

        void HienThiThongBao()
        {
            MessageBox.Show("I'm only one!!!!!");
        }
    }
}
