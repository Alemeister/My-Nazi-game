using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Spel_Med_Sikte
{
    class SS_Enemies
    {
        protected Point position = new Point(0, 0);
        protected Image ss_enemy_Image;
        protected PictureBox pbx_enemy = new PictureBox();
        protected int animation_direction = 2;
        protected bool isHit = false;

        public PictureBox Pbx_enemy { get; set; }

        public int Animation_direction
        {
            get { return animation_direction; }
            set { animation_direction = value; }
        }

        public virtual Image SS_enemy_Image
        {
            get { return ss_enemy_Image; }
            set { ss_enemy_Image = value; }
        }

        public virtual void LoadImages()
        { }

        public virtual bool IsHit
        {
            get { return isHit; }
            set { isHit = value; }
        }        
    }

    class SS_Dog : SS_Enemies
    {
        private string filePath = @"C:\Users\Alemeister\source\repos\Spel_Med_Sikte\Animated_Dog_Wolfenstein_3D.gif";

        public SS_Dog()
        {
            LoadImages();
        }

        public override void LoadImages()
        {
            ss_enemy_Image = Image.FromFile(filePath);
        }

        public override Image SS_enemy_Image
        {
            get { return ss_enemy_Image; }
            set { ss_enemy_Image = value; }
        }
    }

    class SS_Guard : SS_Enemies
    {
        private string filePath = @"C:\Users\Alemeister\source\repos\Spel_Med_Sikte\Animated_Guard_Wolfenstein_3D.gif";
        private Image dead_ss_guard;
        private string filePath_dead_ss_guard = @"C:\Users\Alemeister\source\repos\Spel_Med_Sikte\Dead_Guard_Wolfenstein_3D.png";
        private int death_time_counter = 6;

        public SS_Guard()
        {
            LoadImages();
        }

        public Image Dead_ss_guard
        {
            get { return dead_ss_guard; }
            set { dead_ss_guard = value; }
        }

        public int Death_time_counter
        {
            get { return death_time_counter; }
            set { death_time_counter = value; }
        }

        public override void LoadImages()
        {
            ss_enemy_Image = Image.FromFile(filePath);
            dead_ss_guard = Image.FromFile(filePath_dead_ss_guard);
        }

        public override Image SS_enemy_Image
        {
            get { return ss_enemy_Image; }
            set { ss_enemy_Image = value; }
        }
    }

    class SS_Soldier : SS_Enemies
    {
        private string filePath = @"C:\Users\Alemeister\source\repos\Spel_Med_Sikte\Animated_SS_Wolfenstein_3D.gif";

        public SS_Soldier()
        {
            LoadImages();
        }

        public override void LoadImages()
        {
            ss_enemy_Image = Image.FromFile(filePath);
        }

        public override Image SS_enemy_Image
        {
            get { return ss_enemy_Image; }
            set { ss_enemy_Image = value; }
        }
    }

    class SS_Hitler_Boss : SS_Enemies
    {
        private string filePath = @"C:\Users\Alemeister\source\repos\Spel_Med_Sikte\Adolf Hitler Wolfenstein Gif - Alive2.gif";

        public SS_Hitler_Boss()
        {
            LoadImages();
        }

        public override void LoadImages()
        {
            ss_enemy_Image = Image.FromFile(filePath);
        }

        public override Image SS_enemy_Image
        {
            get { return ss_enemy_Image; }
            set { ss_enemy_Image = value; }
        }
    }
}
