using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;


namespace FS.Core
{
    class LoadFiles
    {
        static public void LoadPlayerTexture()
        {
            Game_Objects.Player.Instanse.texture = new Texture(@"Textures\Player\1.png");
        }
        static public void FirstStart()
        {
            Game_Objects.Player.Instanse.healthPoint = 100;
            Game_Objects.Player.Instanse.hunger = 100;
            Game_Objects.Player.Instanse.lazy= 100;
            Game_Objects.Player.Instanse.level = 100;
            Game_Objects.Player.Instanse.money = 100;
            Game_Objects.Player.Instanse.healthPoint = 100;
            Game_Objects.Player.Instanse.currentFrame = 0;
            Game_Objects.Player.Instanse.xPosition = 10;
            Game_Objects.Player.Instanse.yPosition = 10;
        }
    }
}
