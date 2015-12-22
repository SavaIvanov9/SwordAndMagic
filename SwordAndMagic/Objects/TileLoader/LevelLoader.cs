using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SwordAndMagic.Objects.TileLoader
{
    class LevelLoader
    {
        public static char[,] LoadLevel(int level, int version)
        {
            char[,] levelMatrix;

            Map.Map map = new Map.Map();

            //using (StreamReader streamReader = new StreamReader(new FileStream("Map1.1.txt", FileMode.Open)))
            //{
                
            //}
            levelMatrix = map.ReadMap("Map1.1.txt");

            return ConvertJaggedArrayTo2D(levelMatrix);
        }

        private static char[,] ConvertJaggedArrayTo2D(char[,] source)
        {

            char[,] result = source;

            return result;
        }
    }
}
