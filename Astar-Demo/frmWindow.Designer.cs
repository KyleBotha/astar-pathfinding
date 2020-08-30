namespace Astar_Demo
{
    partial class frmWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdateNeighbors = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Controls.Add(this.btnReset);
            this.pnlSideBar.Controls.Add(this.btnRun);
            this.pnlSideBar.Controls.Add(this.btnUpdateNeighbors);
            this.pnlSideBar.Controls.Add(this.button1);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSideBar.Location = new System.Drawing.Point(504, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(150, 482);
            this.pnlSideBar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Debug Console";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnUpdateNeighbors
            // 
            this.btnUpdateNeighbors.Location = new System.Drawing.Point(3, 12);
            this.btnUpdateNeighbors.Name = "btnUpdateNeighbors";
            this.btnUpdateNeighbors.Size = new System.Drawing.Size(144, 51);
            this.btnUpdateNeighbors.TabIndex = 1;
            this.btnUpdateNeighbors.Text = "Update Neighbors";
            this.btnUpdateNeighbors.UseVisualStyleBackColor = true;
            this.btnUpdateNeighbors.Click += new System.EventHandler(this.btnUpdateNeighbors_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(3, 69);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(144, 51);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(3, 126);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 51);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 482);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "frmWindow";
            this.Text = "Window";
            this.Load += new System.EventHandler(this.frmWindow_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateNeighbors;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnReset;
    }
}