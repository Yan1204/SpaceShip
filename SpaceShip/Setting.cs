using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    class Setting
    {
        private static Setting instance = null;
        private bool newGame;
        private bool gameOver;
        private int heightFill;
        private int widthFill;
        private int heightMenu;
        private int widthMenu;
        private int positionMenuI;
        private int positionMenuJ;

        public static Setting getInstance()
        {
            if (instance == null)
            {
                instance = new Setting();
            }

            return instance;
        }

        private Setting()
        {
            newGame = false;
            gameOver = true;
            heightFill = 30;
            widthFill = 90;
            heightMenu = 15;
            widthMenu = 38;
            positionMenuI = 25;
            positionMenuJ = 30;
        }

        public int PositionMenuI
        {
            get
            {
                return positionMenuI;
            }
        }

        public int PositionMenuJ
        {
            get
            {
                return positionMenuJ;
            }
        }

        public bool NewGame
        {
            get
            {
                return newGame;
            }
            set
            {
                newGame = value;
            }
        }

        public bool GameOver
        {
            get
            {
                return gameOver;
            }
            set
            {
                gameOver = value;
            }
        }

        public int HeightFill
        {
            get
            {
                return heightFill;
            }
        }

        public int WidthFill
        {
            get
            {
                return widthFill;
            }
        }

        public int HeightMenu
        {
            get
            {
                return heightMenu;
            }
        }

        public int WidthMenu
        {
            get
            {
                return widthMenu;
            }
        }
    }
}
