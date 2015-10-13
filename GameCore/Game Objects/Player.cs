using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;


namespace FS.Game_Objects
{
    class Player
    {
        // Переменные показателей игрока.
        private int _level;
        private int _healthPoint;
        private int _hunger;
        private int _stamina;
        private int _lazy;
        private int _money;
        private Texture _texture;

        // Переменные инструментные.
        private double _currentFrame;
        private float _xPosition;
        private float _yPosition;

        // Переменная для использования класса одиночки.
        static readonly Player _instanse = new Player();



        // Свойства для приватных переменных.
        public static Player Instanse
        {
            get { return _instanse; }
        }

        public int level
        {
            get { return _level; }
            set { _level = value; }
        }

        public Texture texture
        {
            get { return _texture; }
            set { _texture = value; }
        }
        public int healthPoint
        {
            get { return _healthPoint; }
            set { _healthPoint = value; }
        }
        public int hunger
        {
            get { return _hunger; }
            set { _hunger = value; }
        }
        public int stamina
        {
            get { return _stamina; }
            set { _stamina = value; }
        }

        public int lazy
        {
            get { return _lazy; }
            set { _lazy = value; }
        }
        public int money
        {
            get { return _money; }
            set { _money = value; }
        }
        public double currentFrame
        {
            get { return _currentFrame; }
            set { _currentFrame = value; }
        }
        public float xPosition
        {
            get { return _xPosition; }
            set { _xPosition = value; }
        }
        public float yPosition
        {
            get { return _yPosition; }
            set { _yPosition = value; }
        }

        
        
        

    }
}
