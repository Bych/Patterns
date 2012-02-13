using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maze
{
    class Wall : IMapSite
    {
        public Wall()
        {
        }

        public virtual void Enter()
        {
            throw new NotImplementedException();
        }
    }
}
