using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_DOMIN
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

        }

        List<Diem> bangDiem = new List<Diem>();
        Panel panelLeaderBoard;
        string duongDan = @"D:\Ketqua.txt";
        bool flag = true;
        StreamReader r;
        StreamWriter w;

        //Xu ly lấy dữ liệu từ file
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

                    time = int.Parse(s.Substring(0, vitri));
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

        public string xuatTime(int a)
        {
            int giay = a % 60;
            int phut = a / 60;
            string sT = string.Format("{0} : {1}", phut, giay);
            Console.WriteLine(sT);
            return sT;
        } //xong

        public Panel createPanelLeaderBoard()
        {
            Panel panelLeaderBoard = new Panel();
            panelLeaderBoard.BackColor = Color.Gray;
            panelLeaderBoard.Size = new Size(497, 263);
            panelLeaderBoard.BorderStyle = BorderStyle.Fixed3D;
            panelLeaderBoard.Location = new Point(450, 244);
            panelLeaderBoard.BackgroundImageLayout = ImageLayout.Stretch;
            panelLeaderBoard.BackgroundImage = Properties.Resources.LeaderBoard;
            panelLeaderBoard.BackColor = Color.FromArgb(0, 0, 0, 0);


            Label lb0 = new Label();
            lb0.Text = xuatTime(bangDiem[0].getTime());
            lb0.Size = new Size(71, 28);
            lb0.AutoSize = true;
            lb0.Location = new Point(206, 39);
            lb0.ForeColor = Color.Gainsboro;
            lb0.Font = new Font("Kristen ITC", 12, FontStyle.Bold);

            Label lb1 = new Label();
            lb1.Text = xuatTime(bangDiem[1].getTime());
            lb1.Size = new Size(71, 28);
            lb1.AutoSize = true;
            lb1.Location = new Point(206, 80);
            lb1.ForeColor = Color.Gainsboro;
            lb1.Font = new Font("Kristen ITC", 12, FontStyle.Bold);

            Label lb2 = new Label();
            lb2.Text = xuatTime(bangDiem[2].getTime());
            lb2.Size = new Size(71, 28);
            lb2.AutoSize = true;
            lb2.Location = new Point(206, 124);
            lb2.ForeColor = Color.Gainsboro;
            lb2.Font = new Font("Kristen ITC", 12, FontStyle.Bold);

            Label lb3 = new Label();
            lb3.Text = xuatTime(bangDiem[3].getTime());
            lb3.Size = new Size(71, 28);
            lb3.AutoSize = true;
            lb3.Location = new Point(206, 163);
            lb3.ForeColor = Color.Gainsboro;
            lb3.Font = new Font("Kristen ITC", 12, FontStyle.Bold);

            Label lb4 = new Label();
            lb4.Text = xuatTime(bangDiem[4].getTime());
            lb4.Size = new Size(71, 28);
            lb4.AutoSize = true;
            lb4.Location = new Point(206, 206);
            lb4.ForeColor = Color.Gainsboro;
            lb4.Font = new Font("Kristen ITC", 12, FontStyle.Bold);

            PictureBox picB = new PictureBox();
            picB.Image = Properties.Resources.imgsand_clock;
            picB.Size = new Size(41, 41);
            picB.SizeMode = PictureBoxSizeMode.StretchImage;
            picB.Location = new Point(450, 9);
            picB.Click += new System.EventHandler(this.picB_Click);

            panelLeaderBoard.Controls.Add(lb0);
            panelLeaderBoard.Controls.Add(lb1);
            panelLeaderBoard.Controls.Add(lb2);
            panelLeaderBoard.Controls.Add(lb3);
            panelLeaderBoard.Controls.Add(lb4);

            panelLeaderBoard.Controls.Add(picB);

            return panelLeaderBoard;
        } // xong

        public void initPanelLeaderBoard()
        {
            panelLeaderBoard = createPanelLeaderBoard();
        }
        // Action
        private void FormHome_Load(object sender, EventArgs e)
        {
            panelHome.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void picBbtPlay_Click(object sender, EventArgs e)
        {
            if (flag == false)
                return;
            FormPlay f = new FormPlay();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void picBbtLeaderB_Click(object sender, EventArgs e)
        {
            inFile();
            if (flag == false)
                return;
            initPanelLeaderBoard();
            flag = false;
            panelHome.Controls.Add(panelLeaderBoard);
        }

        private void picB_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Remove(panelLeaderBoard);
            panelLeaderBoard = null;
            flag = true;
        }

    }
}
