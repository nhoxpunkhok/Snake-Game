using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Snake_Game__o.o_
{
    public partial class Form1 : Form
    {
        private int square = 10;
        private int sohang = 30;
        private int socot = 50;
        PictureBox[,] Map = new PictureBox[50, 50];
        private Point start = new Point(30, 30);
        private int snakeX = 0;
        private int snakeY = 0;
        private int foodX = 0;
        private int foodY = 0;
        private int dir = 0;//1=up 2=left 3=down 4=right
        private int score = 0;
        Random r = new Random();
        Point[] bodyran = new Point[100];
        private int body = 1;
        public Form1()
        {
            InitializeComponent();
        }

        public void updateInfo()
        {
            lbScore.Text = "Score : " + score.ToString();
            if(gametick.Enabled==false)
            {
                btnStart.Text = "Resume Game";
            }
            
        }
        private void Form1_Load(object sender, EventArgs e) //hàm setup
        {
            veMap();
            snakeX = sohang / 2;
            snakeY = socot / 2;
            dir = 1;
            foodX = r.Next(1, sohang - 1);
            foodY = r.Next(1, socot - 1);
            while (foodX == snakeX && foodY == snakeY)
            {
                foodX = r.Next(1, sohang - 1);
                foodY = r.Next(1, socot - 1);
            }
            body = 1;
            btnRES.Hide();
        }

        public void veRan()
        {
            Map[snakeX, snakeY].BackColor = Color.Red;
            for(int i=99;i>=1;i--)
            {
                bodyran[i] = bodyran[i - 1];
            }
            bodyran[0].X = snakeX;
            bodyran[0].Y = snakeY;
            for(int i=1;i<body;i++)
            {
                Map[bodyran[i].X, bodyran[i].Y].BackColor = Color.Red;
            }
        }
        public void veMap()
        {
            for (int i = 0; i < sohang; i++)
            {
                for (int j = 0; j < socot; j++)
                {
                    Map[i, j] = new PictureBox();
                    Map[i, j].Left = start.X + j * square;//vị trí của cạnh bên trái so với lề
                    Map[i, j].Top = start.Y + i * square;//vị trí của cạnh trên so với lề
                    Map[i, j].Width = square + 1;
                    Map[i, j].Height = square + 1;
                    Map[i, j].BackColor = Color.Black;
                    Map[i, j].BorderStyle = BorderStyle.FixedSingle;
                    Controls.Add(Map[i, j]);
                }
            }
            for(int i=0;i<sohang;i++)
            {
                Map[i, 0].BackColor = Color.White;
                Map[i, socot - 1].BackColor = Color.White;
            }
            for(int i=0;i<socot;i++)
            {
                Map[0,i].BackColor = Color.White;
                Map[sohang-1,i].BackColor = Color.White;
            }
        }
        public void resetMap()
        {
            for(int i=1;i<sohang-1;i++)
            {
                for(int j=1;j<socot-1;j++)
                {
                   if(Map[i, j].BackColor!=Color.Yellow)
                    {
                        Map[i, j].BackColor = Color.Black;
                    }
                }
            }
           Map[snakeX,snakeY].BackColor=Color.Black;
        }
        private void Gametick_Tick(object sender, EventArgs e)
        {
            resetMap();
            input();
            veFood();
            veRan();
            check();
            updateInfo();

        }
        public void veFood()
        {
            while(Map[foodX, foodY].BackColor==Color.Red)
            {
                foodX = r.Next(1, sohang - 1);
                foodY = r.Next(1, socot - 1);
            }
            Map[foodX, foodY].BackColor = Color.Yellow;
        }
        public void resetgame()
        {
            for (int i = 1; i < sohang-1; i++)
            {
                for (int j = 1; j < socot-1; j++)
                {
                    Map[i, j].BackColor = Color.Black;
                }
            }
            for (int i = 0; i < sohang; i++)
            {
                Map[i, 0].BackColor = Color.White;
                Map[i, socot - 1].BackColor = Color.White;
            }
            for (int i = 0; i < socot; i++)
            {
                Map[0, i].BackColor = Color.White;
                Map[sohang - 1, i].BackColor = Color.White;
            }
            snakeX = sohang / 2;
            snakeY = socot / 2;
            foodX = r.Next(1, sohang - 1);
            foodY = r.Next(1, socot - 1);
            while (foodX==snakeX&&foodY==snakeY)
            {
                foodX = r.Next(1, sohang - 1);
                foodY = r.Next(1, socot - 1);
            }
            score = 0;
            body = 1;
            btnStart.Text = "START GAME !!!";
            gametick.Interval = 180;
            dir = 1;
        }
        public void input()
        {
            if(dir==1)
            {
                snakeX--;
            }
            else if(dir==2)
            {
                snakeY--;
            }
            else if(dir==3)
            {
                snakeX++;
            }
            else
            {
                snakeY++;
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {          
            if (keyData == Keys.Up)
            {
                dir = 1;
                return true;
            }           
            if (keyData == Keys.Down)
            {
                dir = 3;
                return true;
            }          
            if (keyData == Keys.Left)
            {
                dir = 2;
                return true;
            }            
            if (keyData == Keys.Right)
            {
                dir = 4;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void check()
        {
            if(snakeX==0||snakeX==sohang-1||snakeY==0||snakeY==socot-1)
            {
                gametick.Enabled = false;
                MessageBox.Show("Bạn đã đập đầu vào tường rồi :V\nTotal score : " + score.ToString(), "Game Over !!!", MessageBoxButtons.OK);
                DialogResult a= MessageBox.Show("Bạn có muốn choi lại ?", "Play Again ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(a==DialogResult.Yes)
                {
                    resetgame();
                    gametick.Enabled = true;
                }
                else
                {
                    resetgame();
                }

            }

            for(int i=1;i<body;i++)
            {
                if(snakeX==bodyran[i].X&&snakeY==bodyran[i].Y)
                {
                    gametick.Enabled = false;
                    MessageBox.Show("Bạn đã cắn vào đuôi rồi :V\nTotal score : " + score.ToString(), "Game Over !!!", MessageBoxButtons.OK);
                    DialogResult a = MessageBox.Show("Bạn có muốn choi lại ?", "Play Again ???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (a == DialogResult.Yes)
                    {
                        resetgame();
                        gametick.Enabled = true;
                    }
                    else
                    {
                        resetgame();
                    }
                }
            }
            if(snakeX==foodX&&snakeY==foodY)
            {
                body++;
                if(body==100)
                {
                    body--;
                }
                score += r.Next(7,11);
                while (Map[foodX, foodY].BackColor == Color.Red)
                {
                    foodX = r.Next(1, sohang - 1);
                    foodY = r.Next(1, socot - 1);
                }
                gametick.Interval = 180 - body * 5;
            }

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(gametick.Enabled==true)
            {
                gametick.Enabled = false;
                btnStart.Text = "START GAME !!!";
            }
            else
            {
                gametick.Enabled = true;
                btnStart.Text = "PAUSE GAME";
            }
            lbInfo.Hide();
            lbInfo2.Hide();
            btnRES.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            gametick.Enabled = false;
            DialogResult a = MessageBox.Show("Thoát trò chơi ngay bây giờ ?", "Quit Game ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a==DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnHD_Click(object sender, EventArgs e)
        {
            gametick.Enabled = false;
            MessageBox.Show("Điều khiển con rắn(đỏ) đi săn mồi(vàng)\nSử dụng các phím mũi tên để di chuyển rắn\n" +
                "Tránh cắn vào đuôi và đập đầu vô tường :V","Game Rule",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void BtnRES_Click(object sender, EventArgs e)
        {
            gametick.Enabled = false;
            DialogResult a = MessageBox.Show("Bạn có muốn chơi lại ?", "Restart Game ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a==DialogResult.Yes)
            {
                resetgame();
                btnStart.Text = "PAUSE GAME";
                gametick.Enabled = true;
            }

        }
    }
}
