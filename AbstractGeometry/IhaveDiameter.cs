using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    internal interface IhaveDiameter
    {
        double GetDiameter();
        void DrawDiameter(System.Windows.Forms.PaintEventArgs e);
    }
}
