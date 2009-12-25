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

namespace Configurator
{
    partial class OptionsForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.optionsCheckInTime = new System.Windows.Forms.NumericUpDown();
            this.optionsTimedGame = new System.Windows.Forms.NumericUpDown();
            this.optionsProbability = new System.Windows.Forms.NumericUpDown();
            this.optionsWaitToPlay = new System.Windows.Forms.NumericUpDown();
            this.optionsIncorrectWait = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optionsAlertBeforeKill = new System.Windows.Forms.CheckBox();
            this.optionsAudible = new System.Windows.Forms.CheckBox();
            this.optionsVisual = new System.Windows.Forms.CheckBox();
            this.optionsTakeFocus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.optionsCheckInTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsTimedGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsProbability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsWaitToPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsIncorrectWait)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(201, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Force Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // optionsCheckInTime
            // 
            this.optionsCheckInTime.Location = new System.Drawing.Point(12, 12);
            this.optionsCheckInTime.Name = "optionsCheckInTime";
            this.optionsCheckInTime.Size = new System.Drawing.Size(120, 20);
            this.optionsCheckInTime.TabIndex = 4;
            // 
            // optionsTimedGame
            // 
            this.optionsTimedGame.Location = new System.Drawing.Point(12, 38);
            this.optionsTimedGame.Name = "optionsTimedGame";
            this.optionsTimedGame.Size = new System.Drawing.Size(120, 20);
            this.optionsTimedGame.TabIndex = 5;
            // 
            // optionsProbability
            // 
            this.optionsProbability.Location = new System.Drawing.Point(12, 64);
            this.optionsProbability.Name = "optionsProbability";
            this.optionsProbability.Size = new System.Drawing.Size(120, 20);
            this.optionsProbability.TabIndex = 6;
            // 
            // optionsWaitToPlay
            // 
            this.optionsWaitToPlay.Location = new System.Drawing.Point(12, 90);
            this.optionsWaitToPlay.Name = "optionsWaitToPlay";
            this.optionsWaitToPlay.Size = new System.Drawing.Size(120, 20);
            this.optionsWaitToPlay.TabIndex = 7;
            // 
            // optionsIncorrectWait
            // 
            this.optionsIncorrectWait.Location = new System.Drawing.Point(12, 116);
            this.optionsIncorrectWait.Name = "optionsIncorrectWait";
            this.optionsIncorrectWait.Size = new System.Drawing.Size(120, 20);
            this.optionsIncorrectWait.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optionsTakeFocus);
            this.groupBox1.Controls.Add(this.optionsVisual);
            this.groupBox1.Controls.Add(this.optionsAudible);
            this.groupBox1.Controls.Add(this.optionsAlertBeforeKill);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 154);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alerts";
            // 
            // optionsAlertBeforeKill
            // 
            this.optionsAlertBeforeKill.AutoSize = true;
            this.optionsAlertBeforeKill.Location = new System.Drawing.Point(6, 19);
            this.optionsAlertBeforeKill.Name = "optionsAlertBeforeKill";
            this.optionsAlertBeforeKill.Size = new System.Drawing.Size(143, 17);
            this.optionsAlertBeforeKill.TabIndex = 10;
            this.optionsAlertBeforeKill.Text = "Alert at end of time game";
            this.optionsAlertBeforeKill.UseVisualStyleBackColor = true;
            this.optionsAlertBeforeKill.CheckedChanged += new System.EventHandler(this.optionsAlertBeforeKill_CheckedChanged);
            // 
            // optionsAudible
            // 
            this.optionsAudible.AutoSize = true;
            this.optionsAudible.Location = new System.Drawing.Point(22, 42);
            this.optionsAudible.Name = "optionsAudible";
            this.optionsAudible.Size = new System.Drawing.Size(61, 17);
            this.optionsAudible.TabIndex = 10;
            this.optionsAudible.Text = "Audible";
            this.optionsAudible.UseVisualStyleBackColor = true;
            // 
            // optionsVisual
            // 
            this.optionsVisual.AutoSize = true;
            this.optionsVisual.Location = new System.Drawing.Point(22, 65);
            this.optionsVisual.Name = "optionsVisual";
            this.optionsVisual.Size = new System.Drawing.Size(54, 17);
            this.optionsVisual.TabIndex = 10;
            this.optionsVisual.Text = "Visual";
            this.optionsVisual.UseVisualStyleBackColor = true;
            // 
            // optionsTakeFocus
            // 
            this.optionsTakeFocus.AutoSize = true;
            this.optionsTakeFocus.Location = new System.Drawing.Point(22, 88);
            this.optionsTakeFocus.Name = "optionsTakeFocus";
            this.optionsTakeFocus.Size = new System.Drawing.Size(55, 17);
            this.optionsTakeFocus.TabIndex = 10;
            this.optionsTakeFocus.Text = "Focus";
            this.optionsTakeFocus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Time to wait before game kill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "How long to play a timed game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Probability to choose the correct number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "How long before play again";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "How long to wait if incorrect number";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(369, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.optionsIncorrectWait);
            this.Controls.Add(this.optionsWaitToPlay);
            this.Controls.Add(this.optionsProbability);
            this.Controls.Add(this.optionsTimedGame);
            this.Controls.Add(this.optionsCheckInTime);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.optionsCheckInTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsTimedGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsProbability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsWaitToPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionsIncorrectWait)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown optionsCheckInTime;
        private System.Windows.Forms.NumericUpDown optionsTimedGame;
        private System.Windows.Forms.NumericUpDown optionsProbability;
        private System.Windows.Forms.NumericUpDown optionsWaitToPlay;
        private System.Windows.Forms.NumericUpDown optionsIncorrectWait;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox optionsAlertBeforeKill;
        private System.Windows.Forms.CheckBox optionsAudible;
        private System.Windows.Forms.CheckBox optionsTakeFocus;
        private System.Windows.Forms.CheckBox optionsVisual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}