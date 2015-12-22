using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwordAndMagic.Map
{
    public class MapLoader : Map
    {
        static Map mapObj = new Map();

        char[,] map = mapObj.ReadMap("map1.1.txt");

    }
}
