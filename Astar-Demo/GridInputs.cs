using System.Collections.Generic;

namespace Astar_Demo
{
    public class GridInputs
    {
        public int StepAllowance { get; set; }
        public int coalAmount { get; set; }
        public List<Coords> coalCoords { get; set; } = new List<Coords>();
        public int fishAmount { get; set; }
        public List<Coords> fishCoords { get; set; } = new List<Coords>();
        public int scrapMetalAmount { get; set; }
        public List<Coords> scrapMetalCoords { get; set; } = new List<Coords>();
        public int quota { get; set; }
        public double quotaMultiplier { get; set; }
        public int mapSizex { get; set; }
        public int mapSizey { get; set; }
        
        public string allMapCoords { get; set; }
        
        
    }
}
