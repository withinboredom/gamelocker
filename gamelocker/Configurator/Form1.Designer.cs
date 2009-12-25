namespace Configurator
{
    partial class PlayGame
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Statistics");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonUnlock = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonTimed = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewStats = new System.Windows.Forms.TreeView();
            this.openFileDialogExecutible = new System.Windows.Forms.OpenFileDialog();
            this.timerCheckOut = new System.Windows.Forms.Timer(this.components);
            this.buttonLog = new System.Windows.Forms.Button();
            this.backgroundTimeSystem = new System.ComponentModel.BackgroundWorker();
            this.timerTimedGame = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playALockedGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStripIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxGames
            // 
            this.listBoxGames.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.Location = new System.Drawing.Point(0, 0);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(145, 290);
            this.listBoxGames.TabIndex = 0;
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(151, 238);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(145, 23);
            this.buttonLock.TabIndex = 1;
            this.buttonLock.Text = "Lock a New Game";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // buttonUnlock
            // 
            this.buttonUnlock.Location = new System.Drawing.Point(151, 267);
            this.buttonUnlock.Name = "buttonUnlock";
            this.buttonUnlock.Size = new System.Drawing.Size(145, 23);
            this.buttonUnlock.TabIndex = 2;
            this.buttonUnlock.Text = "Unlock All Games";
            this.buttonUnlock.UseVisualStyleBackColor = true;
            this.buttonUnlock.Click += new System.EventHandler(this.buttonUnlock_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(151, 12);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonTimed
            // 
            this.buttonTimed.Location = new System.Drawing.Point(151, 41);
            this.buttonTimed.Name = "buttonTimed";
            this.buttonTimed.Size = new System.Drawing.Size(75, 23);
            this.buttonTimed.TabIndex = 4;
            this.buttonTimed.Text = "Timed Play";
            this.buttonTimed.UseVisualStyleBackColor = true;
            this.buttonTimed.Click += new System.EventHandler(this.buttonTimed_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Location = new System.Drawing.Point(151, 111);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(75, 23);
            this.buttonOptions.TabIndex = 5;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(151, 164);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.treeViewStats);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(304, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 296);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 43);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(67, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "0 of 0 minutes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(67, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(130, 15);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Used";
            this.label1.Visible = false;
            // 
            // treeViewStats
            // 
            this.treeViewStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeViewStats.Location = new System.Drawing.Point(0, 43);
            this.treeViewStats.Name = "treeViewStats";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Statistics";
            this.treeViewStats.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewStats.Size = new System.Drawing.Size(206, 253);
            this.treeViewStats.TabIndex = 1;
            this.treeViewStats.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // openFileDialogExecutible
            // 
            this.openFileDialogExecutible.DefaultExt = "*.exe";
            this.openFileDialogExecutible.Filter = "Executible Files|*.exe|All Files|*.*";
            this.openFileDialogExecutible.Title = "Select an Executible File";
            // 
            // timerCheckOut
            // 
            this.timerCheckOut.Interval = 1000;
            this.timerCheckOut.Tick += new System.EventHandler(this.timerCheckOut_Tick);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(151, 70);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 23);
            this.buttonLog.TabIndex = 8;
            this.buttonLog.Text = "View Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // backgroundTimeSystem
            // 
            this.backgroundTimeSystem.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundTimeSystem_DoWork);
            // 
            // timerTimedGame
            // 
            this.timerTimedGame.Tick += new System.EventHandler(this.timerTimedGame_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Game Locker";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStripIcon
            // 
            this.contextMenuStripIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playALockedGameToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripIcon.Name = "contextMenuStripIcon";
            this.contextMenuStripIcon.Size = new System.Drawing.Size(181, 70);
            // 
            // playALockedGameToolStripMenuItem
            // 
            this.playALockedGameToolStripMenuItem.Name = "playALockedGameToolStripMenuItem";
            this.playALockedGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playALockedGameToolStripMenuItem.Text = "Play a Locked Game";
            this.playALockedGameToolStripMenuItem.Click += new System.EventHandler(this.playALockedGameToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 296);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.buttonTimed);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonUnlock);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.listBoxGames);
            this.DoubleBuffered = true;
            this.Name = "PlayGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Play Locked Game";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onKill);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onKilling);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStripIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonUnlock;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonTimed;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewStats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialogExecutible;
        private System.Windows.Forms.Timer timerCheckOut;
        private System.Windows.Forms.Button buttonLog;
        private System.ComponentModel.BackgroundWorker backgroundTimeSystem;
        private System.Windows.Forms.Timer timerTimedGame;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIcon;
        private System.Windows.Forms.ToolStripMenuItem playALockedGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

