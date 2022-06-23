﻿using System;
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
            GridInputs inputs = new GridInputs(); 
            AllocConsole();
            
            string path = Directory.GetCurrentDirectory() + @"../../../";

            var case1 = Path.GetFullPath(Path.Combine(path, @"1.txt"));
            string filecontents = fileReader.ReadFile(case1);
            Console.WriteLine(filecontents);
            string firstline = filecontents.Substring(0, filecontents.IndexOf(Environment.NewLine));
            Console.WriteLine(firstline);
            var sa = firstline.Split('=')[1];
            inputs.StepAllowance = Int32.Parse(sa); 
            Console.WriteLine(inputs.StepAllowance);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // frmWindow Window = new frmWindow();
            // Window.Size = new Size(Convert.ToInt32(txtWindowWidth.Text), Convert.ToInt32(txtWindowHeight.Text));
            // Window.NumOfCols = Convert.ToInt32(txtNumOfCols.Text); 
            // Window.NumOfRows = Convert.ToInt32(txtNumOfRows.Text);
            //
            // Window.Show();
        }
    }
}
