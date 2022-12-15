using System;
using System.Drawing;
using System.Windows.Forms;

Application.Run(new Speelbord());


class Stenen
{
    public void tekenSteen(object o, PaintEventArgs pea)
    {
        Graphics gr = pea.Graphics;
        gr.FillEllipse(Brushes.Indigo, 20, 20, 50, 50);
    }
}
class Speelbord : Form
{
    public int Midden_x = 200;
    public int Midden_y = 200;
    public int n = 6;
    public Speelbord()
    {
        this.Size = new Size(500,500);
        this.BackColor = Color.White;
        this.Paint += this.tekenSpeelbord;
        this.Paint += this.tekenSteenB;
        this.Paint += this.tekenSteenR;
    }

private void tekenSpeelbord(object o, PaintEventArgs pea)
    {  
    Graphics gr = pea.Graphics;
        for (int i = 0; i < n; i++)
        {
            int Begin_x = Midden_x - ((n / 2) * 50);
            for (int j = 0; j < n; j++)
            {
                int Begin_y = Midden_y - ((n / 2) * 50);
                gr.DrawRectangle(Pens.Black, Begin_x + (i * 50), Begin_y + (j * 50), 50, 50);
            }
        }
    }

    public void tekenSteenB(object o, PaintEventArgs pea)
    {
        Graphics gr = pea.Graphics;
        gr.FillEllipse(Brushes.Blue, 20, 20, 50, 50);
    }

    public void tekenSteenR(object o, PaintEventArgs pea)
    {
        Graphics gr = pea.Graphics;
        gr.FillEllipse(Brushes.Red, 40, 20, 50, 50);
    }
}

