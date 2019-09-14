using System.Collections.Generic;
using System.Xml.Serialization;

namespace Coco.Data
{
    [XmlInclude(typeof(MeetingMidweek))]
    [XmlInclude(typeof(MeetingWeekend))]
    public class Document
    {
        /// <summary>
        /// Parameterless constructor needed for XML serialization. Must be empty.
        /// </summary>
        private Document()
        {
        }

        public Document(int year, int month)
        {
            Year = year;
            Month = month;
            Meetings = new List<Meeting>();
        }

        public int Year { get; set; }
        public int Month { get; set; }

        [XmlArray("")]
        public List<Meeting> Meetings { get; set; }
    }
}
