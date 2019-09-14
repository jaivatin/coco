using Coco.Common;
using System.IO;

namespace Coco.Data
{
    public static class SettingsManager
    {
        private static Settings settings;
        public static Settings Settings
        {
            get
            {
                if (settings == null)
                    LoadSettings();

                return settings;
            }
            set { settings = value; }
        }

        public static void LoadSettings(bool loadDefault = false)
        {
            if (loadDefault || !File.Exists(CocoConstant.SettingsXmlFullPath))
            {
                Settings = new Settings();
                Settings.InitializeData();
                return;
            }

            Settings = Serializer.Deserialize<Settings>(CocoConstant.SettingsXmlFullPath);
        }

        public static void SaveSettings()
        {
            Serializer.Serialize(CocoConstant.ConfigDirFullPath, CocoConstant.SettingsXmlFullPath, Settings);
        }
    }
}
