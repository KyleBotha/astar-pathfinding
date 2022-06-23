using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astar_Demo
{
    public partial class frmSettings : Form
    {
        public int DEFAULT_FORM_WIDTH = 800;
        public int DEFAULT_FORM_HEIGHT = 800;
        public int DEFAULT_NUM_COLS = 50; 
        public int DEFAULT_NUM_ROWS = 50;
        public FileReader fileReader = new FileReader(); 
        GridInputs inputs = new GridInputs();
        public frmSettings()
        {
            InitializeComponent();
            txtWindowHeight.Text = DEFAULT_FORM_HEIGHT.ToString();
            txtWindowWidth.Text = DEFAULT_FORM_WIDTH.ToString();
            txtNumOfCols.Text = DEFAULT_NUM_COLS.ToString(); 
            txtNumOfRows.Text = DEFAULT_NUM_ROWS.ToString();
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void frmSettings_Load(object sender, EventArgs e)
        {
            
            AllocConsole();
            
            
          
         

        }

        public void parseFile()
        {
            
            string path = Directory.GetCurrentDirectory() + @"../../../";

            var filename = Path.GetFullPath(Path.Combine(path, @"1.txt"));
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
                    string mapsizing =  lines[i].Split('=')[1];
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
        }

        public void printProps()
        {
            Console.WriteLine(inputs.allMapCoords);
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            parseFile(); 
            printProps(); 
            // frmWindow Window = new frmWindow();
            // Window.Size = new Size(Convert.ToInt32(txtWindowWidth.Text), Convert.ToInt32(txtWindowHeight.Text));
            // Window.NumOfCols = Convert.ToInt32(txtNumOfCols.Text); 
            // Window.NumOfRows = Convert.ToInt32(txtNumOfRows.Text);
            //
            // Window.Show();
        }
    }
}
