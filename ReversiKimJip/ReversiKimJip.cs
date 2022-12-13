using System.Drawing;
using System.Windows.Forms;

Form scherm = new Form();
scherm.Text = "Reversi";
scherm.BackColor = Color.Lavender;
scherm.ClientSize = new Size(1600, 800);

// Voor de blauwe steen: Color.Indigo
// Voor de rode steen: Color.Maroon

// een Label kan ook gebruikt worden om een Bitmap te laten zien
Label afbeelding = new Label();
scherm.Controls.Add(afbeelding);
afbeelding.Location = new Point(600, 200);
afbeelding.Size = new Size(400, 400);
afbeelding.BackColor = Color.White;

Bitmap plaatje = new Bitmap(300, 300);
afbeelding.Image = plaatje;

Graphics gr = Graphics.FromImage(plaatje);

int Midden_x = 800;
int Midden_y = 400;
int n = 6;

int Begin_x = Midden_x - ((n / 2) * 50);
int Begin_y = Midden_y - ((n / 2) * 50);

// for (int i = 0; i < n; i++)

gr.DrawRectangle(Pens.Black, Begin_x, Begin_y, 50, 50); // standaard grootte voor 1 vierkantje











// HET EINDE
Application.Run(scherm);