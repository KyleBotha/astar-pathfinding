using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astar_Demo
{
    public static class State
    {
        public static bool startNodeState { get; set; }
        public static bool endNodeState { get; set; }
        static State()
        {
            startNodeState =  false;
            endNodeState = false;
        }
    }
}
