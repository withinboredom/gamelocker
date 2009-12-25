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

namespace Configurator
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        lockerSettings settings = new lockerSettings();

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This only resets the database, you will lose all your games. Are you sure you want to do this?", "Are you sure", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                settings.Reset();
                Application.Restart();
            }
        }

        private void loadOptions()
        {
            settings.Reload();
            optionsAlertBeforeKill.Checked = settings.alertBeforeKill;
            optionsAudible.Checked = settings.alertAudible;
            optionsCheckInTime.Value = settings.checkInWait.Minutes;
            optionsIncorrectWait.Value = settings.incorrectWait.Minutes;
            optionsProbability.Value = settings.probability;
            optionsTakeFocus.Checked = settings.alertTakeFocus;
            optionsTimedGame.Value = settings.timedGame.Minutes;
            optionsVisual.Checked = settings.alertVisual;
            optionsWaitToPlay.Value = settings.waitToPlay.Minutes;
        }

        private void saveOptions()
        {
            settings.Reload();
            settings.alertBeforeKill = optionsAlertBeforeKill.Checked;
            settings.alertAudible = optionsAudible.Checked;
            settings.checkInWait = new TimeSpan(0, (int)optionsCheckInTime.Value, 0);
            settings.incorrectWait = new TimeSpan(0, (int)optionsIncorrectWait.Value, 0);
            settings.probability = (int)optionsProbability.Value;
            settings.alertTakeFocus = optionsTakeFocus.Checked;
            settings.timedGame = new TimeSpan(0, (int)optionsTimedGame.Value, 0);
            settings.alertVisual = optionsVisual.Checked;
            settings.waitToPlay = new TimeSpan(0, (int)optionsWaitToPlay.Value, 0);
            settings.Save();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            loadOptions();
        }

        private void optionsAlertBeforeKill_CheckedChanged(object sender, EventArgs e)
        {
            optionsVisual.Visible = optionsAlertBeforeKill.Checked;
            optionsAudible.Visible = optionsAlertBeforeKill.Checked;
            optionsTakeFocus.Visible = optionsAlertBeforeKill.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveOptions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            saveOptions();
            this.Close();
        }
    }
}
