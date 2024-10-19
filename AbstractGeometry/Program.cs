using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AbstractGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd = FindWindow(null,"Microsoft Visual Studio - InheritanceCS");
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                (
                Console.WindowLeft, Console.WindowTop,
                Console.WindowWidth, Console.WindowHeight
                );
            PaintEventArgs e = new PaintEventArgs(graphics,window_rect);
           
            Rectangle rectangle = new Rectangle(100, 50, 100, 100, 3, System.Drawing.Color.Red);
            rectangle.Info(e);
        }
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string className, string windowName);
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        
    }
}
