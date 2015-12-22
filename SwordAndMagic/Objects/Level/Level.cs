using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SwordAndMagic.Objects.TileLoader;

namespace SwordAndMagic.Objects.Level
{
    public class Level
    {
        private readonly List<Tile> tiles = new List<Tile>();

        public Level(int level, int version)
        {
            char[,] levelMatrix = LevelLoader.LoadLevel(level, version);
            this.GenerateLevel(levelMatrix);
        }

        public IEnumerable<Tile> Tiles => this.tiles;

        private void GenerateLevel(char[,] levelMatrix)
        {
            for (int i = 0; i < levelMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < levelMatrix.GetLength(1); j++)
                {
                    char currTile = levelMatrix[i, j];
                    if (currTile > 0)
                    {
                        this.tiles.Add(
                            new CollidableTile(
                                currTile,
                                new Rectangle(
                                    i*30,
                                    j*30,
                                    30,
                                    30
                                    )));
                    }
                    else
                    {
                        this.tiles.Add(
                            new VisualTile(
                                currTile,
                                new Rectangle(
                                    i*30,
                                    j*30,
                                    30,
                                    30
                                    )));
                    }

                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Tile tile in this.Tiles)
            {
                tile.Draw(spriteBatch);
            }
        }
    }
}


