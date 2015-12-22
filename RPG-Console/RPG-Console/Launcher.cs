using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Console
{
    using Interfaces;
    using Engine;
    using UI;
    public class Launcher
    {
        static void Main()
        {
            IRender render = new ConsoleRender();
            IInputReader reader = new ConsoleInputReader();

            GameEngine engine = new GameEngine(reader, render);

            engine.Run();
        }
    }
}
