using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FS.Handlers
{
    class Events
    {
        
        public void Move(int currentPositionX, int currentPositionY, float time)
        {
            if ((int)Game_Objects.Player.Instanse.xPosition != currentPositionX)
            {
                if (Game_Objects.Player.Instanse.xPosition < currentPositionX)
                {
                    Game_Objects.Player.Instanse.xPosition += 0.1f * time;
                }
                else
                {
                    Game_Objects.Player.Instanse.xPosition -= 0.1f * time;
                }
            }
            if ((int)Game_Objects.Player.Instanse.yPosition != currentPositionY)
            {
                if (Game_Objects.Player.Instanse.yPosition < currentPositionY)
                {
                    Game_Objects.Player.Instanse.yPosition += 0.1f * time;
                }
                else
                {
                    Game_Objects.Player.Instanse.yPosition -= 0.1f * time;
                }
            }

            Game_Objects.Player.Instanse.currentFrame += 0.005 * time;
            if (Game_Objects.Player.Instanse.currentFrame > 4)
                Game_Objects.Player.Instanse.currentFrame -= 4;

            if (Moving != null)
                Moving(this, new MovingEventArgs("Работает!"));
           


        }

        public event EventHandler<MovingEventArgs> Moving;


        public void SearchEvent(int x, int y, float time)
        {
            if ((x != (int)Game_Objects.Player.Instanse.xPosition) || (y != (int)Game_Objects.Player.Instanse.yPosition))
            {
                Move(x, y, time);
            }
            else
            {
                Render.CoreRender.EventRun = false;
            }

            if (SearchingEvent != null)
                SearchingEvent(this, new SearchEventArgs("Иду!"));
            
        }
        public event EventHandler<SearchEventArgs> SearchingEvent;
    }
}
