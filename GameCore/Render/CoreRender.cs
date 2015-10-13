using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using SFML.Window;
using SFML.Graphics;


namespace FS.Render
{
    class CoreRender
    {
      
        public static bool EventRun = false;
        public static int x = 0;
        public static int y = 0;

        public static void StartRender()
        {
            Handlers.Events events = new Handlers.Events();
            
            DateTime time1;
            DateTime time2;
            float time3;
            double time4;

            RenderWindow window = new RenderWindow(new VideoMode(640, 480 ),"Game");
            
            window.Closed += new EventHandler(Handlers.EventHandler.OnClose);
            events.Moving += new EventHandler<Handlers.MovingEventArgs>(Handlers.EventHandler.even_Moving);
            events.SearchingEvent += new EventHandler<Handlers.SearchEventArgs>(Handlers.EventHandler.SearchEvent);
            window.MouseButtonPressed += new EventHandler<MouseButtonEventArgs>(Handlers.MouseHandler.MouseButtonDownHandler);
            
            Sprite Player = new Sprite();
            Player.Texture = Game_Objects.Player.Instanse.texture;
            Player.TextureRect = new IntRect(0, 0, 150, 150);
            Player.Position = new Vector2f(Game_Objects.Player.Instanse.xPosition, Game_Objects.Player.Instanse.yPosition);
            time1 = DateTime.Now;
            while(window.IsOpen())
            {
                time2 = DateTime.Now;
                time4 = (time2.Ticks - time1.Ticks)*1E-2;
                time3 = (float)time4;
                time1 = DateTime.Now;
                time3 = time3/200;
                window.DispatchEvents();

                if (EventRun)
                { 
                    events.SearchEvent(x,y,time3);
                }
               
                Player.Position = new Vector2f(Game_Objects.Player.Instanse.xPosition, Game_Objects.Player.Instanse.yPosition);
                Player.TextureRect = new IntRect(130*(int)Game_Objects.Player.Instanse.currentFrame+100,0,-100,150);
                window.Clear();
                window.Draw(Player);
                window.Display();
                
            } 
        }

       
    }
}
