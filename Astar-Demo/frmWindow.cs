using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace Astar_Demo
{
    public partial class frmWindow : Form
    {
        public int NumOfRows;
        public int NumOfCols;
        public Grid nodeGrid; 

        public frmWindow()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void frmWindow_Load(object sender, EventArgs e)
        {
            nodeGrid = new Grid(this.Height, this.Width, this.NumOfRows, this.NumOfCols);
            int titleBarHeight = SystemInformation.CaptionHeight;
            this.Height = this.Height + titleBarHeight;
            this.Width = this.Width + 150;

            nodeGrid.make_grid();
            
            for (int i = 0; i < this.NumOfCols; i++)
            {
                for (int j = 0; j < this.NumOfRows; j++)
                {
                    Controls.Add(nodeGrid.grid[i, j]);
                }
            }
        }
     
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void button1_Click_1(object sender, EventArgs e)
        {
            AllocConsole();
            for (int i = 0; i < NumOfRows; i++)
            {
                for (int j = 0; j < NumOfCols; j++)
                {
                    if (nodeGrid.grid[i, j] != null)
                    {
                        string neighbors = ""; 
                        nodeGrid.grid[i,j].neighbors.ForEach(x =>  neighbors = neighbors + x.get_pos_grid().ToString());
                        Console.WriteLine("{Node ID: " + nodeGrid.grid[i, j].id + " } Position in grid : " + nodeGrid.grid[i, j].get_pos_grid().ToString() + " } Position in pixels : " + nodeGrid.grid[i, j].get_pos_pixel().ToString() + "{ Node Type: " + nodeGrid.grid[i,j].type + " }" + "{F Score : " + nodeGrid.grid[i,j].f + "}" + "{Neighbors: " + neighbors +  " }" );
                    } 
                }
            }
        }

        private void btnUpdateNeighbors_Click(object sender, EventArgs e)
        {
            nodeGrid.update_neighbors(); 
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            nodeGrid.astar();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nodeGrid.reset_grid(); 
        }
    }
}
