/*This file is part of GameLocker.

    GameLocker is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    GameLocker is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with GameLocker.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Configurator
{
    public partial class PlayGame : Form
    {
        public PlayGame()
        {
            InitializeComponent();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        lockerSettings settings = new lockerSettings();

        private void refreshList()
        {
            settings.Reload();
            listBoxGames.Items.Clear();
            treeViewStats.Nodes.Clear();
            treeViewStats.Nodes.Add(new TreeNode("Statistics"));
            Game games;
            for (int i = 0; i < settings.fileList.Count; i++)
            {
                games = new Game(settings.fileMap[i], settings.fileList[i]);
                listBoxGames.Items.Add(games);
                treeViewStats.Nodes[0].Nodes.Add(games.GameName, games.GameName);
                treeViewStats.Nodes[0].Nodes[i].Nodes.Add("Total Time Played");
                treeViewStats.Nodes[0].Nodes[i].Nodes[0].Nodes.Add(games.WhatIsTotalTime.Days + " days");
                treeViewStats.Nodes[0].Nodes[i].Nodes[0].Nodes.Add(games.WhatIsTotalTime.Hours + " hours");
                treeViewStats.Nodes[0].Nodes[i].Nodes[0].Nodes.Add(games.WhatIsTotalTime.Minutes + " mins");
                treeViewStats.Nodes[0].Nodes[i].Nodes[0].Nodes.Add(games.WhatIsTotalTime.Seconds + " secs");
                treeViewStats.Nodes[0].Nodes[i].Nodes[0].Nodes.Add(games.WhatIsTotalTime.TotalHours + " total hours");
            }
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogExecutible.ShowDialog();

            if (result == DialogResult.OK)
            {
                NameDialog named = new NameDialog();
                if (named.ShowDialog() == DialogResult.OK)
                {
                    locker.lockFile(openFileDialogExecutible.FileName);
                    settings.Reload();
                    settings.fileMap.Add(named.textBox1.Text);
                    settings.Save();
                    refreshList();
                }
            }
        }

        private void buttonUnlock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will unlock all files in the locker, are you sure?", "Unlock all Files?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                locker.unlockAllFiles();
            refreshList();
            Application.Restart();
        }

        CheckedOutGame gameRunning;

        private void refreshRunning()
        {
            treeViewStats.Nodes[0].Expand();
            TreeNode[] gameNode = treeViewStats.Nodes.Find(gameRunning.GameName, true);
            gameNode[0].Expand();

            TreeNode timeNode = gameNode[0].Nodes[0];
            timeNode.Text = "Session Timer";
            TimeSpan timePlayed = gameRunning.SessionTime();
            timeNode.Nodes[0].Text = timePlayed.Days + " days";
            timeNode.Nodes[1].Text = timePlayed.Hours + " hours";
            timeNode.Nodes[2].Text = timePlayed.Minutes + " minutes";
            timeNode.Nodes[3].Text = timePlayed.Seconds + " seconds";
            timeNode.Nodes[4].Text = timePlayed.TotalHours + " total hours";
            timeNode.Expand();

            if (gameNode[0].Nodes.Count < 2)
            {
                gameNode[0].Nodes.Add("Total Time Played");
                for (int i = 0; i < 5; i++)
                    gameNode[0].Nodes[1].Nodes.Add("");
            }
            timeNode = gameNode[0].Nodes[1];
            timePlayed = gameRunning.LiveTotalTime();
            timeNode.Nodes[0].Text = timePlayed.Days + " days";
            timeNode.Nodes[1].Text = timePlayed.Hours + " hours";
            timeNode.Nodes[2].Text = timePlayed.Minutes + " minutes";
            timeNode.Nodes[3].Text = timePlayed.Seconds + " seconds";
            timeNode.Nodes[4].Text = timePlayed.TotalHours + " total hours";
            timeNode.Expand();

            if (timerTimedGame.Enabled == true)
            {
                //update timed stats
                progressBar1.Maximum = settings.timedGame.Minutes * 60;
                progressBar1.Value = gameRunning.SessionTime().Seconds;
                label2.Text = gameRunning.SessionTime().Minutes + " of " + settings.timedGame.Minutes + " played";
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //run the improbability drive
            imProbabilityDrive drive = new imProbabilityDrive();
            Random rand = new Random();
            TimeSpan span;
            if (gameRunning == null)
            {
                span = DateTime.Now - settings.lastTry;
                if (settings.waitToPlay <= span)
                {
                    if (drive.ShowDialog() == DialogResult.OK)
                    {
                        if (drive.numericUpDownPicker.Value == rand.Next(settings.probability + 1))
                        {
                            settings.lastTry = DateTime.Now;
                            settings.Reload();
                            Game game = (Game)listBoxGames.SelectedItem;
                            if (game == null)
                            {
                                return;
                            }
                            listBoxGames.Enabled = false;
                            gameRunning = game.CheckOut();
                            timerCheckOut.Enabled = true;
                        }
                        else
                        {
                            span = settings.incorrectWait;
                            MessageBox.Show("You have guessed incorrectly, you must wait " + span.Hours + ":" + span.Minutes + ":" + span.Seconds + " before trying again", "oops");
                        }
                    }
                }
                else
                {
                    span = settings.waitToPlay - (DateTime.Now - settings.lastTry);
                    MessageBox.Show("Sorry, but you must wait at least " + span.Hours + ":" + span.Minutes + ":" + span.Seconds + " to try playing again", "Oops");
                }
            }
        }

        private void PlayGame_Load(object sender, EventArgs e)
        {
            refreshList();
            notifyIcon.Visible = true;
        }

        private void timerCheckOut_Tick(object sender, EventArgs e)
        {
            if (!gameRunning.hasExited())
            {
                //game is still running
                refreshRunning();
            }
            //on game exit, reset
            else
            {
                if (gameRunning.checkedout)
                    gameRunning.CheckIn(false);
                timerCheckOut.Enabled = false;
                refreshList();
                listBoxGames.Enabled = true;
                gameRunning = null;
                timerTimedGame.Enabled = false;
                progressBar1.Visible = false;
                label2.Visible = false;
                label1.Visible = false;
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
        }

        private void backgroundTimeSystem_DoWork(object sender, DoWorkEventArgs e)
        {
            gameRunning.CheckIn(false);
        }

        private void buttonTimed_Click(object sender, EventArgs e)
        {
            if (gameRunning == null)
            {
                settings.Reload();
                TimeSpan span = (DateTime.Now - settings.lastTry);
                if (settings.waitToPlay < span)
                {
                    timerTimedGame.Interval = (int)settings.timedGame.TotalMilliseconds;
                    settings.Reload();
                    Game game = (Game)listBoxGames.SelectedItem;
                    if (game == null)
                    {
                        return;
                    }
                    listBoxGames.Enabled = false;
                    gameRunning = game.CheckOut();
                    timerCheckOut.Enabled = true;
                    timerTimedGame.Enabled = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    progressBar1.Visible = true;
                }
                else
                {
                    TimeSpan sp = (settings.waitToPlay - (DateTime.Now - settings.lastTry));
                    MessageBox.Show("You must wait at least " + span.Hours + ":" + span.Minutes + ":" + span.Seconds + " before you can play again");
                }
            }
        }

        private void timerTimedGame_Tick(object sender, EventArgs e)
        {
            settings.Reload();
            if (settings.alertBeforeKill)
            {
                //alert the user by sound
                if (settings.alertAudible)
                    SystemSounds.Beep.Play();
                if (settings.alertTakeFocus)
                    this.Focus();
            }
            if (!backgroundTimeSystem.IsBusy)
                backgroundTimeSystem.RunWorkerAsync();
            //alert the user visually
            if (settings.alertBeforeKill)
                if (settings.alertVisual)
                    MessageBox.Show("The Game is shutting down in: " + settings.checkInWait.Hours + ":" + settings.checkInWait.Minutes + ":" + settings.checkInWait.Seconds, "Shutting down game", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        private void onKill(object sender, FormClosedEventArgs e)
        {
            
        }

        private void onKilling(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            if (e.CloseReason == CloseReason.TaskManagerClosing ||
                e.CloseReason == CloseReason.WindowsShutDown ||
                e.CloseReason == CloseReason.ApplicationExitCall)
            {
                //shut down the game
                if (gameRunning != null)
                    if (!gameRunning.hasExited())
                    {
                        gameRunning.CheckIn(true);
                    }
            }
        }

        private void playALockedGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            OptionsForm options = new OptionsForm();
            options.ShowDialog();
            settings.Reload();
        }
    }
}
