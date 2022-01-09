
namespace LTGD_DOMIN
{
    partial class FormPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlay));
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.panelTuyChon = new System.Windows.Forms.Panel();
            this.picBbtMute = new System.Windows.Forms.PictureBox();
            this.picBbtReplay = new System.Windows.Forms.PictureBox();
            this.picBbtCustomer = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picBbtHard = new System.Windows.Forms.PictureBox();
            this.picBbtNormal = new System.Windows.Forms.PictureBox();
            this.picBbtEasy = new System.Windows.Forms.PictureBox();
            this.picBbtHome = new System.Windows.Forms.PictureBox();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbFlag = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbBomb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTuyChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtReplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtHard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtHome)).BeginInit();
            this.panelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "DominCell_64px.png");
            this.imgList.Images.SetKeyName(1, "Domin_1_64px.png");
            this.imgList.Images.SetKeyName(2, "Domin_2_64px.png");
            this.imgList.Images.SetKeyName(3, "Domin_3_64px.png");
            this.imgList.Images.SetKeyName(4, "Domin_4_64px.png");
            this.imgList.Images.SetKeyName(5, "Domin_5_64px.png");
            this.imgList.Images.SetKeyName(6, "Domin_6_64px.png");
            this.imgList.Images.SetKeyName(7, "Domin_7_64px.png");
            this.imgList.Images.SetKeyName(8, "Domin_8_64px.png");
            this.imgList.Images.SetKeyName(9, "Domin_0_64px.png");
            this.imgList.Images.SetKeyName(10, "DominBoom_64px.png");
            this.imgList.Images.SetKeyName(11, "Dominnổ_64px.png");
            this.imgList.Images.SetKeyName(12, "DominFlag_64px.png");
            // 
            // panelTuyChon
            // 
            this.panelTuyChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTuyChon.BackgroundImage = global::LTGD_DOMIN.Properties.Resources.bgTuyChon;
            this.panelTuyChon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTuyChon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTuyChon.Controls.Add(this.picBbtMute);
            this.panelTuyChon.Controls.Add(this.picBbtReplay);
            this.panelTuyChon.Controls.Add(this.picBbtCustomer);
            this.panelTuyChon.Controls.Add(this.pictureBox3);
            this.panelTuyChon.Controls.Add(this.lbScore);
            this.panelTuyChon.Controls.Add(this.lbTime);
            this.panelTuyChon.Controls.Add(this.pictureBox4);
            this.panelTuyChon.Controls.Add(this.picBbtHard);
            this.panelTuyChon.Controls.Add(this.picBbtNormal);
            this.panelTuyChon.Controls.Add(this.picBbtEasy);
            this.panelTuyChon.Controls.Add(this.picBbtHome);
            this.panelTuyChon.Location = new System.Drawing.Point(0, 0);
            this.panelTuyChon.Name = "panelTuyChon";
            this.panelTuyChon.Size = new System.Drawing.Size(217, 548);
            this.panelTuyChon.TabIndex = 2;
            // 
            // picBbtMute
            // 
            this.picBbtMute.Image = global::LTGD_DOMIN.Properties.Resources.btmuteOn1;
            this.picBbtMute.Location = new System.Drawing.Point(157, 6);
            this.picBbtMute.Name = "picBbtMute";
            this.picBbtMute.Size = new System.Drawing.Size(49, 49);
            this.picBbtMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBbtMute.TabIndex = 13;
            this.picBbtMute.TabStop = false;
            this.picBbtMute.Click += new System.EventHandler(this.picBbtMute_Click);
            // 
            // picBbtReplay
            // 
            this.picBbtReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBbtReplay.Image = global::LTGD_DOMIN.Properties.Resources.btReplay;
            this.picBbtReplay.Location = new System.Drawing.Point(43, 449);
            this.picBbtReplay.Name = "picBbtReplay";
            this.picBbtReplay.Size = new System.Drawing.Size(126, 54);
            this.picBbtReplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBbtReplay.TabIndex = 12;
            this.picBbtReplay.TabStop = false;
            this.picBbtReplay.Click += new System.EventHandler(this.picBbtReplay_Click);
            // 
            // picBbtCustomer
            // 
            this.picBbtCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBbtCustomer.Image = global::LTGD_DOMIN.Properties.Resources.btcustomer;
            this.picBbtCustomer.Location = new System.Drawing.Point(37, 271);
            this.picBbtCustomer.Name = "picBbtCustomer";
            this.picBbtCustomer.Size = new System.Drawing.Size(139, 56);
            this.picBbtCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBbtCustomer.TabIndex = 11;
            this.picBbtCustomer.TabStop = false;
            this.picBbtCustomer.Click += new System.EventHandler(this.picBbtCustomer_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LTGD_DOMIN.Properties.Resources.imgstar;
            this.pictureBox3.Location = new System.Drawing.Point(57, 391);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // lbScore
            // 
            this.lbScore.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbScore.Location = new System.Drawing.Point(94, 395);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(61, 27);
            this.lbScore.TabIndex = 6;
            this.lbScore.Text = "100";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTime.Location = new System.Drawing.Point(94, 349);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(61, 27);
            this.lbTime.TabIndex = 10;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LTGD_DOMIN.Properties.Resources.imgsand_clock;
            this.pictureBox4.Location = new System.Drawing.Point(57, 345);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // picBbtHard
            // 
            this.picBbtHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBbtHard.Image = global::LTGD_DOMIN.Properties.Resources.bthard;
            this.picBbtHard.Location = new System.Drawing.Point(8, 190);
            this.picBbtHard.Name = "picBbtHard";
            this.picBbtHard.Size = new System.Drawing.Size(197, 73);
            this.picBbtHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBbtHard.TabIndex = 5;
            this.picBbtHard.TabStop = false;
            this.picBbtHard.Click += new System.EventHandler(this.picBbtHard_Click);
            // 
            // picBbtNormal
            // 
            this.picBbtNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBbtNormal.Image = global::LTGD_DOMIN.Properties.Resources.btnormal;
            this.picBbtNormal.Location = new System.Drawing.Point(28, 125);
            this.picBbtNormal.Name = "picBbtNormal";
            this.picBbtNormal.Size = new System.Drawing.Size(156, 57);
            this.picBbtNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBbtNormal.TabIndex = 4;
            this.picBbtNormal.TabStop = false;
            this.picBbtNormal.Click += new System.EventHandler(this.picBbtNormal_Click);
            // 
            // picBbtEasy
            // 
            this.picBbtEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBbtEasy.Image = global::LTGD_DOMIN.Properties.Resources.bteasy;
            this.picBbtEasy.Location = new System.Drawing.Point(45, 71);
            this.picBbtEasy.Name = "picBbtEasy";
            this.picBbtEasy.Size = new System.Drawing.Size(123, 46);
            this.picBbtEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBbtEasy.TabIndex = 3;
            this.picBbtEasy.TabStop = false;
            this.picBbtEasy.Click += new System.EventHandler(this.picBbtEasy_Click);
            // 
            // picBbtHome
            // 
            this.picBbtHome.Image = global::LTGD_DOMIN.Properties.Resources.bthome2;
            this.picBbtHome.Location = new System.Drawing.Point(6, 6);
            this.picBbtHome.Name = "picBbtHome";
            this.picBbtHome.Size = new System.Drawing.Size(49, 49);
            this.picBbtHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBbtHome.TabIndex = 1;
            this.picBbtHome.TabStop = false;
            this.picBbtHome.Click += new System.EventHandler(this.picBbtHome_Click);
            // 
            // panelPlay
            // 
            this.panelPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelPlay.BackgroundImage = global::LTGD_DOMIN.Properties.Resources.bgPlay;
            this.panelPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPlay.Location = new System.Drawing.Point(216, 48);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(920, 500);
            this.panelPlay.TabIndex = 1;
            // 
            // panelThongTin
            // 
            this.panelThongTin.BackColor = System.Drawing.Color.Silver;
            this.panelThongTin.BackgroundImage = global::LTGD_DOMIN.Properties.Resources.bggrass;
            this.panelThongTin.Controls.Add(this.lbLevel);
            this.panelThongTin.Controls.Add(this.lbFlag);
            this.panelThongTin.Controls.Add(this.pictureBox2);
            this.panelThongTin.Controls.Add(this.lbBomb);
            this.panelThongTin.Controls.Add(this.pictureBox1);
            this.panelThongTin.Location = new System.Drawing.Point(217, 0);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(919, 47);
            this.panelThongTin.TabIndex = 0;
            // 
            // lbLevel
            // 
            this.lbLevel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbLevel.Location = new System.Drawing.Point(382, 12);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(137, 34);
            this.lbLevel.TabIndex = 0;
            this.lbLevel.Text = "NORMAL";
            this.lbLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFlag
            // 
            this.lbFlag.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlag.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbFlag.Location = new System.Drawing.Point(185, 17);
            this.lbFlag.Name = "lbFlag";
            this.lbFlag.Size = new System.Drawing.Size(57, 27);
            this.lbFlag.TabIndex = 4;
            this.lbFlag.Text = "000";
            this.lbFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LTGD_DOMIN.Properties.Resources.imgflag2;
            this.pictureBox2.Location = new System.Drawing.Point(148, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbBomb
            // 
            this.lbBomb.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBomb.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbBomb.Location = new System.Drawing.Point(60, 17);
            this.lbBomb.Name = "lbBomb";
            this.lbBomb.Size = new System.Drawing.Size(57, 27);
            this.lbBomb.TabIndex = 1;
            this.lbBomb.Text = "000";
            this.lbBomb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LTGD_DOMIN.Properties.Resources.imgdynamite;
            this.pictureBox1.Location = new System.Drawing.Point(23, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1136, 548);
            this.Controls.Add(this.panelTuyChon);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.panelThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dò Mìn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPlay_FormClosed);
            this.Load += new System.EventHandler(this.FormPlay_Load);
            this.panelTuyChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBbtMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtReplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtHard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBbtHome)).EndInit();
            this.panelThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Panel panelTuyChon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbBomb;
        private System.Windows.Forms.Label lbFlag;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picBbtHome;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.PictureBox picBbtEasy;
        private System.Windows.Forms.PictureBox picBbtHard;
        private System.Windows.Forms.PictureBox picBbtNormal;
        private System.Windows.Forms.PictureBox picBbtCustomer;
        private System.Windows.Forms.PictureBox picBbtReplay;
        private System.Windows.Forms.PictureBox picBbtMute;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.ImageList imgList;
    }
}

