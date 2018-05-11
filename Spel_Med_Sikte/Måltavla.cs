using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

class Måltavla
{
    private int x = 0;
    private int y = 0;
    private int radie = 0;

    //Konstruktorn
    public Måltavla(int x, int y, int r)
    {
        this.x = x;
        this.y = y;
        this.radie = r;
    }

    //Egenskap radie
    public int Radie
    {
        get
        {
            return radie;
        }
        set
        {
            if (value > 0)
                radie = value;
            else
                radie = -value;
        }
    }

    //Egenskap position
    public Point Position
    {
        get
        {
            return new Point(x, y);
        }
        set
        {
            this.x = value.X;
            this.y = value.Y;
        }
    }

    //Metod Rita
    public void Rita(Graphics g)
    {
        int r = radie;
        g.FillEllipse(Brushes.White, x - r, y - r, r * 2, r * 2);
        r = (int)(radie * 0.8);
        g.FillEllipse(Brushes.Black, x - r, y - r, r * 2, r * 2);
        r = (int)(radie * 0.6);
        g.FillEllipse(Brushes.Blue, x - r, y - r, r * 2, r * 2);
        r = (int)(radie * 0.4);
        g.FillEllipse(Brushes.Red, x - r, y - r, r * 2, r * 2);
        r = (int)(radie * 0.2);
        g.FillEllipse(Brushes.Yellow, x - r, y - r, r * 2, r * 2);
        g.DrawEllipse(Pens.Black, x - radie, y - radie, radie * 2, radie * 2);
    }

}

