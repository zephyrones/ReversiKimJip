using System;
using System.Drawing;
using System.Windows.Forms;

Application.Run(new Speelbord());
class Speelbord : Form
{
    private int Midden_x = 200;
    private int Midden_y = 200;
    private int n = 6;
    public Speelbord()
    {
        this.Size = new Size(500,500);
        this.BackColor = Color.White;
        this.Paint += this.tekenSpeelbord;
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
}