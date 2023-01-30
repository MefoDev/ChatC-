using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Nguyen
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            time.Start();
            chenEmoji();
            LbUser.Items.Add("Gửi cho tất cả");
            LVemoji.Visible = false;
        }
        Hashtable quanLyKetNoi = new Hashtable();
        Socket server;
        Socket client;
        List<Socket> maykhachAdd;
        IPAddress diaChiIP;
        IPEndPoint diaChiEP;
        int cong = 0;
        string TG = "";
        private void batDau()
        {
            try
            {
                maykhachAdd = new List<Socket>();
                lbtrangthai.Text = "Server đang Trực tuyến!" ;
                lbtrangthai.ForeColor = Color.DarkGreen;
                while (true)
                {
                    server.Listen(10);
                    client = server.Accept();
                    maykhachAdd.Add(client);
                    
                    Nhanten();
                    Thread s1 = new Thread(nhanclient);
                    s1.IsBackground = true;
                    s1.Start(client);
                }
            }
            catch
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                diaChiEP = new IPEndPoint(diaChiIP, 12345);
            }
        }
        List<string> tenClient = new List<string>();
     
        void Nhanten()
        {
            byte[] nhan = new byte[1024];
            client.Receive(nhan);
            object objA = GiaiMa(nhan);

            String s = (String)GiaiMa(nhan);

            
            LVNhan.Items.Add(s).ForeColor=Color.DarkRed;
            LVNhan.EnsureVisible(LVNhan.Items.Count - 1);

            string[] tach = s.Split(']');
            string[] tach1 = tach[tach.Length - 1].Split(':');
            tenClient.Add(tach1[0].Trim());
            
            LbUser.Items.Add(tach1[0]);
            GuiDanhSach();

        }
        /*
         * 
         * -----+ mã hóa gửi danh sách qua client
         * 
         * */
        void GuiDanhSach()
        {
            byte[] gui = new byte[1024 * 5000];

            string mh = "";
            foreach (string s in tenClient)
            {
                mh = mh + s + " ";
            }
            
            mh = "-----+" + mh.Trim();
            gui = MaHoa(mh);
            try
            {
                foreach (Socket mk in maykhachAdd)
                {
                    if (mk != null)
                    {
                        mk.Send(gui);
                    }

                }
            }
            catch
            {

            }
        }



        private int id = -1; 
        void Guirieng(string a)
        {

            String[] a1 = a.Split('#'); 
            int i = tenClient.IndexOf(a1[0]); 
            string[] a2 = a.Split('+'); 
            LVNhan.Items.Add(a2[a2.Length-1]).ForeColor=Color.DarkBlue;
            LVNhan.EnsureVisible(LVNhan.Items.Count - 1);

            if (i < 0)
            {
                return;
            }
            
            byte[] gui = new byte[1024 * 5000];
            gui = MaHoa(a2[a2.Length - 1]);
            maykhachAdd[i].Send(gui);
        }
        private void nhanclient(object obj)
        {
            Socket mayKhach = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] nhan = new byte[1024 * 5000];
                    mayKhach.Receive(nhan);
                    object objA = GiaiMa(nhan);
                    
                    if (objA.GetType().ToString() == "System.String")
                    {
                        string a = (String)GiaiMa(nhan);
                        if (a.Contains("#####+"))
                        {
                            Guirieng(a);
                            continue;
                        }
                        LVNhan.Items.Add(a).ForeColor=Color.DarkRed;
                    }
                    else if (objA.GetType().ToString() == "System.Drawing.Bitmap")
                    {
                        id++;
                        Image image = (Image)GiaiMa(nhan);
                        imgAnh.Images.Add(id + "", image);
                        ListViewItem item = new ListViewItem();
                        item.ImageKey = id + "";
                        LVNhan.Items.Add(item);
                    }
                    foreach (Socket mk in maykhachAdd)
                    {
                        if (mk != null && mayKhach != mk)
                        {
                            mk.Send(nhan);
                        }
                    }
                    LVNhan.EnsureVisible(LVNhan.Items.Count - 1);
                }
            }
            catch
            {
                int i = maykhachAdd.IndexOf(mayKhach); 

                if (i < 0) return; 
                tenClient[i] = "";
                maykhachAdd[i] = null;// chay thu
                UpListUser(); 
                GuiDanhSach(); 
                mayKhach.Close();
            }
        }
        void UpListUser()
        {
            LbUser.Items.Clear();
            LbUser.Items.Add("Gửi cho tất cả");
            foreach(string s in tenClient)
            {
                if (s != "") LbUser.Items.Add(s); // nếu khác rỗng thì nó mới bỏ vào trong danh sách rứa cho nó đẹp
            }    
        }
        byte[] MaHoa(object obj)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }
        public object GiaiMa(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            return bf.Deserialize(ms);
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcong.Text, " ^ [0-9]"))
            {
                txtcong.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "START")
            {
                tsMenu.Enabled = true;
                btnSend.Enabled = true;
                rtxNhap.Enabled = true;
                panel1.Enabled = true;
                txtcong.Enabled = false;

                cong = Int32.Parse(txtcong.Text);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                diaChiIP = IPAddress.Any;
                diaChiEP = new IPEndPoint(diaChiIP, Int32.Parse(txtcong.Text));
                server.Bind(diaChiEP);
                Thread s = new Thread(batDau);
                s.IsBackground = true;
                s.Start();
                btnStart.BackColor = Color.DarkGreen;
                btnStart.Text = "STOP";
            }
            else
            {
                tsMenu.Enabled = false;
                btnSend.Enabled = false;
                rtxNhap.Enabled = false;
                panel1.Enabled = false;
                txtcong.Enabled = true;

                btnStart.BackColor = Color.DarkRed;
                btnStart.Text = "START";
                byte[] s = new byte[1024*5000];
                string s1 = "Server đóng kết nối";
                s = MaHoa(s1);
                foreach (Socket i in maykhachAdd)
                {
                    i.Send(s);
                }
                foreach (Socket i in maykhachAdd)
                {
                    i.Close();
                }    
                
                server.Close();
                lbtrangthai.Text = "Server đang ngoại tuyến!";
                lbtrangthai.ForeColor = Color.DarkRed; 
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.rtxNhap.Text.Length <= 0) return;
            byte[] gui = new byte[1024 * 5000];
            // neueus maf index = 0 or
            if (getIndexName <= 0)
            {
                foreach (Socket mk in maykhachAdd)
                {
                    if (mk != null)
                    {
                        gui = MaHoa("[" + TG + "] " + "BOT CHAT" + ":  " + rtxNhap.Text);
                        mk.Send(gui);
                        LVNhan.Items.Add("[" + TG + "] " + "BOT CHAT" + ":  " + this.rtxNhap.Text).ForeColor = Color.DarkGreen;

                    }
                }
            }
            else
            {
                string user = LbUser.Items[getIndexName].ToString().Trim();
                int i = tenClient.IndexOf(user);
                if (i < 0) return;
                gui = MaHoa("[" + TG + "] " + "BOT CHAT" + ":  " + rtxNhap.Text);
                maykhachAdd[i].Send(gui);
                LVNhan.Items.Add("[" + TG + "] " + "BOT CHAT" + ":  " + this.rtxNhap.Text).ForeColor = Color.DarkBlue;

            }
            rtxNhap.Clear();
            LVNhan.EnsureVisible(LVNhan.Items.Count - 1);
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server != null) server.Close();

        }

        private void time_Tick(object sender, EventArgs e)
        {
            TG = DateTime.Now.ToString("HH:mm:ss: dd/MM/yyyy");
        }

        private void Images_Click(object sender, EventArgs e)
        {
            LVemoji.Visible = false;
            if (server == null) return;
            OpenFileDialog Op_img = new OpenFileDialog();
            Op_img.Title = "Chọn ảnh";
            Op_img.Filter = "Hình ảnh|*.bmp;*.jpg;*.gif;*.png;*.tif";
            try
            {
                if (Op_img.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Op_img.FileName;
                    if (fileName.EndsWith(".tif") || fileName.EndsWith(".png") || fileName.EndsWith(".bmp") || fileName.EndsWith(".gif")
                        || fileName.EndsWith(".jpg"))
                    {

                        byte[] nhan = new byte[1024 * 5000];
                        if (getIndexName <= 0)
                        {

                            foreach (Socket mk in maykhachAdd)
                            {
                                if (mk != null)
                                {
                                    byte[] gui = new byte[1024];
                                    gui = MaHoa(" [" + TG + "] " + "BOT CHAT" + ":  " + "Đã gửi 1 ảnh");
                                    mk.Send(gui);
                                    nhan = MaHoa(Image.FromFile(fileName));
                                    mk.Send(nhan);

                                }
                            }
                        }
                        else
                        {
                            string user = LbUser.Items[getIndexName].ToString().Trim();
                            int i = tenClient.IndexOf(user);
                            if (i < 0) return;

                            byte[] gui = new byte[1024];
                            gui = MaHoa(" [" + TG + "] " + "BOT CHAT" + ":  " + "Đã gửi 1 ảnh");
                            maykhachAdd[i].Send(gui);
                            nhan = MaHoa(Image.FromFile(fileName));
                            maykhachAdd[i].Send(nhan);
                        }
                        id++;
                        Image image = (Image)GiaiMa(nhan);
                        imgAnh.Images.Add(id + "", image);
                        ListViewItem item = new ListViewItem();
                        item.ImageKey = id + "";
                        LVNhan.Items.Add( "[" + TG + "] "+ "BOT CHAT: Đã gửi 1 ảnh").ForeColor=Color.DarkGreen;
                        LVNhan.Items.Add(item);
                        LVNhan.EnsureVisible(LVNhan.Items.Count - 1);
                    }
                    else
                    {
                        MessageBox.Show("Định Dạng Ảnh Không hợp lệ", "Lỗi Định Dạng");

                    }
                }
            }
            catch
            {

            }
        }
        private int ide = 0;
        private void chenEmoji()
        {
            string duongDan = Environment.CurrentDirectory.ToString(); 
            var url = Directory.GetParent(Directory.GetParent(duongDan).ToString()); 
            string path = url + @"\emoji";

            string[] files = Directory.GetFiles(path); 

            foreach (String f in files)
            {
                Image img = Image.FromFile(f);  
                imgEmoji.Images.Add(img); 
            }
            this.LVemoji.View = View.LargeIcon; 
            this.imgEmoji.ImageSize = new Size(20, 20);

            this.LVemoji.LargeImageList = this.imgEmoji; 
            
            for (int i = 0; i < this.imgEmoji.Images.Count; i++)
            {
                this.LVemoji.Items.Add(" ", i);
            }

        }
        private bool check = true;

        private void Emoji_Click(object sender, EventArgs e)
        {
            if (client == null) return;
            if (check)
            {
                LVemoji.Visible = check;
                check = false;
            }
            else
            {
                LVemoji.Visible = check;
                check = true;
            }
        }

        private void LVemoji_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LVemoji.SelectedIndices.Count <= 0) return;
                if (LVemoji.FocusedItem == null) return;
                ide = LVemoji.SelectedIndices[0];
                if (ide < 0) return;
                byte[] nhan = new byte[1024 * 5000];
                foreach (Socket mk in maykhachAdd)
                {
                    if (mk != null)
                    {
                        byte[] gui = new byte[1024];
                        gui = MaHoa(" [" + TG + "] " + "BOT CHAT" + ": " + "Đã gửi 1 Icon");
                        mk.Send(gui); 
                        nhan = MaHoa(imgEmoji.Images[ide]);
                        mk.Send(nhan);

                    }
                    id++;
                    Image image = (Image)GiaiMa(nhan);
                    imgAnh.Images.Add(id + "", image);
                    ListViewItem item = new ListViewItem();
                    item.ImageKey = id + "";
                    LVNhan.Items.Add("[" + TG + "] " + "BOT CHAT: Đã gửi 1 Icon").ForeColor=Color.DarkGreen;
                    LVNhan.Items.Add(item);
                    LVNhan.EnsureVisible(LVNhan.Items.Count - 1);
                }
            }
            catch
            {

            }
        }

        private void File_Click(object sender, EventArgs e)
        {
            LVemoji.Visible = false;
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            LVemoji.Visible = false;
        }

        private void rtxNhap_TextChanged(object sender, EventArgs e)
        {
            LVemoji.Visible = false;
        }

        private void xoaChiMinhBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LVNhan.Items.Remove(LVNhan.SelectedItems[0]);
            }
            catch
            {
                MessageBox.Show("Chọn Tin nhắn muốn xóa!");
            }
        }

        private void Server_Load(object sender, EventArgs e)
        {
            tsMenu.Enabled = false;
            btnSend.Enabled = false;
            rtxNhap.Enabled = false;
            panel1.Enabled = false;
        }
        int getIndexName = 0;
        private void LbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LbUser.SelectedIndices.Count < 0) return;
                getIndexName = LbUser.SelectedIndices[0];
            }
            catch
            {

            }
        }

        private void thuHoiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult Deleteall = MessageBox.Show("Bạn muốn xóa toàn bộ tin nhắn?", "Xóa", MessageBoxButtons.YesNo);
            switch (Deleteall)
            {
                case DialogResult.No:
                    Close();
                    break;
                case DialogResult.Yes:
                    LVNhan.Clear();
                    break;
            }
        }

        private void chuyểnTiếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form1 s = new Form1(maykhachAdd, tenClient,object);
            //s.Show(this);
        }

        private void chuyeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
