using System;
using System.Collections.Generic;
using System.Text;
using SFML.Graphics;

namespace FS.Handlers
{
    class EventHandler
    {
        //Закрытие окна
        public static void OnClose(object sender, EventArgs e)
        {
            // Close the window when OnClose event is received
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }
      
        public static void SearchEvent(object sender, SearchEventArgs e)
        {
            //Console.WriteLine(e.Message);
            Console.WriteLine(Game_Objects.Player.Instanse.xPosition + "   " + Game_Objects.Player.Instanse.yPosition);
        }
        public static void even_Moving(object sender, MovingEventArgs e)
        {
            //Console.WriteLine(e.Message);
        }

        
        
    }

    class SearchEventArgs : EventArgs
    {
        public SearchEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }


    }

    class MovingEventArgs: EventArgs
    {
        public MovingEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }

    
    }
}
