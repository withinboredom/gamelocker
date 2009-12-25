using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.ComponentModel;

namespace Configurator
{
    public static class SettingsSystem
    {
        private static lockerSettings freeSettings = new lockerSettings();
        private static lockerSettings ranSettings = new lockerSettings();

        public static void stopSavingRunning(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            //not allowed to save these!!
        }

        internal static void init()
        {
            SettingsSavingEventHandler saveHandler = new SettingsSavingEventHandler(stopSavingRunning);
            ranSettings.SettingsSaving += saveHandler;
            ranSettings.SettingsLoaded += new SettingsLoadedEventHandler(ranSettings_SettingsLoaded);
        }

        static void ranSettings_SettingsLoaded(object sender, SettingsLoadedEventArgs e)
        {
        }

        internal static lockerSettings GetSettings()
        {
            freeSettings.Reload();
            return freeSettings;
        }

        internal static void Sync()
        {
            ranSettings.Reload();
        }

        internal static lockerSettings GetSettings(bool running)
        {
            if (running)
            {
                return ranSettings;
            }
            else
            {
                freeSettings.Reload();
                return freeSettings;
            }
        }
    }
}
