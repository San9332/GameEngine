using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameEngine
{
    class Game : GameEngine.GameEngine
    {
        public Game() : base(new GameEngine.Vector2(615, 515), "Game Engine Demo")
        { }

        public override void OnDraw()
        {
          
        }

        public override void OnLoad()
        {
            BackgroundColor = Color.AliceBlue;
        }

        int frame = 0;
        public override void OnUpdate()
        {
            Console.WriteLine($"Frame {frame}");
            frame++;
        }
    }
}
