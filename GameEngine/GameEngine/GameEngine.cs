using System;
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
        private Thread GameLoopThread = null;

        public Color BackgroundColor = Color.Beige;



        public GameEngine(Vector2 ScreenSize, String Title)
        {
            this.ScreenSize = ScreenSize;
            this.Title = Title;

            Canvas = new Window();
            Canvas.Size = new Size((int)this.ScreenSize.X, (int)this.ScreenSize.Y);
            Canvas.Text = Title;
            Canvas.Paint += Renderer;
            

            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();

            Application.Run(Canvas);
        }

        void GameLoop()
        {
            OnLoad();
            while (GameLoopThread.IsAlive)
            {
                try
                {
                    OnDraw();
                    Canvas.BeginInvoke((MethodInvoker)delegate { Canvas.Refresh(); });
                    OnUpdate();
                    Thread.Sleep(1);
                }
                catch
                {
                    Console.WriteLine("Loading...");
                }
            }
        }
       

        public void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(BackgroundColor);
        }

        public abstract void OnLoad();
        public abstract void OnUpdate();

        public abstract void OnDraw();

    }
}
