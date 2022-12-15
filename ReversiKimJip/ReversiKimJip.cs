using System;
using System.Drawing;
using System.Windows.Forms;

Form scherm = new Form();
scherm.Text = "Reversi";
scherm.BackColor = Color.Lavender;
scherm.ClientSize = new Size(1600, 800);

// Voor de blauwe steen: Color.Indigo
// Voor de rode steen: Color.Maroon

Label afbeelding = new Label();
scherm.Controls.Add(afbeelding);
afbeelding.Location = new Point(600, 200);
afbeelding.Size = new Size(400, 400);
afbeelding.BackColor = Color.White;

Button knop = new Button();
scherm.Controls.Add(knop);
knop.Location = new Point(20, 20);
knop.Size = new Size(20, 20);
knop.Text = "6 x 6";

Bitmap plaatje = new Bitmap(300, 300);
afbeelding.Image = plaatje;


// subclass of Form to create the checkerboard field
class Checkerboard : Form
{
    private int Midden_x = 800;
    private int Midden_y = 400;
    private int n = 6;
    Graphics gr = Graphics.FromImage(plaatje);


    void DrawVierkant(object o, PaintEventArgs pea)
    {
        for (int i = 0; i < n; i++)
        {
            int Begin_x = Midden_x - ((n / 2) * 50);
            int Begin_y = Midden_y - ((n / 2) * 50);
            gr.DrawRectangle(Pens.Black, Begin_x + (i * 50), Begin_y, 50, 50);
        }
        afbeelding.Invalidate();
    }
}


// HET EINDE
Application.Run(scherm);