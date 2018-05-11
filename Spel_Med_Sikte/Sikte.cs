using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

class Sikte
{
    int x = 0;
    int y = 0;
    //Anpassa radie efter storlek av fönster
    int radie = 50; 

    //Konstruktor
    public Sikte(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    //Egenskap X
    public int X
    {
        get { return x; }
        set { x = value; }
    }

    //Egenskap Y
    public int Y
    {
        get { return y; }
        set { y = value; }
    }

    public void Paint(Graphics g)
    {
        Pen pen = new Pen(Color.Green);
        Pen penCirkel = new Pen(Color.Green, 4);
        //Cirkeln
        g.DrawEllipse(penCirkel, x - radie, y - radie, radie*2, radie*2);
        
        //Samma y värde - Vertikal
        g.DrawLine(pen, x, y - radie, x, y + radie);
        
        //Samma x värde - Horisontel 
        g.DrawLine(pen, x - radie, y, x + radie, y); 
    }
}

