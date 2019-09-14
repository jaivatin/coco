using System;
using static Coco.Common.CocoEnum;

namespace Coco.Data
{
    public class MeetingElement
    {
        /// <summary>
        /// Parameterless constructor needed for XML serialization. Must be empty.
        /// </summary>
        private MeetingElement()
        {
        }

        public MeetingElement(MeetingElementKey key, DateTime start, bool isUpTo, decimal duration)
        {
            Key = key;
            Start = start;
            IsUpTo = isUpTo;
            Duration = duration;
        }

        public MeetingElement(MeetingElementKey key, DateTime start, bool isUpTo, decimal duration, string title)
            : this(key, start, isUpTo, duration)
        {
            Title = title;
        }

        public MeetingElementKey Key { get; set; }
        public DateTime Start { get; set; }
        public bool IsUpTo { get; set; }
        public decimal Duration { get; set; }
        public string Title { get; set; }
        public string PersonKey { get; set; }
        public string PartnerKey { get; set; }
    }
}
