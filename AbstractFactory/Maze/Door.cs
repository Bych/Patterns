using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maze
{
    internal class Door : IMapSite
    {
        private Room _curRoom;
        private Room _nextRoom;
        private bool _isOpen;

        public Door(Room curRoom, Room nextRoom)
        {
        }

        public void  Enter()
        {
 	        throw new NotImplementedException();
        }
    }
}
