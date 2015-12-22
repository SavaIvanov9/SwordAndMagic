using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Console
{
    class Launcher
    {
        static void Main()
        {
            IRenderer renderer = new ConsoleRenderer();
            IInputReader reader = new ConsoleInputReader();

            SuperEngine engine = new SuperEngine(reader, renderer);

            engine.Run();
        }
    }
}
