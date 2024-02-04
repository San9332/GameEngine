using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class Game : GameEngine.GameEngine
    {
        public Game() : base(new GameEngine.Vector2(615, 515), "Game Engine Demo")
        { }
    }
}
