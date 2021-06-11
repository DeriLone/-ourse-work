using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBallista
{
    public partial class Form1 : Form
    {
        public Bitmap ballista = Resource1.ballista;
        public Bitmap explosion = Resource1.explosion;

        private int numberOfAvailableShots = 5;
        private int currentFrameBallistaAnimation = 0;
        private int currentFrameExplosionAnimationX = 0;
        private int currentFrameExplosionAnimationY = 0;
        private int initialBulletX;
        private int initialBulletY;

        private bool isPressedButton = false;
        private bool readyToFire = true;
        private bool startFire = false;
        private bool expAnim = false;
        private bool EnemyMove = false;
        private bool IsFirstBallistaShooting = true;
        private bool STOPGAME = false;
        private bool BallistaBreak = false;

        private double AngleValue;
        private double ForceValue;
        private double WeightValue;
        private double Timer;
        private double t = 0;
        private double landingX;

        const double g = 9.8;


        public Form1()
        {
            InitializeComponent();

            BallistaSpawn();
            EnemyBallistaSpawn();

            timer1.Interval = 125;
            timer1.Tick += new EventHandler(BallistaShootingAnimation);
            timer1.Tick += new EventHandler(BallistaBreakingAnimation);
            timer1.Start();

            timer2.Interval = 80;
            timer2.Tick += new EventHandler(BulletAnimation);
            timer2.Start();

            timer3.Interval = 180;
            timer3.Tick += new EventHandler(ExplosionAnimation);
            timer3.Start();

            timer4.Interval = 700;
            timer4.Tick += new EventHandler(FlashingText);
            timer4.Start();

            SetStyle(ControlStyles.OptimizedDoubleBuffer | 
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.UserPaint, true);

            UpdateStyles();
        }

        private void BallistaBreakingAnimation(object sender, EventArgs e)
        {
            if(BallistaBreak == true)
            {
                if(IsFirstBallistaShooting == false)
                {
                    BallistaBreaking();
                    currentFrameBallistaAnimation++;

                    if (currentFrameBallistaAnimation == 8)
                    {
                        currentFrameBallistaAnimation = 0;
                        BallistaBreak = false;
                    }
                }
                else
                {
                    EnemyBallistaBreaking();
                    currentFrameBallistaAnimation++;

                    if (currentFrameBallistaAnimation == 8)
                    {
                        currentFrameBallistaAnimation = 0;
                        BallistaBreak = false;
                    }
                }
            }
        }

        private void BallistaBreaking()
        {
            Image part = new Bitmap(125, 90);
            Graphics g = Graphics.FromImage(part);
            g.DrawImage(ballista, 0, 0, new Rectangle(new Point(140 * currentFrameBallistaAnimation, 508), new Size(144, 150)), GraphicsUnit.Pixel);
            Ballista1.Size = new Size(125, 90);
            Ballista1.Image = part;
        }

        private void EnemyBallistaBreaking()
        {
            Image part = new Bitmap(125, 90);
            Graphics g = Graphics.FromImage(part);
            g.DrawImage(ballista, 0, 0, new Rectangle(new Point(140 * currentFrameBallistaAnimation, 508), new Size(144, 150)), GraphicsUnit.Pixel);
            Ballista2.Size = new Size(125, 90);
            part.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Ballista2.Image = part;
        }

        private void FlashingText(object sender, EventArgs e)
        {
            if (IsFirstBallistaShooting == true && button1.Enabled == true && STOPGAME == false)
            {
                WhoseTurn.Visible = !WhoseTurn.Visible;
            }
            else
            {
                WhoseTurn.Visible = true;
            }
        }

        private void ExplosionAnimation(object sender, EventArgs e)
        {
            if (expAnim == true && STOPGAME == false)
            {

                DrawExplosionAnimation();
                if (IsFirstBallistaShooting == true)
                {
                    explosionBox.Location = new Point(bullet.Location.X - 50, 483);
                }
                else
                {
                    explosionBox.Location = new Point(bullet.Location.X - 50, 483);
                }
                currentFrameExplosionAnimationX++;

                if (currentFrameExplosionAnimationX == 5)
                {
                    if (currentFrameExplosionAnimationY == 3)
                    {
                        expAnim = false;
                        currentFrameExplosionAnimationX = 0;
                        currentFrameExplosionAnimationY = 0;

                        if(IsFirstBallistaShooting == true)
                        {            
                            EnemyMove = true;
                            CleanInput();
                            IsFirstBallistaShooting = false;
                            WhoseTurn.Text = "Ворожий хід";
                        }
                        else
                        {
                            WhoseTurn.Text = "Ваш хід";
                            if(STOPGAME == false)
                            {
                                ReadyToFire();
                                IsFirstBallistaShooting = true;
                            }
                        }
                    }
                    else
                    {
                        currentFrameExplosionAnimationX = 0;
                        currentFrameExplosionAnimationY++;
                    }
                }

            }
        }

        private void DrawExplosionAnimation()
        {
            Image part = new Bitmap(110, 120);
            Graphics g = Graphics.FromImage(part);
            g.DrawImage(explosion, 0, 0, new Rectangle(new Point(128 * currentFrameExplosionAnimationX, 155 * currentFrameExplosionAnimationY), new Size(110, 120)), GraphicsUnit.Pixel);
            explosionBox.Size = new Size(110, 120);
            explosionBox.Image = part;
            explosionBox.SendToBack();
        }

        private void BallistaSpawn()
        {
            Image part = new Bitmap(125, 90);
            Graphics g = Graphics.FromImage(part);
            g.DrawImage(ballista, 0, 0, new Rectangle(new Point(0, 150), new Size(144, 150)), GraphicsUnit.Pixel);
            Ballista1.Size = new Size(125, 90);
            Ballista1.Image = part;
        }

        private void EnemyBallistaSpawn()
        {
            Image part = new Bitmap(125, 90);
            Graphics g = Graphics.FromImage(part);
            g.DrawImage(ballista, 0, 0, new Rectangle(new Point(0, 150), new Size(144, 150)), GraphicsUnit.Pixel);
            Ballista2.Size = new Size(125, 90);
            part.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Ballista2.Image = part;
        }

        private void BallistaShootingAnimation(object sender, EventArgs e)
        {
            if (isPressedButton == true)
            {

                DrawBallistaAnimation();
                currentFrameBallistaAnimation++;

                if (currentFrameBallistaAnimation == 5)
                {
                    bullet.Visible = true;
                    initialValuesForBallista();
                    DrawBullet();
                }
                if (currentFrameBallistaAnimation == 8)
                {
                    currentFrameBallistaAnimation = 0;
                    isPressedButton = false;
                }
            }

            if(EnemyMove == true && STOPGAME == false)
            {
                DrawEnemyBallistaAnimation();
                currentFrameBallistaAnimation++;

                if (currentFrameBallistaAnimation == 5)
                {
                    bullet.Visible = true;
                    initialValuesForEnemyBallista();
                    EnemyValuesToFire();
                    DrawBullet();
                }
                if (currentFrameBallistaAnimation == 8)
                {
                    currentFrameBallistaAnimation = 0;
                    EnemyMove = false;
                }
            }
        }

        private void initialValuesForBallista()
        {
            initialBulletX = 223;
            initialBulletY = 499;
            bullet.Location = new Point(initialBulletX, initialBulletY);
        }

        private void initialValuesForEnemyBallista()
        {
            initialBulletX = 939;
            initialBulletY = 499;
            bullet.Location = new Point(initialBulletX, initialBulletY);
        }

        private void EnemyValuesToFire()
        {
            Random rnd = new Random();
            AngleValue = rnd.Next(30, 55) * Math.PI / 180;
            ForceValue = rnd.Next(80, 120);
            WeightValue = rnd.Next(1, 25); ;
            Timer = (2 * ForceValue * Math.Sin(AngleValue) / g) + 1;
        }

        private void DrawBallistaAnimation()
        {
            Image part = new Bitmap(125, 90);
            Graphics g = Graphics.FromImage(part);
            g.DrawImage(ballista, 0, 0, new Rectangle(new Point(144 * currentFrameBallistaAnimation, 150), new Size(144, 150)), GraphicsUnit.Pixel);
            Ballista1.Size = new Size(125, 90);
            Ballista1.Image = part;
        }

        private void DrawEnemyBallistaAnimation()
        {
            Image part = new Bitmap(125, 90);
            Graphics g = Graphics.FromImage(part);
            g.DrawImage(ballista, 0, 0, new Rectangle(new Point(144 * currentFrameBallistaAnimation, 150), new Size(144, 150)), GraphicsUnit.Pixel);
            Ballista2.Size = new Size(125, 90);
            part.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Ballista2.Image = part;
        }

        private void DrawBullet()
        {
            Bitmap bullet = new Bitmap(20, 20);
            Graphics graph = Graphics.FromImage(bullet);
            Pen pen = new Pen(Color.Black);
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            graph.DrawEllipse(pen, 0, 0, 20, 20);
            graph.FillEllipse(solidBrush, 0, 0, 20, 20);
            this.bullet.Image = bullet;

            startFire = true;
        }

        private void BulletAnimation(object sender, EventArgs e)
        {
            if (startFire == true && t <= Timer)
            {
                BulletBallistics();
                t = t + 0.5;
                if(t >= Timer)
                {
                    landingX = bullet.Location.X - 10;
                    CollisionCheck();
                    expAnim = true;
                }
            }
            else
            {
                //pictureBox2.Location = new Point(initialX, initialY);
                bullet.Visible = false;
                startFire = false;
                t = 0;
            }
        }


        private void BulletBallistics()
        {
            double newX = ForceValue * Math.Cos(AngleValue) * t * (100 - WeightValue)/100;
            double newY = ForceValue * Math.Sin(AngleValue) * (100 - WeightValue) / 100 * t - g * Math.Pow(t, 2) / 2;
            if (initialBulletY - (int)newY >= 560)
            {
                t = Timer;
            }
            else
            {
                if (IsFirstBallistaShooting == true)
                {
                    bullet.Location = new Point((initialBulletX + (int)newX), (initialBulletY - (int)newY));
                }
                else
                {
                    bullet.Location = new Point((initialBulletX - (int)newX), (initialBulletY - (int)newY));
                }
            }
        }

        private void CollisionCheck()
        {

            if (IsFirstBallistaShooting == true)
            {
                if(landingX >= Ballista2.Location.X && landingX <= Ballista2.Location.X + Ballista2.Size.Width)
                {
                    BallistaBreak = true;
                    ShowWin();
                }
            }
            else
            {
                if (landingX >= Ballista1.Location.X && landingX <= Ballista1.Location.X + Ballista1.Size.Width)
                {
                    BallistaBreak = true;
                    ShowLose();
                }
            }

            if (numberOfAvailableShots <= 0)
            {
                ShowLose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBoxCheck(Angle.Text, 25))
            {
                Angle.BackColor = Color.White;
            }
            else
            {
                Angle.BackColor = Color.Salmon;
                readyToFire = false;
            }
            if (TextBoxCheck(Force.Text, -50))
            {
                Force.BackColor = Color.White;
            }
            else
            {
                Force.BackColor = Color.Salmon;
                readyToFire = false;
            }
            if (TextBoxCheck(Weight.Text, 50))
            {
                Weight.BackColor = Color.White;
            }
            else
            {
                Weight.BackColor = Color.Salmon;
                readyToFire = false;
            }

            if (readyToFire == true)
            {
                AngleValue = double.Parse(Angle.Text) * Math.PI/180;
                ForceValue = double.Parse(Force.Text);
                WeightValue = double.Parse(Weight.Text);
                Timer = (2 * ForceValue * Math.Sin(AngleValue) / g) + 1;

                isPressedButton = true;
                NotReadyToFire();
                numberOfAvailableShots--;
                Shots.Text = numberOfAvailableShots + "/5";

            }
            else
            {
                readyToFire = true;
            }
        }

        private bool TextBoxCheck(string text, int coefficient)
        {
            int summ = 0;
            if (text == "")
            {
                return false;
            }
            else
            {
                summ = int.Parse(text);
            }

            if (summ <= 0 || summ + coefficient > 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Angle_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                    e.Handled = true;
            }
        }

        private void Force_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }

        private void Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }

        private void NotReadyToFire()
        {
            Angle.Enabled = false;
            Force.Enabled = false;
            Weight.Enabled = false;
            button1.Enabled = false;
        }

        private void ReadyToFire()
        {
            Angle.Enabled = true;
            Force.Enabled = true;
            Weight.Enabled = true;
            button1.Enabled = true;
        }

        private void CleanInput()
        {
            Angle.Text = "";
            Force.Text = "";
            Weight.Text = "";
        }

        private void ShowLose()
        {
            NotReadyToFire();
            STOPGAME = true;
            LozeOrWin.Text = "Ви програли";
            LozeOrWin.Visible = true;
            Restart.Visible = true;
        }

        private void ShowWin()
        {
            CleanInput();
            NotReadyToFire();
            STOPGAME = true;
            LozeOrWin.Text = "Ви виграли!";
            LozeOrWin.Visible = true;
            Restart.Visible = true;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            CleanInput();
            LozeOrWin.Visible = false;
            Restart.Visible = false;
            STOPGAME = false;
            ReadyToFire();
            numberOfAvailableShots = 5;
            Shots.Text = numberOfAvailableShots + "/5";
            EnemyMove = false;
            IsFirstBallistaShooting = true;
            expAnim = false;
            BallistaSpawn();
            EnemyBallistaSpawn();
        }


    }
}