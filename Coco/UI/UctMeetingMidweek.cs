using Coco.Data;
using System.Collections.Generic;
using System.Linq;
using static Coco.Common.CocoEnum;

namespace Coco.UI
{
    public partial class UctMeetingMidweek : UctMeeting
    {
        private List<UctMeetingElement> cmeApplyYourselfToTheFieldMinistryList;
        private List<UctMeetingElement> cmeLivingAsChristiansList;

        public UctMeetingMidweek()
        {
            InitializeComponent();

            cmeApplyYourselfToTheFieldMinistryList = new List<UctMeetingElement>();
            cmeApplyYourselfToTheFieldMinistryList.Add(cmeApplyYourselfToTheFieldMinistry1);
            cmeApplyYourselfToTheFieldMinistryList.Add(cmeApplyYourselfToTheFieldMinistry2);
            cmeApplyYourselfToTheFieldMinistryList.Add(cmeApplyYourselfToTheFieldMinistry3);

            cmeLivingAsChristiansList = new List<UctMeetingElement>();
            cmeLivingAsChristiansList.Add(cmeLivingAsChristians1);
            cmeLivingAsChristiansList.Add(cmeLivingAsChristians2);

            InitializeControl();
        }

        protected override void SetMeetingElements()
        {
            List<MeetingElement> meetingElements;

            // Opening comments
            cmeChairman.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.MidweekChairman);
            cmeSong1.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.Song1);
            cmePrayer1.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.Prayer1);
            cmeOpeningComments.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.OpeningComments);

            // Treasures from gods word
            cmeTreasuresFromGodsWord.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.TreasuresFromGodsWord);
            cmeDiggingForSpiritualGems.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.DiggingForSpiritualGems);
            cmeBibleReading.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.BibleReading);

            // Apply yourself to the field ministry
            meetingElements = Meeting.MeetingElements.Where(x =>
                x.Key == MeetingElementKey.ApplyYourselfToTheFieldMinistry ||
                x.Key == MeetingElementKey.InitialCall ||
                x.Key == MeetingElementKey.FirstReturnVisit ||
                x.Key == MeetingElementKey.SecondReturnVisit ||
                x.Key == MeetingElementKey.ThirdReturnVisit ||
                x.Key == MeetingElementKey.BibleStudy ||
                x.Key == MeetingElementKey.MidweekLecture).ToList();
            for (int i = 0; i < meetingElements.Count; i++)
                cmeApplyYourselfToTheFieldMinistryList[i].MeetingElement = meetingElements[i];

            // Living as christians
            cmeSong2.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.Song2);
            meetingElements = Meeting.MeetingElements.Where(x =>
                x.Key == MeetingElementKey.LivingAsChristians).ToList();
            for (int i = 0; i < meetingElements.Count; i++)
                cmeLivingAsChristiansList[i].MeetingElement = meetingElements[i];
            cmeCongregationBibleStudy.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.CongregationBibleStudy);
            cmeReviewPreviewAnnouncements.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.ReviewPreviewAnnouncements);
            cmeSong3.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.Song3);
            cmePrayer2.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.Prayer2);

            // Service plan
            cmeMicrophoneService.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.MicrophoneService);
            cmeReader.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.Reader);
            cmeSecurityService.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.SecurityService);
            cmeSoundSystemService.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.SoundSystemService);
            cmeStageService.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.StageService);
        }

        private void InitializeControl()
        {
            int number = 1;
            foreach (UctMeetingElement uctMeetingElement in flpMeetingMidweek.Controls.OfType<UctMeetingElement>())
            {
                uctMeetingElement.Number = number++;
                uctMeetingElement.OnEditPersonEvent += UctMeetingElement_OnEditPersonEvent;
                CmeList.Add(uctMeetingElement);
            }
        }
    }
}
