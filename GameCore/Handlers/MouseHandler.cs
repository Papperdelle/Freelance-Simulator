using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;


namespace FS.Handlers
{
    class MouseHandler
    {
        
        static Handlers.Events events = new Handlers.Events();
        public static void MouseButtonDownHandler(object sender, MouseButtonEventArgs e)
        {
            
            if (e.Button == Mouse.Button.Left && !Render.CoreRender.EventRun)
            {
                Render.CoreRender.EventRun = true;
                Render.CoreRender.x = e.X - 50;
                Render.CoreRender.y = e.Y - 120;
                Console.WriteLine(e.X + "   " + e.Y);
                Console.WriteLine(Game_Objects.Player.Instanse.xPosition + "   " + Game_Objects.Player.Instanse.yPosition);
                //events.Move(e.X, e.Y);
            }
            
        }

 
    }
}
