using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using System.Timers;

namespace Spel_Med_Sikte
{
    public partial class Game_Session : Form
    {
        List<SS_Enemies> game_Enemies = new List<SS_Enemies>();
        static Random random = new Random();

        private int death_count = 0;
        private int timeCounter = 60;

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer gameAnimationTimer;

        public Game_Session()
        {
            InitializeComponent();

            //Change Mouse Cursor
            Bitmap b = new Bitmap(Spel_Med_Sikte.Properties.Resources.GunAim100x100);
            Graphics g = Graphics.FromImage(b);
            IntPtr ptr = b.GetHicon();
            Cursor = new System.Windows.Forms.Cursor(ptr);

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;


            lbl_Nazi_Death_Count.Location = new Point(1100, 10);
            lbl_Nazi_Death_Count.Text = "Dead Nazis: " + death_count;
            lbl_Nazi_Death_Count.AutoSize = true;

            Start_Game();
        }

        public void Start_Game()
        {
            //Create timer that creates enemies
            //timer_Creating_Enemies.Interval = 2000;
            //timer_Creating_Enemies.Enabled = true;
            //timer_Creating_Enemies.Start();

            //Create timer that counts down
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Tick += new EventHandler(timerCountDown_Tick);
            gameTimer.Tick += new EventHandler(timer_Creating_Enemies_Tick);
            gameTimer.Interval = 1000; // 1 second
            gameTimer.Start();

            gameAnimationTimer = new System.Windows.Forms.Timer();
            gameAnimationTimer.Tick += new EventHandler(game_AnimationTimer_Tick);
            gameAnimationTimer.Interval = 1;
            gameAnimationTimer.Start();

            lblCountDown.Text = timeCounter.ToString();
        }

        public void Create_Enemies()
        {
            SS_Enemies newEnemy = new SS_Enemies();

            //Randomize the type of Enemy
            switch (random.Next(1, 4))
            {
                case 1:
                    newEnemy = new SS_Soldier();
                    break;
                case 2:
                    newEnemy = new SS_Guard();
                    break;
                case 3:
                    newEnemy = new SS_Dog();
                    break;
            }

            PictureBox newPbx = new PictureBox();
            newPbx.Size = new Size(newEnemy.SS_enemy_Image.Width, newEnemy.SS_enemy_Image.Height);
            newPbx.Image = newEnemy.SS_enemy_Image;
            newPbx.SizeMode = PictureBoxSizeMode.Normal;
            newPbx.BackColor = Color.Transparent;
            newPbx.MouseClick += new MouseEventHandler(Shot_PictureBox_MouseClick_Event);

            switch (random.Next(1, 7))
            {
                case 1:
                    newPbx.Location = new Point(0, 60);
                    break;
                case 2:
                    newPbx.Location = new Point(0, 260);
                    break;
                case 3:
                    newPbx.Location = new Point(0, 460);
                    break;
                case 4:
                    newPbx.Location = new Point(ClientSize.Width - newPbx.Size.Width, 60);
                    break;
                case 5:
                    newPbx.Location = new Point(ClientSize.Width - newPbx.Size.Width, 260);
                    break;
                case 6:
                    newPbx.Location = new Point(ClientSize.Width - newPbx.Size.Width, 460);
                    break;
            }

            newEnemy.Pbx_enemy = newPbx;
            game_Enemies.Add(newEnemy);
            this.Controls.Add(newEnemy.Pbx_enemy);
        }

        private void timer_Creating_Enemies_Tick(object sender, EventArgs e)
        {
            Create_Enemies();
        }

        private void game_AnimationTimer_Tick(object sender, EventArgs e)
        {
            foreach (var game_enemy in game_Enemies)
            {
                if (!game_enemy.IsHit)
                {
                    if (game_enemy.Pbx_enemy.Location.X + game_enemy.Pbx_enemy.Width > this.Width || game_enemy.Pbx_enemy.Location.X < 0)
                        game_enemy.Animation_direction *= -1;

                    Point location = new Point(game_enemy.Pbx_enemy.Location.X + game_enemy.Animation_direction, game_enemy.Pbx_enemy.Location.Y);
                    game_enemy.Pbx_enemy.Location = location;
                    game_enemy.Pbx_enemy.BringToFront();
                }
            }
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            timeCounter--;
            lblCountDown.Text = timeCounter.ToString();

            if (timeCounter == 0)
            {
                gameTimer.Stop();
                gameAnimationTimer.Stop();
                MessageBox.Show("Game Over \r\n Highscore: " + death_count);
                if (death_count > 20)
                {
                    this.Close();
                    Game_Boss_Hitler new_Game_Boss_Hitler = new Game_Boss_Hitler();
                    new_Game_Boss_Hitler.Show();
                }
            }
        }

        private void dead_guard_Tick(object sender, EventArgs e)
        {
            foreach (SS_Enemies guard_enemy in game_Enemies)
            {
                if (guard_enemy is SS_Guard && guard_enemy.IsHit)
                {
                    SS_Guard dead_ss_guard = guard_enemy as SS_Guard;
                    --dead_ss_guard.Death_time_counter;

                    if (dead_ss_guard.Death_time_counter == 0)
                    {
                        this.Controls.Remove(guard_enemy.Pbx_enemy);
                        game_Enemies.Remove(guard_enemy);
                        break;
                    }
                }
            }
        }

        protected virtual void Shot_PictureBox_MouseClick_Event(object sender, MouseEventArgs e)
        {
            PictureBox dead_enemy = sender as PictureBox;

            if ((dead_enemy.Image as Bitmap).GetPixel(e.X, e.Y).A != 0)
            {
                lbl_Nazi_Death_Count.Text = "Dead Nazis: " + ++death_count;

                foreach (SS_Enemies enemies in game_Enemies)
                {
                    if (enemies.Pbx_enemy == dead_enemy && !(enemies is SS_Guard))
                    {
                        game_Enemies.Remove(enemies);
                        this.Controls.Remove(enemies.Pbx_enemy);
                        break;
                    }
                    if (enemies is SS_Guard && enemies.Pbx_enemy == dead_enemy)
                    {
                        enemies.Pbx_enemy.Image = (enemies as SS_Guard).Dead_ss_guard;
                        enemies.Pbx_enemy.SizeMode = PictureBoxSizeMode.Zoom;
                        enemies.Pbx_enemy.SendToBack();
                        enemies.IsHit = true;

                        gameTimer.Tick += new EventHandler(dead_guard_Tick);
                        break;
                    }
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Timer på 1 till 3 minuter - Sedan boss - Hitler
        //Inga andra fiender, bara hitler, timer stoppas? Rör sig hitler?

        //Beroende på vilken random en fiende får --> lägg in det som en int i klassen/objektet
        //Jämför var följande fiende så att de inte får samma random --> fiender börjar på olika rader
        //Fiender går ut ur skärmen --> minus poäng 


        //Timer - visa hur mycket tid kvar
        //Större counter

        //RÖD ETTA När nazisterna skjuter/ hunden biter
        //Antal liv

        //"Levels" - olika antal liv - eller antal fiender
        //BOSS: Hitler: Skjuta röda prickar på Hitler - ta bort kroppsdelar

        //Gå ut ur bild efter ett visst antal gånger
        //eller max antal på fiender - counter på antal 

        //drawImage - funkar med gifs
        //För att göra bilderna med transparens

        //Olika delar av kroppen/pbx --> olika poäng: huvud mycket 
        //Välja tid på startscreen
    }
}
