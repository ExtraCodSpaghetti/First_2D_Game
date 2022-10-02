using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;
namespace _2D_LastDay
{
    public partial class Form1 : Form
    {
        PictureBox[] pictureBox1;     
        PictureBox[] bullets;
        PictureBox[] enemies;
        Random random;

        int playerSpeed;
        int backgroundspeed;
        int bulletsSpeed;
        int enemySpeed;
        int Score;
        int lvl;
        int CorLive;
        int Tree;


        WindowsMediaPlayer Shoot;
        WindowsMediaPlayer GameSong;
        WindowsMediaPlayer Rip;
        WindowsMediaPlayer PlayerRip;
        WindowsMediaPlayer GameEpic;
        WindowsMediaPlayer HitM;
        WindowsMediaPlayer HitTr;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < pictureBox1.Length; i++)
            {
                pictureBox1[i].Left += backgroundspeed;

                if (pictureBox1[i].Left >= 1280)
                {
                    pictureBox1[i].Left = pictureBox1[i].Height;
                }
            }

            for (int i = pictureBox1.Length; i < pictureBox1.Length; i++)
            {
                pictureBox1[i].Left += backgroundspeed -10;

                if (pictureBox1[i].Left >= 1280)
                {
                    pictureBox1[i].Left = pictureBox1[i].Left;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 5;
            playerSpeed = 3;
            bulletsSpeed = 80;
            enemySpeed = 5;


            pictureBox1 = new PictureBox[20];
            bullets = new PictureBox[1];
            random = new Random();

            Shoot = new WindowsMediaPlayer();
            Shoot.URL = "songs\\shoot.mp3";
            Shoot.settings.volume = 40;
            Shoot.controls.stop();

            Rip = new WindowsMediaPlayer();
            Rip.URL = "songs\\Rip.mp3";
            Rip.settings.volume = 30;
            Rip.controls.stop();

            HitM = new WindowsMediaPlayer();
            HitM.URL = "songs\\HitMain.mp3";
            HitM.settings.volume = 30;
            HitM.controls.stop();

            HitTr = new WindowsMediaPlayer();
            HitTr.URL = "songs\\HitTree.mp3";
            HitTr.settings.volume = 30;
            HitTr.controls.stop();

            PlayerRip = new WindowsMediaPlayer();
            PlayerRip.URL = "songs\\GameOver.mp3";
            PlayerRip.settings.volume = 45;
            PlayerRip.controls.stop();

            GameEpic = new WindowsMediaPlayer();
            GameEpic.URL = "songs\\GameEpic.mp3";
            GameEpic.settings.volume = 45;
            GameEpic.controls.stop();

            GameSong = new WindowsMediaPlayer();
            GameSong.URL = "songs\\GameSong.mp3";
            GameSong.settings.setMode("loop", true);
            PlayerRip.settings.volume = 45;

            enemies = new PictureBox[4];
            int sizeEnemy = random.Next(60, 80);

            Score = 0;
            lvl = 1;
            CorLive = 100;
            Tree = 300;


            Image easyEnemy = Image.FromFile("assets\\apap.gif");

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(sizeEnemy, sizeEnemy);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BackColor = Color.Transparent;
                enemies[i].Image = easyEnemy;
                enemies[i].Location = new Point((i + 1) * random.Next(90, 160) + 1080, random.Next(450,600));
                this.Controls.Add(enemies[i]);
            }


            for (int i = 0; i< bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].BorderStyle = BorderStyle.None;
                bullets[i].Size = new Size(20, 5);
                bullets[i].BackColor = Color.White; 

                this.Controls.Add(bullets[i]);
            }

            for (int i = 0; i < pictureBox1.Length; i++)
            {
                pictureBox1[i] = new PictureBox();
                pictureBox1[i].BorderStyle = BorderStyle.None;
                pictureBox1[i].Location = new Point(random.Next(-1000, 1280), random.Next(140, 320));
                if (i % 2 == 1)
                {
                    pictureBox1[i].Size = new Size(random.Next(100, 255), random.Next(30, 70));
                    pictureBox1[i].BackColor = Color.FromArgb(random.Next(50, 125), 255, 200, 200);
                }
                else
                {
                    pictureBox1[i].Size = new Size( 150, 25);
                    pictureBox1[i].BackColor = Color.FromArgb(random.Next(50, 125), 255, 205, 205);
                }
                this.Controls.Add(pictureBox1[i]);
            }
            GameSong.controls.play();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (MainPlayer.Left >200) 
            {
                MainPlayer.Left -= playerSpeed;
            }
        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (MainPlayer.Left < 1150)
            {
                MainPlayer.Left += playerSpeed;
            }
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            MainPlayer.Top -= playerSpeed;
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            MainPlayer.Top += playerSpeed;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MainPlayer.Image = Properties.Resources.cowboy_run;

