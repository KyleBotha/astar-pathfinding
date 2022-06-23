using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Astar_Demo
{
    public class Game
    {

        public Game()
        {
           var inputObj = ReadFile("1.txt");
           RunSimulation sim = new RunSimulation(inputObj);
           
        }
        
        public GridInputs ReadFile(string textfilename)
        {
            GridInputs inputs = new GridInputs();
            string path = Directory.GetCurrentDirectory() + @"../../../";

            var filename = Path.GetFullPath(Path.Combine(path, textfilename));
            var lines = File.ReadLines(filename).ToArray();
            for (int i = 0; i < lines.Count(); i++)
            {
                if (lines[i].Contains("Step_allowance"))
                {
                    inputs.StepAllowance = Int32.Parse(lines[i].Split('=')[1]);
                }

                if (lines[i].Contains("Coal"))
                {
                    inputs.coalAmount = Int32.Parse(lines[i].Split(',')[1]);

                    int couter = 0;
                    for (int j = 0; j < inputs.coalAmount; j++)
                    {
                        string line = lines[i + 1 + j];
                        string[] char_coords = line.Split(',');


                        inputs.coalCoords.Add(new Coords
                        {
                            x = Int32.Parse(char_coords[0]),
                            y = Int32.Parse(char_coords[1]),
                        });
                    }

                }

                if (lines[i].Contains("Fish"))
                {
                    inputs.fishAmount = Int32.Parse(lines[i].Split(',')[1]);

                    int couter = 0;
                    for (int j = 0; j < inputs.fishAmount; j++)
                    {
                        string line = lines[i + 1 + j];
                        string[] char_coords = line.Split(',');


                        inputs.fishCoords.Add(new Coords
                        {
                            x = Int32.Parse(char_coords[0]),
                            y = Int32.Parse(char_coords[1]),
                        });
                    }
                }

                if (lines[i].Contains("Scrap_metal"))
                {
                    inputs.scrapMetalAmount = Int32.Parse(lines[i].Split(',')[1]);
                    int couter = 0;
                    for (int j = 0; j < inputs.scrapMetalAmount; j++)
                    {
                        string line = lines[i + 1 + j];
                        string[] char_coords = line.Split(',');


                        inputs.scrapMetalCoords.Add(new Coords
                        {
                            x = Int32.Parse(char_coords[0]),
                            y = Int32.Parse(char_coords[1]),
                        });
                    }
                }

                if (lines[i].Contains("map_size"))
                {
                    string mapsizing = lines[i].Split('=')[1];
                    string[] mapsizecoords = mapsizing.Split(',');
                    inputs.mapSizex = Int32.Parse(mapsizecoords[0]);
                    inputs.mapSizey = Int32.Parse(mapsizecoords[1]);
                    int couter = 0;
                    StringBuilder sb = new StringBuilder();
                    string allCoords = "";
                    for (int j = 0; j < inputs.mapSizex; j++)
                    {
                        string line = lines[i + 1 + j];

                        sb.Append(line + '\n');
                        inputs.allMapCoords = sb.ToString();
                    }
                }
            }

            return inputs; 
        }
    }
}
