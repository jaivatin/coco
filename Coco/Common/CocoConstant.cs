using System;
using System.IO;

namespace Coco.Common
{
    public static class CocoConstant
    {
        // Paths
        public static readonly string ConfigDirFullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config");
        public static readonly string SettingsXmlFullPath = Path.Combine(ConfigDirFullPath, "Settings.xml");
        public static readonly string DocumentsXmlFullPath = Path.Combine(ConfigDirFullPath, "Documents.xml");
        public static readonly string PersonsXmlFullPath = Path.Combine(ConfigDirFullPath, "Persons.xml");

        // Keys
        public static readonly string KeyPersons = "PERSONS";

        // Miscellaneous
        public static readonly string FormatMeetingDate = "dddd, d. MMM. yyyy";
        public static readonly char SeparatorSong = ':';
    }
}
