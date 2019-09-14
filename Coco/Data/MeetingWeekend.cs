using System;
using static Coco.Common.CocoEnum;

namespace Coco.Data
{
    public class MeetingWeekend : Meeting
    {
        /// <summary>
        /// Parameterless constructor needed for XML serialization. Must be empty.
        /// </summary>
        private MeetingWeekend()
        {
        }

        public MeetingWeekend(DateTime date)
            : base(date)
        {
            // Opening comments
            MeetingElements.Add(new MeetingElement(MeetingElementKey.WeekendChairman, date, false, 0m,
                MeetingElementKey.WeekendChairman.GetDescription()));

            // Lecture
            MeetingElements.Add(new MeetingElement(MeetingElementKey.WeekendLecture, date, false, 0m,
                MeetingElementKey.WeekendLecture.GetDescription()));

            // Watchtower study
            MeetingElements.Add(new MeetingElement(MeetingElementKey.WatchtowerStudy, date, false, 0m,
                MeetingElementKey.WatchtowerStudy.GetDescription()));
        }
    }
}
