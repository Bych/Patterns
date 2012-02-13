using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maze
{
    class Room : IMapSite
    {
        private IMapSite[] _sides = new IMapSite[4];
        private int _roomNumber;

        public Room(int roomNumber)
        {
        }

        public IMapSite GetSide(Direction direction)
        {
        }

        public void SetSide(Direction direction, IMapSite mapSite)
        {
        }

        public virtual void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
