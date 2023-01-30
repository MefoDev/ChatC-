
namespace Chat_Nguyen
{
    partial class frmClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbFriend = new System.Windows.Forms.ListBox();
            this.txtcong = new System.Windows.Forms.TextBox();
            this.lbconnet = new System.Windows.Forms.Label();
            this.lbAvatar = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnketnoi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuHoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaChiMinhBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyenTiepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.LVNhan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgAnh = new System.Windows.Forms.ImageList();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnface = new System.Windows.Forms.Button();
            this.lbconnetsv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbAnhdd = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tsMenusend = new System.Windows.Forms.ToolStrip();
            this.Emoji = new System.Windows.Forms.ToolStripButton();
            this.file = new System.Windows.Forms.ToolStripButton();
            this.Images = new System.Windows.Forms.ToolStripButton();
            this.rtxnhap = new System.Windows.Forms.RichTextBox();
            this.imgEmoji = new System.Windows.Forms.ImageList();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tsMenusend.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(246, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 447);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LbFriend);
            this.panel1.Controls.Add(this.txtcong);
            this.panel1.Controls.Add(this.lbconnet);
            this.panel1.Controls.Add(this.lbAvatar);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnketnoi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 450);
            this.panel1.TabIndex = 0;
            // 
            // LbFriend
            // 
            this.LbFriend.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LbFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFriend.ForeColor = System.Drawing.Color.Black;
            this.LbFriend.FormattingEnabled = true;
            this.LbFriend.ItemHeight = 29;
            this.LbFriend.Location = new System.Drawing.Point(0, 66);
            this.LbFriend.Name = "LbFriend";
            this.LbFriend.Size = new System.Drawing.Size(249, 381);
            this.LbFriend.TabIndex = 10;
            this.LbFriend.SelectedIndexChanged += new System.EventHandler(this.LbFriend_SelectedIndexChanged);
            // 
            // txtcong
            // 
            this.txtcong.Location = new System.Drawing.Point(114, 37);
            this.txtcong.MaxLength = 5;
            this.txtcong.Multiline = true;
            this.txtcong.Name = "txtcong";
            this.txtcong.Size = new System.Drawing.Size(61, 23);
            this.txtcong.TabIndex = 7;
            this.txtcong.Text = "12345";
            this.txtcong.TextChanged += new System.EventHandler(this.txtcong_TextChanged);
            this.txtcong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcong_KeyPress);
            // 
            // lbconnet
            // 
            this.lbconnet.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconnet.ForeColor = System.Drawing.Color.DarkRed;
            this.lbconnet.Location = new System.Drawing.Point(57, 41);
            this.lbconnet.Name = "lbconnet";
            this.lbconnet.Size = new System.Drawing.Size(51, 19);
            this.lbconnet.TabIndex = 6;
            this.lbconnet.Text = "Offline!";
            // 
            // lbAvatar
            // 
            this.lbAvatar.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAvatar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvatar.ForeColor = System.Drawing.Color.White;
            this.lbAvatar.Image = global::Chat_Nguyen.Properties.Resources.icons8_filled_circle_52;
            this.lbAvatar.Location = new System.Drawing.Point(3, 4);
            this.lbAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.lbAvatar.Name = "lbAvatar";
            this.lbAvatar.Size = new System.Drawing.Size(48, 46);
            this.lbAvatar.TabIndex = 5;
            this.lbAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(59, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 26);
            this.txtName.TabIndex = 4;
            // 
            // btnketnoi
            // 
            this.btnketnoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnketnoi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnketnoi.Image = global::Chat_Nguyen.Properties.Resources.icons8_power_40;
            this.btnketnoi.Location = new System.Drawing.Point(183, 11);
            this.btnketnoi.Name = "btnketnoi";
            this.btnketnoi.Size = new System.Drawing.Size(59, 49);
            this.btnketnoi.TabIndex = 3;
            this.btnketnoi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnketnoi.UseVisualStyleBackColor = true;
            this.btnketnoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.LVNhan);
            this.panel3.Location = new System.Drawing.Point(250, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 320);
            this.panel3.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(36, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuHoiToolStripMenuItem,
            this.xoaChiMinhBanToolStripMenuItem,
            this.chuyenTiepToolStripMenuItem});
            this.chucNangToolStripMenuItem.Image = global::Chat_Nguyen.Properties.Resources.icons8_delete_30;
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.chucNangToolStripMenuItem.Text = "Chức năng";
            // 
            // thuHoiToolStripMenuItem
            // 
            this.thuHoiToolStripMenuItem.Image = global::Chat_Nguyen.Properties.Resources.icons8_delete_file_24;
            this.thuHoiToolStripMenuItem.Name = "thuHoiToolStripMenuItem";
            this.thuHoiToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.thuHoiToolStripMenuItem.Text = "Xóa tất cả";
            this.thuHoiToolStripMenuItem.Click += new System.EventHandler(this.thuHoiToolStripMenuItem_Click);
            // 
            // xoaChiMinhBanToolStripMenuItem
            // 
            this.xoaChiMinhBanToolStripMenuItem.Image = global::Chat_Nguyen.Properties.Resources.icons8_delete_trash_50;
            this.xoaChiMinhBanToolStripMenuItem.Name = "xoaChiMinhBanToolStripMenuItem";
            this.xoaChiMinhBanToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.xoaChiMinhBanToolStripMenuItem.Text = "Xóa";
            this.xoaChiMinhBanToolStripMenuItem.Click += new System.EventHandler(this.xoaChiMinhBanToolStripMenuItem_Click);
            // 
            // chuyenTiepToolStripMenuItem
            // 
            this.chuyenTiepToolStripMenuItem.Image = global::Chat_Nguyen.Properties.Resources.icons8_share_64;
            this.chuyenTiepToolStripMenuItem.Name = "chuyenTiepToolStripMenuItem";
            this.chuyenTiepToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.chuyenTiepToolStripMenuItem.Text = "Chuyển tiếp";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, 280);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(552, 42);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // LVNhan
            // 
            this.LVNhan.BackColor = System.Drawing.Color.Gainsboro;
            this.LVNhan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LVNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVNhan.ForeColor = System.Drawing.Color.White;
            this.LVNhan.HideSelection = false;
            this.LVNhan.LargeImageList = this.imgAnh;
            this.LVNhan.Location = new System.Drawing.Point(-1, 1);
            this.LVNhan.Margin = new System.Windows.Forms.Padding(10);
            this.LVNhan.Name = "LVNhan";
            this.LVNhan.Size = new System.Drawing.Size(548, 318);
            this.LVNhan.SmallImageList = this.imgAnh;
            this.LVNhan.StateImageList = this.imgAnh;
            this.LVNhan.TabIndex = 0;
            this.LVNhan.UseCompatibleStateImageBehavior = false;
            this.LVNhan.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 120;
            // 
            // imgAnh
            // 
            this.imgAnh.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgAnh.ImageSize = new System.Drawing.Size(60, 60);
            this.imgAnh.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnCall);
            this.panel4.Controls.Add(this.btnface);
            this.panel4.Controls.Add(this.lbconnetsv);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.LbAnhdd);
            this.panel4.Location = new System.Drawing.Point(250, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(549, 53);
            this.panel4.TabIndex = 3;
            // 
            // btnCall
            // 
            this.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCall.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCall.Image = global::Chat_Nguyen.Properties.Resources.icons8_call_30;
            this.btnCall.Location = new System.Drawing.Point(461, 9);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(30, 30);
            this.btnCall.TabIndex = 4;
            this.btnCall.UseVisualStyleBackColor = true;
            // 
            // btnface
            // 
            this.btnface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnface.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnface.Image = global::Chat_Nguyen.Properties.Resources.icons8_video_call_30;
            this.btnface.Location = new System.Drawing.Point(507, 9);
            this.btnface.Name = "btnface";
            this.btnface.Size = new System.Drawing.Size(30, 30);
            this.btnface.TabIndex = 3;
            this.btnface.UseVisualStyleBackColor = true;
            // 
            // lbconnetsv
            // 
            this.lbconnetsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconnetsv.Location = new System.Drawing.Point(59, 30);
            this.lbconnetsv.Name = "lbconnetsv";
            this.lbconnetsv.Size = new System.Drawing.Size(156, 15);
            this.lbconnetsv.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gửi tất cả";
            // 
            // LbAnhdd
            // 
            this.LbAnhdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbAnhdd.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAnhdd.ForeColor = System.Drawing.Color.White;
            this.LbAnhdd.Image = global::Chat_Nguyen.Properties.Resources.icons8_filled_circle_521;
            this.LbAnhdd.Location = new System.Drawing.Point(3, 1);
            this.LbAnhdd.Margin = new System.Windows.Forms.Padding(0);
            this.LbAnhdd.Name = "LbAnhdd";
            this.LbAnhdd.Size = new System.Drawing.Size(48, 46);
            this.LbAnhdd.TabIndex = 0;
            this.LbAnhdd.Text = "G";
            this.LbAnhdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(549, 30);
            // 
            // tsMenusend
            // 
            this.tsMenusend.AutoSize = false;
            this.tsMenusend.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tsMenusend.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMenusend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Emoji,
            this.file,
            this.Images});
            this.tsMenusend.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsMenusend.Location = new System.Drawing.Point(250, 372);
            this.tsMenusend.Name = "tsMenusend";
            this.tsMenusend.Size = new System.Drawing.Size(549, 37);
            this.tsMenusend.TabIndex = 0;
            this.tsMenusend.Text = "toolStrip1";
            // 
            // Emoji
            // 
            this.Emoji.AutoSize = false;
            this.Emoji.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Emoji.ForeColor = System.Drawing.Color.White;
            this.Emoji.Image = global::Chat_Nguyen.Properties.Resources.icons8_emoji_64;
            this.Emoji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Emoji.Name = "Emoji";
            this.Emoji.Size = new System.Drawing.Size(40, 30);
            this.Emoji.Text = "toolStripButton1";
            this.Emoji.Click += new System.EventHandler(this.Emoji_Click);
            // 
            // file
            // 
            this.file.AutoSize = false;
            this.file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.file.ForeColor = System.Drawing.Color.White;
            this.file.Image = global::Chat_Nguyen.Properties.Resources.icons8_attach_40;
            this.file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.file.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(40, 30);
            this.file.Text = "toolStripButton2";
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // Images
            // 
            this.Images.AutoSize = false;
            this.Images.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Images.ForeColor = System.Drawing.Color.White;
            this.Images.Image = global::Chat_Nguyen.Properties.Resources.icons8_image_64;
            this.Images.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Images.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Images.Name = "Images";
            this.Images.Size = new System.Drawing.Size(40, 30);
            this.Images.Text = "toolStripButton3";
            this.Images.Click += new System.EventHandler(this.Images_Click);
            // 
            // rtxnhap
            // 
            this.rtxnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxnhap.Location = new System.Drawing.Point(249, 409);
            this.rtxnhap.Name = "rtxnhap";
            this.rtxnhap.Size = new System.Drawing.Size(502, 39);
            this.rtxnhap.TabIndex = 10;
            this.rtxnhap.Text = "";
            this.rtxnhap.TextChanged += new System.EventHandler(this.rtxnhap_TextChanged);
            // 
            // imgEmoji
            // 
            this.imgEmoji.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgEmoji.ImageSize = new System.Drawing.Size(20, 20);
            this.imgEmoji.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.BackgroundImage = global::Chat_Nguyen.Properties.Resources.icons8_email_send_40;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(751, 409);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(48, 39);
            this.btnSend.TabIndex = 2;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsMenusend);
            this.Controls.Add(this.rtxnhap);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmClient";
            this.Text = "Client Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tsMenusend.ResumeLayout(false);
            this.tsMenusend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnface;
        private System.Windows.Forms.Label lbconnetsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbAnhdd;
        private System.Windows.Forms.Button btnketnoi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbAvatar;
        private System.Windows.Forms.Label lbconnet;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.ToolStrip tsMenusend;
        private System.Windows.Forms.ToolStripButton Emoji;
        private System.Windows.Forms.ToolStripButton file;
        private System.Windows.Forms.ToolStripButton Images;
        private System.Windows.Forms.ListView LVNhan;
        private System.Windows.Forms.ImageList imgAnh;
        private System.Windows.Forms.RichTextBox rtxnhap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imgEmoji;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuHoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaChiMinhBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyenTiepToolStripMenuItem;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TextBox txtcong;
        private System.Windows.Forms.ListBox LbFriend;
    }
}

