using System;
using System.Collections.Generic;
using System.Text;


namespace FS.Game_Objects
{
    class Room
    {

        private RoomObjects _table;

        static readonly Room _instanse = new Room();

        public static Room Instanse
        {
            get { return _instanse; }
        }

        public RoomObjects Table
        {
            get { return _table; }
        }
        
        

    }
}
