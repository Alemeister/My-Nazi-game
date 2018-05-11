using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spel_Med_Sikte
{
    public partial class Game_Boss_Hitler : Form
    {
        int damage = 0;
        Label damage_label = new Label();

        public Game_Boss_Hitler()
        {
            InitializeComponent();

            //Change Mouse Cursor
            Bitmap b = new Bitmap(Spel_Med_Sikte.Properties.Resources.GunAim100x100);
            Graphics g = Graphics.FromImage(b);
            IntPtr ptr = b.GetHicon();
            Cursor = new System.Windows.Forms.Cursor(ptr);

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            damage_label.Text = "Damage: ";
            damage_label.Location = new Point(0, 0);
            this.Controls.Add(damage_label);

            Start_Game_Boss();
        }

        SS_Hitler_Boss hitler_Boss = new SS_Hitler_Boss();
        public void Start_Game_Boss()
        {
            PictureBox newPbx = new PictureBox();
            newPbx.Size = new Size(400, 400);
            newPbx.SizeMode = PictureBoxSizeMode.StretchImage;
            newPbx.Image =  hitler_Boss.SS_enemy_Image;
            newPbx.BackColor = Color.Transparent;
            newPbx.MouseClick += new MouseEventHandler(Shot_PictureBox_MouseClick_Event);

            newPbx.Location = new Point(60, 60);

            hitler_Boss.Pbx_enemy = newPbx;
            this.Controls.Add(hitler_Boss.Pbx_enemy);
        }


        protected virtual void Shot_PictureBox_MouseClick_Event(object sender, MouseEventArgs e)
        {
            PictureBox dead_enemy = sender as PictureBox;

            int x = (int)Math.Round(((double)e.X / dead_enemy.Width) * (dead_enemy.Image as Bitmap).Width);
            int y = (int)Math.Round(((double)e.Y / dead_enemy.Height) * (dead_enemy.Image as Bitmap).Height);


            if ((dead_enemy.Image as Bitmap).GetPixel(x, y).A != 0)
            {
                damage_label.Text = "Damage: " + ++damage;
                
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Fem liv - förlorar liv i början av skjuta-animation
        //Fem hjärtan längst upp
        //Ett liv per skjutnings-animations-omgång
        //Randomize position - sex rutor (3*2) - teleporterar efter skjutning-animation
        //100-health bar högst upp för Hitler - healthbar utan eller med siffror? Snyggare utan? blå bar som minskar
        //kanske 75/80 - svårighetsgrader?
        //Ett skott = 1 damage


    }
}
