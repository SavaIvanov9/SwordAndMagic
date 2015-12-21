using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SwordAndMagic.Objects.TileLoader
{
    class LevelLoader
    {
        public static int[,] LoadLevel(int level, int version)
        {
            int[][] levelMatrix;

            using (StreamReader streamReader = new StreamReader(new FileStream("Content/Level/Map" + level +"." + version + ".txt", FileMode.Open)))
            {
                levelMatrix =
                    streamReader.ReadToEnd()
                        .Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(row => row
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray())
                        .ToArray();
            }

            return ConvertJaggedArrayTo2D(levelMatrix);
        }

        private static int[,] ConvertJaggedArrayTo2D(int[][] source)
        {
            int arraySize = source.Length;

            int[,] result = new int[arraySize, arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    result[i, j] = source[i][j];
                }
            }

            return result;
        }
    }
}
