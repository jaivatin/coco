using Coco.Common;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using static Coco.Common.CocoEnum;

namespace Coco.Data
{
    public class Meeting
    {
        /// <summary>
        /// Parameterless constructor needed for XML serialization. Must be empty.
        /// </summary>
        protected Meeting()
        {
        }

        public Meeting(DateTime date)
        {
            Date = date;
            MeetingElements = new List<MeetingElement>();

            // Common
            MeetingElements.Add(new MeetingElement(MeetingElementKey.Song1, date, false, 0m));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.Prayer1, date, false, 0m,
                MeetingElementKey.Prayer1.GetDescription()));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.OpeningComments, date, false, 0m,
                MeetingElementKey.OpeningComments.GetDescription()));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.Song2, date, false, 0m));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.Song3, date, false, 0m));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.Prayer2, date, false, 0m,
                MeetingElementKey.Prayer2.GetDescription()));

            // Service plan
            MeetingElements.Add(new MeetingElement(MeetingElementKey.MicrophoneService, date, false, 0m,
                MeetingElementKey.MicrophoneService.GetDescription()));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.Reader, date, false, 0m,
                MeetingElementKey.Reader.GetDescription()));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.SecurityService, date, false, 0m,
                MeetingElementKey.SecurityService.GetDescription()));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.SoundSystemService, date, false, 0m,
                MeetingElementKey.SoundSystemService.GetDescription()));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.StageService, date, false, 0m,
                MeetingElementKey.StageService.GetDescription()));
        }

        public DateTime Date { get; set; }
        public DateTime LastEdited { get; set; }

        [XmlArray("")]
        public List<MeetingElement> MeetingElements { get; set; }
    }
}
