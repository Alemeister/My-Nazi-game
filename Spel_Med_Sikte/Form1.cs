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
    public partial class Form1 : Form
    {
        Sikte sikte = new Sikte(0,0);
        bool ritaSikte = false;
        bool ritaSkott = false;
        bool rita_SS_Soldat = true; 
        Point skottPosition;         

        public Form1()
        {
            InitializeComponent();            
        }

        //Ritar siktet
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (ritaSikte)
            {
                sikte.Paint(e.Graphics);
                ritaSikte = false;
            }

            if (ritaSkott)
            {
                g.DrawRectangle(new Pen(Color.Black), skottPosition.X, skottPosition.Y, 1, 1);
                ritaSkott = false;
            }

            if (rita_SS_Soldat)
            {
                g.DrawImage(Image.FromFile("Animated_SS_Wolfenstein_3D_Bild.jpg"), new Point(0, 0));
                rita_SS_Soldat = false;
            }

            Generera_Bilder(e);
        }
             
        //Siktet följer efter musen
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point musPosition = e.Location;
            sikte.X = musPosition.X;
            sikte.Y = musPosition.Y;

            ritaSikte = true; 
            Invalidate();
        }
        
        //Högerklick ger svart prick i mitten av siktet
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point musPoistion = e.Location;
            skottPosition = musPoistion;

            ritaSkott = true;
            Invalidate();
        }

        private void Generera_Bilder(PaintEventArgs e)
        {
            //Random random = new Random(); 

            //Funkar inte
            e.Graphics.DrawImage(Image.FromFile("Animated_SS_Wolfenstein_3D_Bild.jpg"), new Point(100, 100));
        }
    }
}



/*Styra siktet med WASD
private void Form1_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.W)
        sikte.Y -= 10;
    if (e.KeyCode == Keys.A)
        sikte.X -= 10;
    if (e.KeyCode == Keys.S)
        sikte.Y += 10;
    if (e.KeyCode == Keys.D)
        sikte.X += 10;
    Invalidate();
}*/