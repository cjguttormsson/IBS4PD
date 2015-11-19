namespace IBS4PD
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseResumeButton = new System.Windows.Forms.Button();
            this.diagBox = new System.Windows.Forms.GroupBox();
            this.optLabel = new System.Windows.Forms.Label();
            this.elimLabel = new System.Windows.Forms.Label();
            this.exLabel = new System.Windows.Forms.Label();
            this.unexLabel = new System.Windows.Forms.Label();
            this.ubLabel = new System.Windows.Forms.Label();
            this.lbLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.diagBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSolutionToolStripMenuItem,
            this.exportResultsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newSolutionToolStripMenuItem
            // 
            this.newSolutionToolStripMenuItem.Name = "newSolutionToolStripMenuItem";
            this.newSolutionToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newSolutionToolStripMenuItem.Text = "New Solution";
            this.newSolutionToolStripMenuItem.Click += new System.EventHandler(this.newSolutionToolStripMenuItem_Click);
            // 
            // exportResultsToolStripMenuItem
            // 
            this.exportResultsToolStripMenuItem.Enabled = false;
            this.exportResultsToolStripMenuItem.Name = "exportResultsToolStripMenuItem";
            this.exportResultsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exportResultsToolStripMenuItem.Text = "Export Results";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pauseResumeButton
            // 
            this.pauseResumeButton.Enabled = false;
            this.pauseResumeButton.Location = new System.Drawing.Point(537, 406);
            this.pauseResumeButton.Name = "pauseResumeButton";
            this.pauseResumeButton.Size = new System.Drawing.Size(75, 23);
            this.pauseResumeButton.TabIndex = 1;
            this.pauseResumeButton.Text = "Pause";
            this.pauseResumeButton.UseVisualStyleBackColor = true;
            this.pauseResumeButton.Click += new System.EventHandler(this.pauseResumeButton_Click);
            // 
            // diagBox
            // 
            this.diagBox.Controls.Add(this.optLabel);
            this.diagBox.Controls.Add(this.elimLabel);
            this.diagBox.Controls.Add(this.exLabel);
            this.diagBox.Controls.Add(this.unexLabel);
            this.diagBox.Controls.Add(this.ubLabel);
            this.diagBox.Controls.Add(this.lbLabel);
            this.diagBox.Controls.Add(this.timeLabel);
            this.diagBox.Location = new System.Drawing.Point(412, 27);
            this.diagBox.Name = "diagBox";
            this.diagBox.Size = new System.Drawing.Size(200, 204);
            this.diagBox.TabIndex = 2;
            this.diagBox.TabStop = false;
            this.diagBox.Text = "Diagnostic Info";
            // 
            // optLabel
            // 
            this.optLabel.AutoSize = true;
            this.optLabel.Location = new System.Drawing.Point(6, 159);
            this.optLabel.Name = "optLabel";
            this.optLabel.Size = new System.Drawing.Size(78, 13);
            this.optLabel.TabIndex = 6;
            this.optLabel.Text = "Optimality Gap:";
            // 
            // elimLabel
            // 
            this.elimLabel.AutoSize = true;
            this.elimLabel.Location = new System.Drawing.Point(6, 135);
            this.elimLabel.Name = "elimLabel";
            this.elimLabel.Size = new System.Drawing.Size(92, 13);
            this.elimLabel.TabIndex = 5;
            this.elimLabel.Text = "Eliminated Nodes:";
            // 
            // exLabel
            // 
            this.exLabel.AutoSize = true;
            this.exLabel.Location = new System.Drawing.Point(6, 113);
            this.exLabel.Name = "exLabel";
            this.exLabel.Size = new System.Drawing.Size(85, 13);
            this.exLabel.TabIndex = 4;
            this.exLabel.Text = "Explored Nodes:";
            // 
            // unexLabel
            // 
            this.unexLabel.AutoSize = true;
            this.unexLabel.Location = new System.Drawing.Point(6, 91);
            this.unexLabel.Name = "unexLabel";
            this.unexLabel.Size = new System.Drawing.Size(98, 13);
            this.unexLabel.TabIndex = 3;
            this.unexLabel.Text = "Unexplored Nodes:";
            // 
            // ubLabel
            // 
            this.ubLabel.AutoSize = true;
            this.ubLabel.Location = new System.Drawing.Point(6, 69);
            this.ubLabel.Name = "ubLabel";
            this.ubLabel.Size = new System.Drawing.Size(97, 13);
            this.ubLabel.TabIndex = 2;
            this.ubLabel.Text = "Best Upper Bound:";
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Location = new System.Drawing.Point(6, 47);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(97, 13);
            this.lbLabel.TabIndex = 1;
            this.lbLabel.Text = "Best Lower Bound:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(6, 25);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(119, 13);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Elapsed Time: 00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 315);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(456, 406);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.diagBox);
            this.Controls.Add(this.pauseResumeButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "IBS for Periodic Delivery";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.diagBox.ResumeLayout(false);
            this.diagBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button pauseResumeButton;
        private System.Windows.Forms.GroupBox diagBox;
        private System.Windows.Forms.Label ubLabel;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label optLabel;
        private System.Windows.Forms.Label elimLabel;
        private System.Windows.Forms.Label exLabel;
        private System.Windows.Forms.Label unexLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

