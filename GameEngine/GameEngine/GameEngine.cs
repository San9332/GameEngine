using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
namespace GameEngine.GameEngine
{
    class Window : Form
    {
        public Window()
        {
            this.DoubleBuffered = true;
        }
    }
    public abstract class GameEngine
    {
        private Vector2 ScreenSize = new Vector2(512, 512);
        private String Title;
        private Window Canvas = null;

        public GameEngine(Vector2 ScreenSize, String Title)
        {
            this.ScreenSize = ScreenSize;
            this.Title = Title;

            Canvas = new Window();
            Canvas.Size = new Size((int)this.ScreenSize.X, (int)this.ScreenSize.Y);
            Canvas.Text = Title;

            Application.Run(Canvas);
        }

        
    }
}
