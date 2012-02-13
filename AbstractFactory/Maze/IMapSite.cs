using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maze
{
    public interface IMapSite
    {
        void Enter();
    }

    public enum Direction
    {
        North,
        South,
        East,
        West,
    }
}
