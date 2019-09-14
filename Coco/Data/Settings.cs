using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Coco.Data
{
    public class Settings
    {
        /// <summary>
        /// Parameterless constructor needed for XML serialization. Must be empty.
        /// </summary>
        public Settings()
        {
        }

        public CocoDay DayMeetingMidweek { get; set; }
        public CocoDay DayMeetingWeekend { get; set; }
        public DateTime TimeMeetingMidweek { get; set; }
        public DateTime TimeMeetingWeekend { get; set; }

        [XmlArray("")]
        public List<Song> Songs { get; set; }

        /// <summary>
        /// Initialization method because the parameterless constructor needs to be empty.
        /// </summary>
        public void InitializeData()
        {
            DayMeetingMidweek = new CocoDay(DayOfWeek.Tuesday);
            DayMeetingWeekend = new CocoDay(DayOfWeek.Sunday);
            TimeMeetingMidweek = new DateTime(2019, 1, 1, 19, 0, 0);
            TimeMeetingWeekend = new DateTime(2019, 1, 1, 18, 0, 0);

            // TODO: Read available songs from a file
            Songs = new List<Song>();
            for (int i = 1; i < 152; i++)
                Songs.Add(new Song(i, "Name"));
        }
    }
}
