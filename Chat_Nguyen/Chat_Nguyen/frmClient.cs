using System;
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

namespace Chat_Nguyen
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            time.Start();
            Addemoji();
            listView1.Visible = false;
        }
        Socket Client;
        IPAddress diaChiIP;
        IPEndPoint diaChiEP;
        int cong = 0;
        string TG = "";
        int id = 0;

        private void ketNoi()
        {
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.cong = Int32.Parse(txtcong.Text);
            this.diaChiIP = IPAddress.Parse("192.168.1.1");
            this.diaChiEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), Int32.Parse(txtcong.Text));
            Client.Connect(this.diaChiEP);

            Thread nhan = new Thread(AddToServer);
            nhan.IsBackground = true;
            nhan.Start();
            lbconnet.ForeColor = Color.DarkGreen;
            lbconnet.Text = "Online!";
            lbconnetsv.ForeColor = Color.DarkGreen;
            lbconnetsv.Text = "Đã kết nối với Sever!";
            btnketnoi.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "")
                {
                    lbAvatar.Text = txtName.Text[0].ToString();
                    panel3.Enabled = true;
                    btnCall.Enabled = true;
                    btnface.Enabled = true;
                    btnSend.Enabled = true;
                    tsMenusend.Enabled = true;
                    rtxnhap.Enabled = true;
                    txtcong.Enabled = false;
                    txtName.Enabled = false;
                    ketNoi();
                }
                else
                {
                    MessageBox.Show("vui lòng nhập tên!");
                }
            } catch (Exception)
            {
                MessageBox.Show("Server đang ngoại tuyến. \nHoặc PORT sai!");
                panel3.Enabled = false;
                btnCall.Enabled = false;
                btnface.Enabled = false;
                btnSend.Enabled = false;
                tsMenusend.Enabled = false;
                rtxnhap.Enabled = false;
            }
        }
        public object GiaiMa(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            return bf.Deserialize(ms);
        }


        void listclient(string a)
        {
            LbFriend.Items.Clear();
            string[] b = a.Split('+');
            string[] d = b[b.Length - 1].Split(' ');
            LbFriend.Items.Add("Gửi Tất Cả");
            foreach (string c in d)
            {
                if (c == txtName.Text) { continue; }
                if (c != "") LbFriend.Items.Add(c);

            }
        }
        // vao thu muc n client
        //#####+ gửi rieng
        private void AddToServer()
        {
            try
            {
                Gui("[" + TG + "] " + txtName.Text + ":  " + " Đã kết nối");
                while (true)
                {
                    byte[] nhan = new byte[1024 * 5000];
                    Client.Receive(nhan);
                    object obj = GiaiMa(nhan);
                    if (obj.GetType().ToString() == "System.String")
                    {
                        string a = (String)GiaiMa(nhan);
                        // lay danh sach sẻver gửi qua
                        if (a.Contains("-----+"))
                        {
                            listclient(a);
                            continue; // bỏ qua vòng lập cho nó khỏi in ra
                        }

                        LVNhan.Items.Add(a).ForeColor = Color.DarkRed;
                    }
                    else if (obj.GetType().ToString() == "System.Drawing.Bitmap")
                    {
                        id++;
                        Image image = (Image)GiaiMa(nhan);
                        imgAnh.Images.Add(id + "", image);
                        ListViewItem item = new ListViewItem();
                        item.ImageKey = id + "";
                        LVNhan.Items.Add(item);
                    }
                    LVNhan.EnsureVisible(LVNhan.Items.Count - 1);

                }
            }
            catch
            {

            }
        }

        byte[] MaHoa(object obj)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        void Gui(String s)
        {
            try
            {
                if (Client == null) return;
                byte[] gui = new byte[1024 * 5000];
                gui = MaHoa(s);
                Client.Send(gui);
            }
            catch (Exception)
            {
                MessageBox.Show("Server ngoại tuyến!");
            }
        }

        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Client != null)
            {
                Gui("[" + TG + "] " + txtName.Text + ":  " + " Đã thoát kết nối");
                Client.Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            if (Client == null || this.rtxnhap.Text.Length <= 0) return;
            try
            {
                if (this.rtxnhap.Text.Length > 0)
                {
                    // nếu index <= 0 thì cho nó gửi cho server 
                    byte[] gui = new byte[1024 * 5000];

                    if (getIndexName <= 0)
                    {

                        gui = MaHoa("[" + TG + "] " + txtName.Text + ":  " + this.rtxnhap.Text);
                        Client.Send(gui);
                        LVNhan.Items.Add("[" + TG + "] " + txtName.Text + ":  " + this.rtxnhap.Text).ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        // gửi riêng cho client #####+ có cái ni là tin gửi riêng thiếu cái tên nữa
                        gui = MaHoa(LbFriend.Items[getIndexName].ToString() + "#####+" + "[" + TG + "] " + txtName.Text + ":  " + this.rtxnhap.Text);
                        Client.Send(gui);
                        LVNhan.Items.Add("[" + TG + "] " + txtName.Text + ":  " + this.rtxnhap.Text).ForeColor = Color.DarkBlue;
                    }

                }
            }
            catch
            {

            }
            rtxnhap.Clear();
            LVNhan.EnsureVisible(LVNhan.Items.Count - 1);
        }

        private void time_Tick(object sender, EventArgs e)
        {
            TG = DateTime.Now.ToString("HH:mm:ss: dd/MM/yyyy");
        }

        private void Images_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            if (Client == null) return;
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
                        byte[] gui = new byte[1024];
                        gui = MaHoa(" [" + TG + "] " + txtName.Text + ": " + "Đã gửi 1 ảnh");
                        Client.Send(gui);
                        byte[] nhan = new byte[1024 * 5000];
                        nhan = MaHoa(Image.FromFile(fileName));
                        Client.Send(nhan); // gửi ảnh cho serverS
                        id++;
                        Image image = (Image)Image.FromFile(fileName);
                        imgAnh.Images.Add(id + "", image);
                        ListViewItem item = new ListViewItem();
                        item.ImageKey = id + "";
                        LVNhan.Items.Add("[" + TG + "] " + txtName.Text + ": Đã gửi 1 ảnh").ForeColor = Color.DarkGreen;
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
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedIndices.Count <= 0) return;
                if (listView1.FocusedItem == null) return;
                ide = listView1.SelectedIndices[0];
                if (ide < 0) return; // nếu mà id = 0 tức là ảnh lỗi hoặc chưa có ảnh nên cho qua
                byte[] gui = new byte[1024];
                gui = MaHoa(" [" + TG + "] " + txtName.Text + ": " + "Đã gửi 1 Icon");
                Client.Send(gui);
                byte[] nhan = new byte[1024 * 5000];
                nhan = MaHoa(imgEmoji.Images[ide]);
                Client.Send(nhan);
                id++;
                Image image = (Image)imgEmoji.Images[ide];
                imgAnh.Images.Add(id + "", image);
                ListViewItem item = new ListViewItem();
                item.ImageKey = id + "";
                LVNhan.Items.Add("[" + TG + "] " + txtName.Text + ": Đã gửi 1 Icon").ForeColor = Color.DarkGreen;
                LVNhan.Items.Add(item);
                LVNhan.EnsureVisible(LVNhan.Items.Count - 1);
            }
            catch
            {

            }
        }
        private void Addemoji()
        {
            string duongDan = Environment.CurrentDirectory.ToString(); // lấy đường dẫn thư mục
            var url = Directory.GetParent(Directory.GetParent(duongDan).ToString()); // lấy thư mục cha
            string path = url + @"\emoji"; // lấy đường dẫn

            string[] files = Directory.GetFiles(path); // lấy tên file là ảnh

            foreach (String f in files)
            {
                Image img = Image.FromFile(f);  // từ cái file đó chuyển qua định dạng ảnh
                imgEmoji.Images.Add(img); // bỏ vào img list
            }
            this.listView1.View = View.LargeIcon; // thuộc tính ảnh to hay nhỏ
            this.imgEmoji.ImageSize = new Size(20, 20); //size

            this.listView1.LargeImageList = this.imgEmoji; // ép thuộc tính vào listvieww
            // ép ảnh vào list vieww
            for (int i = 0; i < this.imgEmoji.Images.Count; i++)
            {
                this.listView1.Items.Add(" ", i);
            }

        }
        private bool check = true;

        private void Emoji_Click(object sender, EventArgs e)
        {
            if (Client == null) return;
            if (check)
            {
                listView1.Visible = check;
                check = false;
            }
            else
            {
                listView1.Visible = check;
                check = true;
            }
        }

        private void file_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            if (Client == null) return;
            OpenFileDialog s = new OpenFileDialog();
            s.Filter = "Open File (*.rar)|*.rar|(*.exe)|*.exe|(*.zip)|*.zip|(*.txt)|*.txt|(*.doc)|*.doc|(*.pdf)|*.pdf";
            if (s.ShowDialog() == DialogResult.OK)
            {

            }
        }


        private void rtxnhap_TextChanged(object sender, EventArgs e)
        {
            listView1.Visible = false;
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

        private void txtcong_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcong.Text, " ^ [0-9]"))
            {
                txtcong.Text = "";
            }
        }

        private void txtcong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            btnCall.Enabled = false;
            btnface.Enabled = false;
            tsMenusend.Enabled = false;
            btnSend.Enabled = false;
            rtxnhap.Enabled = false;
        }
        //ok
        int getIndexName = 0;
        private void LbFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbFriend.SelectedIndices.Count < 0) return;
            // này là lấy id được chọn
            getIndexName = LbFriend.SelectedIndices[0];
            label1.Text = LbFriend.Items[getIndexName].ToString();
            LbAnhdd.Text = label1.Text[0].ToString();
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
    }
}
