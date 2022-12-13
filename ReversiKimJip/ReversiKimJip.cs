using System.Drawing;
using System.Windows.Forms;

Form scherm = new Form();
scherm.Text = "Reversi";
scherm.BackColor = Color.LightYellow;
scherm.ClientSize = new Size(220, 220);

// een Label kan ook gebruikt worden om een Bitmap te laten zien
Label afbeelding = new Label();
scherm.Controls.Add(afbeelding);
afbeelding.Location = new Point(10, 10);
afbeelding.Size = new Size(200, 200);
afbeelding.BackColor = Color.White;


Application.Run(scherm);