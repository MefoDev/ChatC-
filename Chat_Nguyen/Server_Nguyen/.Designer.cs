
namespace Server_Nguyen
{
    partial class Server
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.label1 = new System.Windows.Forms.Label();
            this.txtcong = new System.Windows.Forms.TextBox();
            this.LbUser = new System.Windows.Forms.ListBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.Emoji = new System.Windows.Forms.ToolStripButton();
            this.File = new System.Windows.Forms.ToolStripButton();
            this.Images = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbtrangthai = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LVemoji = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuHoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaChiMinhBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LVNhan = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgAnh = new System.Windows.Forms.ImageList(this.components);
            this.rtxNhap = new System.Windows.Forms.RichTextBox();
            this.imgEmoji = new System.Windows.Forms.ImageList(this.components);
            this.LbAnhdd = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tsMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(331, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORT";
            // 
            // txtcong
            // 
            this.txtcong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcong.Location = new System.Drawing.Point(431, 11);
            this.txtcong.MaxLength = 5;
            this.txtcong.Multiline = true;
            this.txtcong.Name = "txtcong";
            this.txtcong.Size = new System.Drawing.Size(90, 32);
            this.txtcong.TabIndex = 1;
            this.txtcong.Text = "12345";
            this.txtcong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtcong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // LbUser
            // 
            this.LbUser.BackColor = System.Drawing.Color.SkyBlue;
            this.LbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUser.ForeColor = System.Drawing.Color.Black;
            this.LbUser.FormattingEnabled = true;
            this.LbUser.ItemHeight = 16;
            this.LbUser.Location = new System.Drawing.Point(3, 52);
            this.LbUser.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(117, 450);
            this.LbUser.TabIndex = 2;
            this.LbUser.SelectedIndexChanged += new System.EventHandler(this.LbUser_SelectedIndexChanged);
            // 
            // tsMenu
            // 
            this.tsMenu.AutoSize = false;
            this.tsMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Emoji,
            this.File,
            this.Images});
            this.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsMenu.Location = new System.Drawing.Point(117, 432);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(498, 31);
            this.tsMenu.TabIndex = 8;
            this.tsMenu.Text = "toolStrip1";
            // 
            // Emoji
            // 
            this.Emoji.AutoSize = false;
            this.Emoji.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Emoji.Image = global::Server_Nguyen.Properties.Resources.icons8_emoji_64;
            this.Emoji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Emoji.Name = "Emoji";
            this.Emoji.Size = new System.Drawing.Size(40, 30);
            this.Emoji.Text = "toolStripButton1";
            this.Emoji.Click += new System.EventHandler(this.Emoji_Click);
            // 
            // File
            // 
            this.File.AutoSize = false;
            this.File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.File.Image = global::Server_Nguyen.Properties.Resources.icons8_attach_40;
            this.File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(40, 30);
            this.File.Text = "toolStripButton2";
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // Images
            // 
            this.Images.AutoSize = false;
            this.Images.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Images.Image = global::Server_Nguyen.Properties.Resources.icons8_image_64;
            this.Images.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Images.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Images.Name = "Images";
            this.Images.Size = new System.Drawing.Size(40, 30);
            this.Images.Text = "toolStripButton3";
            this.Images.Click += new System.EventHandler(this.Images_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Man chát ter Server";
            // 
            // lbtrangthai
            // 
            this.lbtrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtrangthai.ForeColor = System.Drawing.Color.Red;
            this.lbtrangthai.Location = new System.Drawing.Point(61, 29);
            this.lbtrangthai.Name = "lbtrangthai";
            this.lbtrangthai.Size = new System.Drawing.Size(192, 19);
            this.lbtrangthai.TabIndex = 12;
            this.lbtrangthai.Text = "Sever đang ngoại tuyến!";
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LVemoji);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.LVNhan);
            this.panel1.Location = new System.Drawing.Point(120, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 380);
            this.panel1.TabIndex = 13;
            // 
            // LVemoji
            // 
            this.LVemoji.HideSelection = false;
            this.LVemoji.Location = new System.Drawing.Point(-1, 337);
            this.LVemoji.Name = "LVemoji";
            this.LVemoji.Size = new System.Drawing.Size(495, 42);
            this.LVemoji.TabIndex = 17;
            this.LVemoji.UseCompatibleStateImageBehavior = false;
            this.LVemoji.SelectedIndexChanged += new System.EventHandler(this.LVemoji_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(36, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuHoiToolStripMenuItem,
            this.xoaChiMinhBanToolStripMenuItem,
            this.chuyeToolStripMenuItem});
            this.chucNangToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chucNangToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.chucNangToolStripMenuItem.Image = global::Server_Nguyen.Properties.Resources.icons8_delete_30;
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.chucNangToolStripMenuItem.Text = "Chức năng";
            // 
            // thuHoiToolStripMenuItem
            // 
            this.thuHoiToolStripMenuItem.Image = global::Server_Nguyen.Properties.Resources.icons8_delete_file_24;
            this.thuHoiToolStripMenuItem.Name = "thuHoiToolStripMenuItem";
            this.thuHoiToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.thuHoiToolStripMenuItem.Text = "Xóa hội thoại";
            this.thuHoiToolStripMenuItem.Click += new System.EventHandler(this.thuHoiToolStripMenuItem_Click);
            // 
            // xoaChiMinhBanToolStripMenuItem
            // 
            this.xoaChiMinhBanToolStripMenuItem.Image = global::Server_Nguyen.Properties.Resources.icons8_share_64;
            this.xoaChiMinhBanToolStripMenuItem.Name = "xoaChiMinhBanToolStripMenuItem";
            this.xoaChiMinhBanToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.xoaChiMinhBanToolStripMenuItem.Text = "Xóa";
            this.xoaChiMinhBanToolStripMenuItem.Click += new System.EventHandler(this.xoaChiMinhBanToolStripMenuItem_Click);
            // 
            // chuyeToolStripMenuItem
            // 
            this.chuyeToolStripMenuItem.Name = "chuyeToolStripMenuItem";
            this.chuyeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.chuyeToolStripMenuItem.Text = "Chuyển tiếp";
            this.chuyeToolStripMenuItem.Click += new System.EventHandler(this.chuyeToolStripMenuItem_Click);
            // 
            // LVNhan
            // 
            this.LVNhan.BackColor = System.Drawing.Color.Gainsboro;
            this.LVNhan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LVNhan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVNhan.ForeColor = System.Drawing.Color.White;
            this.LVNhan.HideSelection = false;
            this.LVNhan.LargeImageList = this.imgAnh;
            this.LVNhan.Location = new System.Drawing.Point(-1, 0);
            this.LVNhan.Margin = new System.Windows.Forms.Padding(10);
            this.LVNhan.Name = "LVNhan";
            this.LVNhan.Size = new System.Drawing.Size(495, 378);
            this.LVNhan.SmallImageList = this.imgAnh;
            this.LVNhan.StateImageList = this.imgAnh;
            this.LVNhan.TabIndex = 16;
            this.LVNhan.UseCompatibleStateImageBehavior = false;
            this.LVNhan.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 120;
            // 
            // imgAnh
            // 
            this.imgAnh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgAnh.ImageStream")));
            this.imgAnh.TransparentColor = System.Drawing.Color.Transparent;
            this.imgAnh.Images.SetKeyName(0, "Enscape_2021-04-25-11-52-34.png");
            // 
            // rtxNhap
            // 
            this.rtxNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxNhap.Location = new System.Drawing.Point(120, 462);
            this.rtxNhap.Name = "rtxNhap";
            this.rtxNhap.Size = new System.Drawing.Size(450, 40);
            this.rtxNhap.TabIndex = 1;
            this.rtxNhap.Text = "";
            this.rtxNhap.TextChanged += new System.EventHandler(this.rtxNhap_TextChanged);
            // 
            // imgEmoji
            // 
            this.imgEmoji.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgEmoji.ImageSize = new System.Drawing.Size(20, 20);
            this.imgEmoji.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LbAnhdd
            // 
            this.LbAnhdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.LbAnhdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbAnhdd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LbAnhdd.Image = global::Server_Nguyen.Properties.Resources.icons8_manchester_united_50;
            this.LbAnhdd.Location = new System.Drawing.Point(6, 4);
            this.LbAnhdd.Name = "LbAnhdd";
            this.LbAnhdd.Size = new System.Drawing.Size(48, 46);
            this.LbAnhdd.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = global::Server_Nguyen.Properties.Resources.icons8_email_send_40;
            this.btnSend.Location = new System.Drawing.Point(570, 462);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(44, 40);
            this.btnSend.TabIndex = 7;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = global::Server_Nguyen.Properties.Resources.icons8_shutdown_24;
            this.btnStart.Location = new System.Drawing.Point(546, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(68, 46);
            this.btnStart.TabIndex = 4;
            this.btnStart.Tag = "";
            this.btnStart.Text = "START";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(618, 506);
            this.Controls.Add(this.rtxNhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbtrangthai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbAnhdd);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.LbUser);
            this.Controls.Add(this.txtcong);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MaximumSize = new System.Drawing.Size(634, 545);
            this.MinimumSize = new System.Drawing.Size(634, 545);
            this.Name = "Server";
            this.Text = "Server Chat Nguyen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.Load += new System.EventHandler(this.Server_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcong;
        private System.Windows.Forms.ListBox LbUser;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton Emoji;
        private System.Windows.Forms.ToolStripButton File;
        private System.Windows.Forms.ToolStripButton Images;
        private System.Windows.Forms.Label LbAnhdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtrangthai;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imgAnh;
        private System.Windows.Forms.RichTextBox rtxNhap;
        private System.Windows.Forms.ImageList imgEmoji;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuHoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaChiMinhBanToolStripMenuItem;
        private System.Windows.Forms.ListView LVNhan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView LVemoji;
        private System.Windows.Forms.ToolStripMenuItem chuyeToolStripMenuItem;
    }
}

