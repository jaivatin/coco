using System;
using static Coco.Common.CocoEnum;

namespace Coco.Data
{
    public class MeetingMidweek : Meeting
    {
        /// <summary>
        /// Parameterless constructor needed for XML serialization. Must be empty.
        /// </summary>
        private MeetingMidweek()
        {
        }

        public MeetingMidweek(DateTime date)
            : base(date)
        {
            // Opening comments
            MeetingElements.Add(new MeetingElement(MeetingElementKey.MidweekChairman, date, false, 0m,
                MeetingElementKey.MidweekChairman.GetDescription()));

            // Treasures from god's word
            MeetingElements.Add(new MeetingElement(MeetingElementKey.TreasuresFromGodsWord, date, false, 0m,
                MeetingElementKey.TreasuresFromGodsWord.GetDescription()));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.DiggingForSpiritualGems, date, false, 0m,
                MeetingElementKey.DiggingForSpiritualGems.GetDescription()));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.BibleReading, date, false, 0m,
                MeetingElementKey.BibleReading.GetDescription()));

            // Apply yourself to the field ministry
            MeetingElements.Add(new MeetingElement(MeetingElementKey.ApplyYourselfToTheFieldMinistry, date, false, 0m));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.ApplyYourselfToTheFieldMinistry, date, false, 0m));

            // Living as christians
            MeetingElements.Add(new MeetingElement(MeetingElementKey.LivingAsChristians, date, false, 0m,
                MeetingElementKey.LivingAsChristians.GetDescription()));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.CongregationBibleStudy, date, false, 0m,
                MeetingElementKey.CongregationBibleStudy.GetDescription()));
            MeetingElements.Add(new MeetingElement(MeetingElementKey.ReviewPreviewAnnouncements, date, false, 0m,
                MeetingElementKey.ReviewPreviewAnnouncements.GetDescription()));
        }
    }
}
