using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Reversiv2_Namespace
{
    class Stenen 
    {
        public void tekenSteen(object o, PaintEventArgs pea)
        {       
            Graphics gr = pea.Graphics;
            gr.FillEllipse(Brushes.Indigo, 20, 20, 50, 50); 
        } 
    }
}
