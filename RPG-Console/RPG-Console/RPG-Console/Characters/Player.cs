﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Console.Characters
{
    using Interfaces;
    using Engine;
    using Items;
    public class Player : Character, IPlayer, ICharacter, IAttack, IDestroyable
    {
        private readonly List<Item> inventory;

        private ICharacter enemy;
        private ICharacter player;

        public int currentRow = 1;
        public int currentCol = 1;

        public Player(Position position, char objectSymbol, string name, PlayerClass playerclass)
            : base(position, objectSymbol, name, 0, 0)
        {
            this.Playerclass = playerclass;
            this.inventory = new List<Item>();
            this.SetPlayerStats();
            this.CurrentCol = currentCol;
            this.CurrentRow = currentRow;
        }

        public int CurrentCol { get; set; }
        public int CurrentRow { get; set; }

        public PlayerClass Playerclass { get; private set; }

        public IEnumerable<Item> Inventory
        {
            get
            {
                return this.inventory;
            }
        }

        public void Move(char[,] map)
        {
            
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (keyPressed.Key == ConsoleKey.LeftArrow)
                {
                    if ((map[currentRow, currentCol - 1] != '.') &&
                        (map[currentRow, currentCol - 1] != 'w'))
                    {
                        if (map[currentRow, currentCol - 1] == 'e')
                        {
                            DrawBattle(enemy);
                        }
                        char previousPosition = 'p';

                        map[currentRow, currentCol] = ' ';

                        map[currentRow, currentCol - 1] = previousPosition;
                        currentCol--;
                         
                        
                        
                    }

                }
                if (keyPressed.Key == ConsoleKey.RightArrow)
                {
                    if ((map[currentRow, currentCol + 1] != '.') &&
                        (map[currentRow, currentCol + 1] != 'w'))
                    {
                        if (map[currentRow, currentCol + 1] == 'e')
                        {
                            DrawBattle(enemy);
                        }
                        char previousPosition = 'p';

                        map[currentRow, currentCol] = ' ';

                        map[currentRow, currentCol + 1] = previousPosition;
                        currentCol++;

                       
                        
                    }

                }
                if (keyPressed.Key == ConsoleKey.DownArrow)
                {
                    if ((map[currentRow + 1, currentCol] != 'w') && 
                        map[currentRow + 1, currentCol] != '.')
                        
                    {
                        if (map[currentRow + 1, currentCol] == 'e')
                        {
                            DrawBattle(enemy);
                        }
                        char previousPosition = 'p';

                        map[currentRow, currentCol] = ' ';

                        map[currentRow + 1, currentCol] = previousPosition;
                        currentRow++;



                    }
                }
                if (keyPressed.Key == ConsoleKey.UpArrow)
                {
                    if ((map[currentRow - 1, currentCol] != 'w') &&
                        ((currentRow - 1) > 0))
                    {
                        if (map[currentRow - 1, currentCol] == 'e')
                        {
                            DrawBattle(enemy);
                        }
                        char previousPosition = 'p';

                        map[currentRow, currentCol] = ' ';

                        map[currentRow - 1, currentCol] = previousPosition;
                        currentRow--;
                        
                        
                    }
                    
                }
            }
        }

        //for (int r = 0; r < map.GetLength(0); r++)
        //    {
        //        for (int c = 0; c < map.GetLength(1); c++)
        //        {
        //            if (map[r, c] == 'e')
        //            {
        //                return;
        //            }
        //        }
        //    }
        public void AddItemToInventory(Item item)
        {
            this.inventory.Add(item);
        }

        //public void Heal()
        //{
        //    var beer = this.inventory.FirstOrDefault() as Beer;

        //    if (beer == null)
        //    {
        //        throw new NotEnoughBeerException("Not enough beer!!!");
        //    }

        //    this.Health += beer.HealthRestore;
        //    this.inventory.Remove(beer);
        //}

        public override string ToString()
        {
            return string.Format(
                "Player {0} ({1}): Damage ({2}), Health ({3}), Number of beers: {4}",
                this.Name,
                this.Playerclass,
                this.Damage,
                this.Health,
                this.Inventory.Count());
        }

        private void SetPlayerStats()
        {
            switch (this.Playerclass)
            {
                case PlayerClass.Mage:
                    this.Damage = 50;
                    this.Health = 100;
                    break;
                case PlayerClass.Warrior:
                    this.Damage = 20;
                    this.Health = 300;
                    break;
                case PlayerClass.Archer:
                    this.Damage = 40;
                    this.Health = 150;
                    break;
                case PlayerClass.Rogue:
                    this.Damage = 30;
                    this.Health = 200;
                    break;
                default:
                    throw new ArgumentException("Unknown player race.");
            }
        }

        public void DrawBattle(ICharacter enemy)
        {
            string input = Console.ReadLine();
            if(input == "1")
            {
                this.player.Attack(enemy);

                if (enemy.Health <= 0)
                {
                    Console.WriteLine("Enemy killed!");
                    //this.characters.Remove(enemy as GameObject);
                    return;
                }
                else if(this.player.Health > 0)
                {
                    Console.WriteLine("You did some damage!");
                }

                enemy.Attack(this.player);

                if (this.player.Health <= 0)
                {
                    Console.WriteLine("You dead!");
                }
            }
        }

        
    }
}