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
    public partial class Show_Gif_Form : Form
    {
        PictureBox pictureBoxNazi = new PictureBox();

        public Show_Gif_Form()
        {
            InitializeComponent();

            this.Size = new Size(800, 800);

            pictureBoxNazi.Size = new Size(200, 200);
            //pictureBoxNazi.Location = new System.Drawing.Point(0, 0);

            this.Controls.Add(pictureBoxNazi);

            Show_Gif();
        }

        public void Show_Gif()
        {
            Image soldier = Image.FromFile(@"C:\Users\Alemeister\source\repos\Spel_Med_Sikte\Animated_SS_Wolfenstein_3D.gif");

            pictureBoxNazi.Image = soldier;

            /*pictureBoxNazi.Location = new System.Drawing.Point(0, 0);
            string filePath = @"C:\Users\Alemeister\source\repos\Spel_Med_Sikte\Dead_Guard_Wolfenstein_3D.png";
            Image ss_Soldier_Image = Image.FromFile(filePath);

            pictureBoxNazi.Image = ss_Soldier_Image;*/
        }
    }
}