            if(e.KeyCode == Keys.Left)
            {
                LeftMoveTimer.Start();
            }
            if (e.KeyCode == Keys.Right)
            {
                RightMoveTimer.Start();
            }
            if (e.KeyCode == Keys.Up)
            {
                UpMoveTimer.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                DownMoveTimer.Start();
            }

            if(e.KeyCode == Keys.Space)
            {
                Shoot.controls.play();
                for(int i = 0; i < bullets.Length; i++)
                {
                    Intersect();
                    if (bullets[i].Left > 1280)
                    {
                        bullets[i].Location = new Point(MainPlayer.Location.X + 100 + i * 50, MainPlayer.Location.Y + 50);
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            MainPlayer.Image = Properties.Resources.cowboy_idble;
            LeftMoveTimer.Stop();
            RightMoveTimer.Stop();
            UpMoveTimer.Stop();
            DownMoveTimer.Stop();
        }

        private void MoveBulletsTimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < bullets.Length; i++)
            {
                bullets[i].Left += bulletsSpeed;
            }
        }

        private void MoveEnemiesTime_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemySpeed);
        }
        public void MoveEnemies(PictureBox[] enemies, int speed)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                Intersect();

                enemies[i].Left -= speed + (int)(Math.Sin(enemies[i].Left * Math.PI / 180) + Math.Cos(enemies[i].Left * Math.PI / 180));

                if(enemies[i].Left < 100)
                {
                    int sizeEnemy = random.Next(60, 90);
                    enemies[i].Size = new Size(sizeEnemy, sizeEnemy);
                    enemies[i].Location = new Point((i + 1) * random.Next(190, 250) + 1080, random.Next(450, 700));
                }
            }
        }

        private void MainPlayer_Click(object sender, EventArgs e)
        {

        }

        private void Intersect()
        {
           
            for (int i = 0; i < enemies.Length; i++)
            {
                if (bullets[0].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    Rip.controls.play();

                    Score += 1;
                    labelScore.Text = (Score < 10) ? "0" + Score.ToString() : Score.ToString();

                    if (Score % 10 == 0)
                    {
                        lvl += 1;
                        labelLVL.Text = (lvl < 10) ? "0" + lvl.ToString() : lvl.ToString();
                        enemySpeed += 2;
                        playerSpeed += 1;

                        if (lvl == 11)
                        {
                            GamePover("Epic Pover!");
                        }
                    }

                    enemies[i].Location = new Point((i + 1) * random.Next(190, 250) + 1280, random.Next(420, 600));
                    bullets[0].Location = new Point(2000, MainPlayer.Location.Y + 50);
                }

                if (MainPlayer.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    HitM.controls.play();
                    CorLive -= 1;
                    CorLavel.Text = (CorLive == 0) ? "0" + CorLive.ToString() : CorLive.ToString();
                    if (CorLive == 0)
                    {
                        GameOver("Wasted!\n You were killed by your enemies!");
                        MainPlayer.Visible = false;
                    }                   
                }

                if (TreeBox.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    HitTr.controls.play();
                    Tree -= 1;
                    HPTreeBox.Text = (Tree == 0) ? "0" + Tree.ToString() : Tree.ToString();
                    if (Tree == 0)
                    {
                        GameOver("Wasted!\n Enemies destroyed the last surviving tree!");
                        MainPlayer.Visible = false;
                    }
                }
            }

            
        }

        private void GamePover(string str)
        {
            label1.Text = str;
            label1.Location = new Point(500, 50);
            label1.Visible = true;

            GameSong.controls.stop();
            MoveEnemiesTime.Stop();
            GameEpic.controls.play();
        }
        private void GameOver(string str)
        {
            label1.Text = str;
            label1.Location = new Point(500, 50);
            label1.Visible = true;

            GameSong.controls.stop();
            MoveEnemiesTime.Stop();
            PlayerRip.controls.play();


        }
    }
}
