using System;
using System.ComponentModel;
using System.Reflection;

namespace Coco.Common
{
    public static class CocoEnum
    {
        public enum Gender
        {
            [Description("Weiblich")]
            Female,
            [Description("Männlich")]
            Male
        }

        public enum Appointment
        {
            [Description("Verkündiger")]
            Publisher,
            [Description("Dienstamtgehilfe")]
            MinisterialServant,
            [Description("Ältester")]
            Overseer,
            [Description("Pionier")]
            Pioneer
        }

        public enum MeetingElementKey
        {
            // Apply yourself to the field ministry
            [Description("Bibellesung")]
            BibleReading,
            [Description("Erstes Gespräch")]
            InitialCall,
            [Description("Erster Rückbesuch")]
            FirstReturnVisit,
            [Description("Zweiter Rückbesuch")]
            SecondReturnVisit,
            [Description("Dritter Rückbesuch")]
            ThirdReturnVisit,
            [Description("Bibelstudium")]
            BibleStudy,
            [Description("Vortrag")]
            MidweekLecture,
            [Description("Uns im Dienst verbessern")]
            ApplyYourselfToTheFieldMinistry,
            // Service plan
            [Description("Erstes Gebet")]
            Prayer1,
            [Description("Zweites Gebet")]
            Prayer2,
            [Description("Mikrofondienst")]
            MicrophoneService,
            [Description("Leser")]
            Reader,
            [Description("Ordnungsdienst")]
            SecurityService,
            [Description("Tonanlagendienst")]
            SoundSystemService,
            [Description("Bühnendienst")]
            StageService,
            [Description("Erstes Lied")]
            Song1,
            [Description("Zweites Lied")]
            Song2,
            [Description("Drittes Lied")]
            Song3,
            // Midweek
            [Description("Vorsitz")]
            MidweekChairman,
            [Description("Einleitende Worte")]
            OpeningComments,
            [Description("Schätze aus Gottes Wort")]
            TreasuresFromGodsWord,
            [Description("Nach geistigen Schätzen graben")]
            DiggingForSpiritualGems,
            [Description("Unser Leben als Christ")]
            LivingAsChristians,
            [Description("Versammlungsbibelstudium")]
            CongregationBibleStudy,
            [Description("Wiederholung/Vorschau/Bekanntmachungen")]
            ReviewPreviewAnnouncements,
            // Weekend
            [Description("Vorsitz")]
            WeekendChairman,
            [Description("Vortrag")]
            WeekendLecture,
            [Description("Wachtturmstudium")]
            WatchtowerStudy
        }

        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();

            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    var attribute = Attribute.GetCustomAttribute(field,
                        typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attribute != null)
                        return attribute.Description;
                }
            }

            return null;
        }
    }
}
