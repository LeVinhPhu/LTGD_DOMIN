using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LTGD_DOMIN
{
    public partial class FormPlay : Form
    {
        public FormPlay()
        {
            InitializeComponent();
            initPanelGame();
            LevelEasy();
            //initBangDiem();
        }

        // --------------code------------------
        #region Biến toàn phần
        Graphics grs;
        private Panel panelNextLv;
        private Panel panelCustomer;
        private Panel panelG;
        //TextBox tb2, tb3, tb4;
        Button btOK, btNextLv, btCongRow, btCongCol, btCongMine, btTruRow, btTruCol, btTruMine;
        Label lbRow, lbCol, lbMine;
        //
        int _row, _col, _mine, _size;
        int _rowCTM, _colCTM, _mineCTM;
        int indexTime = 1;
        int bomCount = 0;
        string win_Loss = "";
        string replay_Next = "";


        int level;
        bool flagRestar = true; // Khi trò chơi chưa được khởi động thì ko đc restar lại.(true - đc resta), (False - ko đc restar)
        bool flagEndGame = false; // 
        bool flagCustomer = false;
        bool audioOn_Off = true;//(true - on) , (false off)

        // Xữ lý thời gian
        int second = 0;
        int minute = 0;

        // Phan Loai Level - lv123 (True) vs lvCustomer (False)
        bool flagLevel = true;

        //string path = @"D:\Visuastudio\LTGD\GameDoMin\GameDoMin";
        int[,] mainboard;// -1 là ô chứa bom
        int[,] ocamCo; //-2 là chưa cắm cờ, -1 là đã cắm cờ
        int[,] kiemTraODaMo; // 0 là ô chưa được mở, 1 là ô đã được mở
        Stack hangDoi = new Stack();
        #endregion

        // init âm thanh
        SoundPlayer Sound;
        //Sound.Play(); 
        public void initSound()
        {
            Sound = new SoundPlayer("GameDoMin.wav");
            Sound.Play();
        } //xong

        // Init Panel
        public void initPanelGame()
        {
            panelG = createPanelGame();
        } // xong

        public void initPanelNextLv()
        {
            panelNextLv = createPanelNextLv();
        } // xong

        public void initPanelCustomer()
        {
            panelCustomer = createPanelCustomer();
        } //xong

        // Create Panel
        private Panel createPanelGame()
        {
            Panel panelGame = new Panel();
            panelGame.AutoSize = true;
            panelGame.BorderStyle = BorderStyle.Fixed3D;
            panelGame.BackColor = Color.Gray;

            panelGame.Paint += new System.Windows.Forms.PaintEventHandler(panelGame_Paint);
            panelGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGame_MouseDown);
            return panelGame;
        } //xong

        public Panel createPanelNextLv()
        {
            Panel panelNextLv = new Panel();
            panelNextLv.BackColor = Color.Gray;
            panelNextLv.Size = new Size(340, 240);
            panelNextLv.BorderStyle = BorderStyle.None;
            panelNextLv.Location = new Point(308, 134);
            panelNextLv.BackgroundImageLayout = ImageLayout.Stretch;
            panelNextLv.BackgroundImage = Properties.Resources.bgEndGame;
            panelNextLv.BackColor = Color.FromArgb(0, 0, 0, 0);
            

            Label lb = new Label();
            lb.Text = "END GAME";
            lb.Size = new Size(340, 53);
            lb.AutoSize = false;
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.Dock = DockStyle.Top;
            lb.ForeColor = Color.Gainsboro;
            lb.Font = new Font("Showcard Gothic", 12, FontStyle.Bold);

            Label lbWinLoss = new Label();
            lbWinLoss.Text = win_Loss;
            lbWinLoss.Size = new Size(340, 40);
            lbWinLoss.TextAlign = ContentAlignment.MiddleCenter;
            lbWinLoss.ForeColor = Color.Gainsboro;
            lbWinLoss.Font = new Font("Showcard Gothic", 22, FontStyle.Regular);
            lbWinLoss.Location = new Point(0, 50);

            //laber giá trị
            Label lbTime1 = new Label();
            lbTime1.AutoSize = true;
            lbTime1.Text = lbTime.Text;
            lbTime1.ForeColor = Color.Gainsboro;
            lbTime1.Font = new Font("Showcard Gothic", 10, FontStyle.Regular);
            lbTime1.Location = new Point(153, 112);

            Label lbScore1 = new Label();
            lbScore1.Text = lbScore.Text;
            lbScore1.AutoSize = true;
            lbScore1.ForeColor = Color.Gainsboro;
            lbScore1.Font = new Font("Showcard Gothic", 10, FontStyle.Regular);
            lbScore1.Location = new Point(153, 156);

            PictureBox picB1 = new PictureBox();
            picB1.Image = Properties.Resources.imgsand_clock;
            picB1.Size = new Size(25, 25);
            picB1.SizeMode = PictureBoxSizeMode.StretchImage;
            picB1.Location = new Point(120,112);

            PictureBox picB2 = new PictureBox();
            picB2.Image = Properties.Resources.imgstar;
            picB2.Size = new Size(25, 25);
            picB2.SizeMode = PictureBoxSizeMode.StretchImage;
            picB2.Location = new Point(120, 156);

            // Button
            btNextLv = new Button();
            btNextLv.Text = replay_Next;
            btNextLv.Size = new Size(70, 40);
            btNextLv.Font = new Font("Showcard Gothic", 8, FontStyle.Regular);
            btNextLv.Location = new Point(220, 170);
            btNextLv.Click += new System.EventHandler(this.btNextLv_Click);


            // Thêm thuộc tính vừa tạo

            panelNextLv.Controls.Add(lb);
            panelNextLv.Controls.Add(lbWinLoss);
            panelNextLv.Controls.Add(lbTime1);
            panelNextLv.Controls.Add(lbScore1);

            panelNextLv.Controls.Add(picB1);
            panelNextLv.Controls.Add(picB2);

            panelNextLv.Controls.Add(btNextLv);

            return panelNextLv;
        } // xong

        public Panel createPanelCustomer()
        {

            Panel panelCustomer = new Panel();
            panelCustomer.BackColor = Color.Gray;
            panelCustomer.Size = new Size(340, 240);
            panelCustomer.BorderStyle = BorderStyle.None;
            panelCustomer.Location = new Point(308, 134);
            panelCustomer.BackgroundImageLayout = ImageLayout.Stretch;
            panelCustomer.BackgroundImage = Properties.Resources.bgEndGame;
            panelCustomer.BackColor = Color.FromArgb(0, 0, 0, 0);

            Label lb0 = new Label();
            lb0.Text = "CUSTOMER";
            lb0.Size = new Size(300, 30);
            lb0.AutoSize = false;
            lb0.TextAlign = ContentAlignment.MiddleCenter;
            lb0.Dock = DockStyle.Top;
            lb0.ForeColor = Color.Gainsboro;
            lb0.Font = new Font("Showcard Gothic", 16, FontStyle.Bold);

            Label lb1 = new Label();
            lb1.Text = "ROW: 1 - 30 _ COL: 1 - 16 _ MINE: 1 - 99";
            lb1.AutoSize = true;
            lb1.ForeColor = Color.Gainsboro;
            lb1.Font = new Font("Showcard Gothic", 8, FontStyle.Regular);
            lb1.Location = new Point(43, 38);

            Label lb2 = new Label();
            lb2.AutoSize = true;
            lb2.Text = "ROW:";
            lb2.ForeColor = Color.Gainsboro;
            lb2.Font = new Font("Showcard Gothic", 8, FontStyle.Regular);
            lb2.Location = new Point(37, 78);

            Label lb3 = new Label();
            lb3.Text = "COL:";
            lb3.AutoSize = true;
            lb3.ForeColor = Color.Gainsboro;
            lb3.Font = new Font("Showcard Gothic", 8, FontStyle.Regular);
            lb3.Location = new Point(37, 112);

            Label lb4 = new Label();
            lb4.Text = "MINE:";
            lb4.AutoSize = true;
            lb4.ForeColor = Color.Gainsboro;
            lb4.Font = new Font("Showcard Gothic", 8, FontStyle.Regular);
            lb4.Location = new Point(37, 146);

            //laber giá trị
            lbRow = new Label();
            lbRow.AutoSize = true;
            lbRow.Text = "10";
            lbRow.ForeColor = Color.Gainsboro;
            lbRow.Font = new Font("Showcard Gothic", 14, FontStyle.Regular);
            lbRow.Location = new Point(173, 72);

            lbCol = new Label();
            lbCol.Text = "10";
            lbCol.AutoSize = true;
            lbCol.ForeColor = Color.Gainsboro;
            lbCol.Font = new Font("Showcard Gothic", 14, FontStyle.Regular);
            lbCol.Location = new Point(173, 106);

            lbMine = new Label();
            lbMine.Text = "10";
            lbMine.AutoSize = true;
            lbMine.ForeColor = Color.Gainsboro;
            lbMine.Font = new Font("Showcard Gothic", 14, FontStyle.Regular);
            lbMine.Location = new Point(173, 140);

            // texbox
            //tb2 = new TextBox();
            //tb2.Font = new Font("Showcard Gothic", 8, FontStyle.Regular);
            //tb2.MaxLength = 2;
            //tb2.Size = new Size(165, 24);
            //tb2.Location = new Point(69, 72);

            //tb3 = new TextBox();
            //tb3.Font = new Font("Showcard Gothic", 8, FontStyle.Regular);
            //tb3.MaxLength = 2;
            //tb3.Size = new Size(165, 24);
            //tb3.Location = new Point(69, 106);

            //tb4 = new TextBox();
            //tb4.Font = new Font("Showcard Gothic", 8, FontStyle.Regular);
            //tb4.MaxLength = 2;
            //tb4.Size = new Size(165, 24);
            //tb4.Location = new Point(69, 140);


            // Button
            btOK = new Button();
            btOK.Text = "OK";
            btOK.Size = new Size(100, 40);
            btOK.Font = new Font("Showcard Gothic", 8, FontStyle.Regular);
            btOK.Location = new Point(177, 177);
            btOK.Click += new System.EventHandler(this.btOK_Click);


            // Bt tăng giảm thuộc tính
            btCongRow = new Button();
            btCongRow.Text = "+";
            btCongRow.Size = new Size(75, 31);
            btCongRow.Font = new Font("Showcard Gothic", 8, FontStyle.Bold);
            btCongRow.Location = new Point(89, 72);
            btCongRow.Click += new System.EventHandler(this.btCongRow_Click);

            btCongCol = new Button();
            btCongCol.Text = "+";
            btCongCol.Size = new Size(75, 31);
            btCongCol.Font = new Font("Showcard Gothic", 8, FontStyle.Bold);
            btCongCol.Location = new Point(89, 106);
            btCongCol.Click += new System.EventHandler(this.btCongCol_Click);

            btCongMine = new Button();
            btCongMine.Text = "+";
            btCongMine.Size = new Size(75, 31);
            btCongMine.Font = new Font("Showcard Gothic", 8, FontStyle.Bold);
            btCongMine.Location = new Point(89, 140);
            btCongMine.Click += new System.EventHandler(this.btCongMine_Click);

            btTruRow = new Button();
            btTruRow.Text = "-";
            btTruRow.Size = new Size(75, 31);
            btTruRow.Font = new Font("Showcard Gothic", 8, FontStyle.Bold);
            btTruRow.Location = new Point(217, 72);
            btTruRow.Click += new System.EventHandler(this.btTruRow_Click);

            btTruCol = new Button();
            btTruCol.Text = "-";
            btTruCol.Size = new Size(75, 31);
            btTruCol.Font = new Font("Showcard Gothic", 8, FontStyle.Bold);
            btTruCol.Location = new Point(217, 106);
            btTruCol.Click += new System.EventHandler(this.btTruCol_Click);

            btTruMine = new Button();
            btTruMine.Text = "-";
            btTruMine.Size = new Size(75, 31);
            btTruMine.Font = new Font("Showcard Gothic", 8, FontStyle.Bold);
            btTruMine.Location = new Point(217, 140);
            btTruMine.Click += new System.EventHandler(this.btTruMine_Click);


            // Thêm thuộc tính vừa tạo

            panelCustomer.Controls.Add(lb0);
            panelCustomer.Controls.Add(lb1);
            panelCustomer.Controls.Add(lb2);
            panelCustomer.Controls.Add(lb3);
            panelCustomer.Controls.Add(lb4);
            panelCustomer.Controls.Add(lbRow);
            panelCustomer.Controls.Add(lbCol);
            panelCustomer.Controls.Add(lbMine);

            //panelCustomer.Controls.Add(tb2);
            //panelCustomer.Controls.Add(tb3);
            //panelCustomer.Controls.Add(tb4);

            panelCustomer.Controls.Add(btOK);
            panelCustomer.Controls.Add(btCongRow);
            panelCustomer.Controls.Add(btCongCol);
            panelCustomer.Controls.Add(btCongMine);
            panelCustomer.Controls.Add(btTruRow);
            panelCustomer.Controls.Add(btTruCol);
            panelCustomer.Controls.Add(btTruMine);

            return panelCustomer;
        } // xong

        // Action Panel
        public void showPanelNextLv()
        {
            panelPlay.Controls.Remove(panelG);
            panelNextLv = createPanelNextLv();
            panelPlay.Controls.Add(panelNextLv);
            flagEndGame = true;
        } // xong

        public void showPanelCustomer()
        {
            flagCustomer = true;
            panelPlay.Controls.Remove(panelG);
            initPanelCustomer();
            panelPlay.Controls.Add(panelCustomer);
        }  //xong

        //Khởi tạo giá trị
        //Quy ước: -1: ô chứa bom
        #region Gán các giá trị vào mảng
        public void initFlag(int row, int col)
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    ocamCo[i, j] = -2;
                    kiemTraODaMo[i, j] = 0;
                }
        } // xong

        public void init(int row, int col, int bom)
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    mainboard[i, j] = 0;
            //Đặt bom ngẫu nhiên 
            Random rd = new Random(); ;
            int dong, cot, t = 0;
            while (t < bom)
            {
                dong = rd.Next(0, row - 1);
                cot = rd.Next(0, col - 1);
                if (mainboard[dong, cot] != -1)
                {
                    mainboard[dong, cot] = -1;
                    t++;
                }
            }
            //Gán giá trị các ô xung quanh
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    if (mainboard[i, j] == -1)
                    {
                        for (int h = i - 1; h <= i + 1; h++)
                            for (int k = j - 1; k <= j + 1; k++)
                                if (h >= 0 && k >= 0 && h < row && k < col && mainboard[h, k] != -1)
                                    mainboard[h, k]++;
                    }

        } //xong

        public void endGame(int row, int col)
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    kiemTraODaMo[i, j] = 1;
        } //xong
        #endregion
        /*Khi bấm, các ô không gần bom sẽ biến mất
         * vì cái này khó nên tụi em có tham khảo bên ngoài
         */
        //Load ảnh vào mảng
        public void open(int row, int col)
        {

            if (kiemTraODaMo[row, col] == 0 && ocamCo[row, col] == -2)
            {
                switch (mainboard[row, col])
                {
                    case 1:
                        grs.DrawImage(imgList.Images[1], row * _size, col * _size); break;
                    case 2:
                        grs.DrawImage(imgList.Images[2], row * _size, col * _size); break;
                    case 3:
                        grs.DrawImage(imgList.Images[3], row * _size, col * _size); break;
                    case 4:
                        grs.DrawImage(imgList.Images[4], row * _size, col * _size); break;
                    case 5:
                        grs.DrawImage(imgList.Images[5], row * _size, col * _size); break;
                    case 6:
                        grs.DrawImage(imgList.Images[6], row * _size, col * _size); break;
                    case 7:
                        grs.DrawImage(imgList.Images[7], row * _size, col * _size); break;
                    case 8:
                        grs.DrawImage(imgList.Images[8], row * _size, col * _size); break;
                }
                kiemTraODaMo[row, col] = 1;
            }
        } // Thêm Thuộc Tính img list 

        public void openEmpty(int row, int col)
        {
            if (kiemTraODaMo[row, col] == 0 && ocamCo[row, col] == -2)
            {
                kiemTraODaMo[row, col] = 1;
                grs.DrawImage(imgList.Images[9], row * _size, col * _size);
                for (int i = row - 1; i <= row + 1; i++)
                    for (int j = col - 1; j <= col + 1; j++)
                        if (i >= 0 && i < _row && j >= 0 && j < _col)
                            if (kiemTraODaMo[i, j] == 0 && ocamCo[i, j] == -2 && mainboard[i, j] == 0)
                            {
                                openEmpty(i, j);
                            }
                            else
                            {
                                open(i, j);
                            }    
                                
            }

        } // Cần cập nhật open cho 3 loại game

        public void hienBom(int row, int col) 
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    if (mainboard[i, j] == -1)
                    {
                        grs.DrawImage(imgList.Images[10], i * _size, j * _size);
                        if (ocamCo[i, j] == -1)
                            grs.DrawImage(imgList.Images[11], i * _size, j * _size);
                    }
        } // Hiện ra khi kết thúc game

        public void veToaDo(int row, int col)
        {
            //Image img_cell = imgList.Images[0];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    grs.DrawImage(imgList.Images[0], i * _size, j * _size);
        } // xong

        public void clickLeft(int row, int col)
        {

            if (indexTime == 1)
            {
                indexTime = 2;
                tmrClock.Enabled = true;
                tmrClock.Start();
            }
            if (kiemTraODaMo[row, col] == 0 && ocamCo[row, col] == -2)
            {
                switch (mainboard[row, col])
                {
                    case -1:
                        if (flagLevel == true)
                            hienBom(_row, _col);
                        else
                            hienBom(_rowCTM, _colCTM);
                        // Cập Nhật cho 3 Chế độ
                        tmrClock.Enabled = false;
                        if (flagLevel == true)
                            endGame(_row, _col);
                        else
                            endGame(_rowCTM, _colCTM);


                        // Thông báo Thành Tích
                        flagEndGame = true;
                        win_Loss = "YOU LOSE";
                        replay_Next = "REPLAY";
                        showPanelNextLv();
                        break;
                    case 0:
                        openEmpty(row, col);
                        break;
                    default:
                        open(row, col); // Cập nhật cho 3 chế độ
                        break;
                }
                kiemTraODaMo[row, col] = 1;
            }
        } // xong

        public void clickRight(int row, int col)
        {
            //Biến lưu imgList

            if (kiemTraODaMo[row, col] == 0)
            { 

                if (ocamCo[row, col] == -2)
                {
                    if (Convert.ToInt32(lbFlag.Text) <= 0)
                        return;
                    grs.DrawImage(imgList.Images[12], row * _size, col * _size);
                    ocamCo[row, col] = -1;
                    lbFlag.Text = (Convert.ToInt32(lbFlag.Text) - 1).ToString();
                }
                else
                {
                    grs.DrawImage(imgList.Images[0], row * _size, col * _size);
                    ocamCo[row, col] = -2;
                    lbFlag.Text = (Convert.ToInt32(lbFlag.Text) + 1).ToString();
                }
                if (mainboard[row, col] == ocamCo[row, col])
                    bomCount++;
                if (bomCount == _mine && lbFlag.Text == "0")
                {
                    //win 
                    tmrClock.Enabled = false;
                    if (flagLevel == true)
                        endGame(_row, _col);
                    else
                        endGame(_rowCTM, _colCTM);

                    
                    // Thông báo Thành Tích
                    flagEndGame = true;
                    win_Loss = "YOU WIN";
                    replay_Next = "NEXT";
                    showPanelNextLv();
                }
            }

        } // xong

        public void restart()
        {
            minute = 0;
            second = 0;
            tmrClock.Enabled = false;
            lbTime.Text = "0 : 0";
            lbFlag.Text = _mine.ToString();
            lbBomb.Text = _mine.ToString();
            indexTime = 1;
            bomCount = 0;
            mainboard = new int[_row, _col];
            ocamCo = new int[_row, _col];
            kiemTraODaMo = new int[_row, _col];
            initFlag(_row, _col);
            init(_row, _col, _mine);
            panelPlay.Controls.Add(panelG);
            this.panelG.Size = new System.Drawing.Size(_row * _size, _col * _size);
            grs = panelG.CreateGraphics();
            
            veToaDo(_row, _col);
        } // xong

        public void restartCustomer()
        {
            //if (flagEndGame == true)
            //{
            //    flagEndGame = false;
            //}
            minute = 0;
            second = 0;
            tmrClock.Enabled = false;
            lbTime.Text = "0 : 0";
            lbFlag.Text = _mineCTM.ToString();
            lbBomb.Text = _mineCTM.ToString();
            indexTime = 1;
            bomCount = 0;
            mainboard = new int[_rowCTM, _colCTM];
            ocamCo = new int[_rowCTM, _colCTM];
            kiemTraODaMo = new int[_rowCTM, _colCTM];
            initFlag(_rowCTM, _colCTM);
            init(_rowCTM, _colCTM, _mineCTM);
            panelPlay.Controls.Add(panelG);
            this.panelG.Size = new System.Drawing.Size(_rowCTM * _size, _colCTM * _size);
            grs = panelG.CreateGraphics();

            veToaDo(_rowCTM,_colCTM);
        }  //xong

        
        // Init Level
        public void LevelEasy()
        {
            level = 1;
            lbLevel.Text = "EASY";
            _row = 10;
            _col = 10;
            _mine = 10;
            _size = 30;
            imgList.ImageSize = new Size(30, 30);
            panelG.Location = new Point(308, 98);
            restart();
        } //xong

        public void LevelNormal()
        {
            level = 2;
            lbLevel.Text = "NORMAL";
            _row = 16;
            _col = 16;
            _mine = 40;
            _size = 30;
            imgList.ImageSize = new Size(30, 30);
            panelG.Location = new Point(218, 8);
            restart();
        } // xong

        public void LevelHard()
        {
            level = 3;
            lbLevel.Text = "HARD";
            _row = 30;
            _col = 16;
            _mine = 99;
            _size = 30;
            imgList.ImageSize = new Size(30, 30);
            panelG.Location = new Point(7, 7);
            restart();
        } // xong

        public void levelCustomer()
        {
                lbLevel.Text = "CUSTOMER";
                _size = 30;
                imgList.ImageSize = new Size(30, 30);
                restartCustomer();
                // Canh Chinh Panel
                int x = ((panelPlay.Size.Width - panelG.Size.Width) / 2) - 2;
                int y = ((panelPlay.Size.Height - panelG.Size.Height) / 2) - 2;
                panelG.Location = new Point(x, y);   
        } // xong

        // Save Score
        List<Diem> bangDiem = new List<Diem>();

        public void initBangDiem()
        {
            for(int i = 0; i < 5; i++)
            {
                Diem d = new Diem();
                d.setTime(0);
                d.setScore(0);
                bangDiem.Add(d);
            }    
        }
        string duongDan = @"D:\Ketqua.txt";
        StreamWriter w;
        StreamReader r;
        public void outFile()
        {
            if (!File.Exists(duongDan))
            {
                using (w = File.CreateText(duongDan))//tạo mới 1 file)
                {
                    foreach (Diem diem in bangDiem)
                    {
                        w.WriteLine(diem.getTime().ToString() + "/" + diem.getScore().ToString());
                    }
                }
                w.Close();
            }
            //Nếu có rồi ghi đè
            else
            {
                w = new StreamWriter(duongDan);
                foreach (Diem diem in bangDiem)
                {
                    w.WriteLine(diem.getTime().ToString() + " " + diem.getScore().ToString());
                }
                w.Close();
            }
        }

        public void inFile()
        {
            if (!File.Exists(duongDan))
            {
                w = File.CreateText(duongDan);
            }
            //Nếu có rồi đọc lại
            else
            {
                string s = "";
                r = new StreamReader(duongDan);
                int i = 0;

                while ((s = r.ReadLine()) != null && i < 5)
                {
                    // xử lý tách chuổi thành 2 cái là time và score
                    int time = 0;
                    int score = 0;
                    int vitri = 0;
                    while (!s[vitri].Equals(' '))
                        vitri++;

                    time = int.Parse(s.Substring(0,vitri));
                    score = int.Parse(s.Substring(vitri + 1));

                    // gán giá trị cho mang
                    Diem d = new Diem();
                    d.setTime(time);
                    d.setScore(score);
                    bangDiem.Add(d);
                    i++;
                }    
                r.Close();
            }
        }
        
        public void xuatDiem(int time, int score)
        {
            if (score == 1)
                if (bangDiem[0].getTime() > time)
                    bangDiem[0].setDiem(time, score);

            if (score == 2)
            {
                int i = 1;
                while (bangDiem[i].getScore() == 2)
                {
                    if (bangDiem[i].getTime() > time)
                        bangDiem[i].setDiem(time, score);
                    i++;
                }
            }

            if (score == 3)
            {
                int j = 3;
                while (bangDiem[j].getScore() == 3)
                {
                    if (bangDiem[j].getTime() > time)
                        bangDiem[j].setDiem(time, score);
                    j++;
                }
            }
        }

        // Action Button
        private void btOK_Click(object sender, EventArgs e)
        {
            _rowCTM = int.Parse(lbRow.Text);
            _colCTM = int.Parse(lbCol.Text);
            _mineCTM = int.Parse(lbMine.Text);

            panelPlay.Controls.Remove(panelCustomer);
            panelCustomer = null;
            flagCustomer = false;
            levelCustomer();
        } // xong

        private void btNextLv_Click(object sender, EventArgs e)
        {
            if (flagLevel == true)
                if (btNextLv.Text == "NEXT")
                {
                    if (level == 1)
                    {
                        xuatDiem((second + (minute * 60)), level);
                        LevelNormal();
                    }
                    else if (level == 2)
                    {
                        xuatDiem((second + (minute * 60)), level);
                        LevelHard();
                    }
                    else
                    {
                        xuatDiem((second + (minute * 60)), level);
                        LevelHard();
                    }
                }
                else
                {
                    if (level == 1)
                        LevelEasy();
                    else if (level == 2)
                        LevelNormal();
                    else
                        LevelHard();
                }
            else
                restartCustomer();
            flagEndGame = false;
            panelPlay.Controls.Remove(panelNextLv);
            panelNextLv = null;

        } // xong

        private void btCongRow_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbRow.Text);
            if (temp >= 30)
                return;
            else
            {
                temp += 1;
                lbRow.Text = temp.ToString();
            }    
        } // xong

        private void picBbtHome_Click(object sender, EventArgs e)
        {
            this.Close();
        } // xong

        private void picBbtMute_Click(object sender, EventArgs e)
        {
            if (audioOn_Off == true)
            {
                picBbtMute.Image = Properties.Resources.btmuteOff1;
                audioOn_Off = false;
                Sound.Stop();
            }
            else
            {
                picBbtMute.Image = Properties.Resources.btmuteOn1;
                audioOn_Off = true;
                Sound.Play();
            }    
                
        } // xong

        private void FormPlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sound.Stop();
            outFile();
        } // xong

        private void btCongCol_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbCol.Text);
            if (temp >= 16)
                return;
            else
            {
                temp += 1;
                lbCol.Text = temp.ToString();
            }
        } // xong

        private void btCongMine_Click(object sender, EventArgs e)
        {
            int temp1 = int.Parse(lbMine.Text);
            int temp2 = int.Parse(lbRow.Text);
            int temp3 = int.Parse(lbCol.Text);
            if (temp1 >= (((temp2 * temp3) * 50) / 100))
                return;
            else
            {
                temp1 += 1;
                lbMine.Text = temp1.ToString();
            }
        } // xong

        private void btTruRow_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbRow.Text);
            if (temp <= 10)
                return;
            else
            {
                temp -= 1;
                lbRow.Text = temp.ToString();
            }
        } // xong

        private void btTruCol_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbCol.Text);
            if (temp <= 10)
                return;
            else
            {
                temp -= 1;
                lbCol.Text = temp.ToString();
            }
        } // xong

        private void btTruMine_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(lbMine.Text);
            if (temp <= 10)
                return;
            else
            {
                temp -= 1;
                lbMine.Text = temp.ToString();
            }
        } // xong

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            if (flagLevel == true)
                veToaDo(_row, _col);
            else
                veToaDo(_rowCTM, _colCTM);
        } // xong

        private void panelGame_MouseDown(object sender, MouseEventArgs e)
        {
            flagRestar = true;
            int row = e.X / _size;
            int col = e.Y / _size;
            if (e.Button == MouseButtons.Left)
                clickLeft(row, col);
            else
                clickRight(row, col);
        } // xong

        private void picBbtEasy_Click(object sender, EventArgs e)
        {
            if (flagEndGame == true || flagCustomer == true)
                return;
            else
            {
                if (flagLevel == false)
                    flagLevel = true;
                LevelEasy();
            }
        } // xong

        private void picBbtHard_Click(object sender, EventArgs e)
        {
            if (flagEndGame == true || flagCustomer == true)
                return;
            else
            {
                if (flagLevel == false)
                    flagLevel = true;
                LevelHard();
            }
        } // xong

        private void picBbtNormal_Click(object sender, EventArgs e)
        {
            if (flagEndGame == true || flagCustomer == true)
                return;
            else
            {
                if (flagLevel == false)
                    flagLevel = true;
                LevelNormal();
            }
        } // xong

        private void picBbtCustomer_Click(object sender, EventArgs e) 
        {
            if (flagEndGame == true || flagCustomer == true)
                return;
            else
            {
                if (flagLevel == true)
                    flagLevel = false;
                initPanelCustomer();
                showPanelCustomer();
            }
            
        } // xong

        private void picBbtReplay_Click(object sender, EventArgs e)
        {
            if (flagEndGame == true)
                return;
            else
            {
                if (flagRestar == false)
                    return;
                else
                {
                    if (flagLevel == true)
                        restart();
                    else
                    {
                        restartCustomer();
                    }
                    flagRestar = false;
                }
            }
        } // xong
        // ------------------------------------

        private void FormPlay_Load(object sender, EventArgs e)
        {
            panelThongTin.BackColor = Color.FromArgb(0, 0, 0, 0);
            panelTuyChon.BackColor = Color.FromArgb(0, 0, 0, 0);
            panelPlay.BackColor = Color.FromArgb(0, 0, 0, 0);
            initSound();
            inFile();
        } // xong

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            second++;

            if (second > 60)
            {
                minute += 1;
                second = 0;
            }    
            lbTime.Text = String.Format("{0} : {1}", minute, second);
        } // xong

    }
}
