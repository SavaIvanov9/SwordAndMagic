using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwordAndMagic.Objects.Level;

namespace SwordAndMagic.Managers
{
    class LevelManager
    {
        private Level level;
        private int currentLevelNumber;

        public LevelManager()
        {
            this.currentLevelNumber = 1;
            this.CreateLevel();

        }

        private void CreateLevel()
        {
            this.CurrentLevel = new Level(this.currentLevelNumber, 1);
        }

        public void NextLevel()
        {
            this.currentLevelNumber++;
            this.CreateLevel();
        }

        public Level CurrentLevel
        {
            get { return this.level; }
            set { this.level = value; }
        }
    }
}
