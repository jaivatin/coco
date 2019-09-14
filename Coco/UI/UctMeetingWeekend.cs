using Coco.Data;
using System.Linq;
using static Coco.Common.CocoEnum;

namespace Coco.UI
{
    public partial class UctMeetingWeekend : UctMeeting
    {
        public UctMeetingWeekend()
        {
            InitializeComponent();
            InitializeControl();
        }

        protected override void SetMeetingElements()
        {
            // Opening comments
            cmeChairman.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.WeekendChairman);
            cmeSong1.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.Song1);
            cmePrayer1.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.Prayer1);
            cmeOpeningComments.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.OpeningComments);

            // Lecture
            cmeLecture.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.WeekendLecture);

            // Watchtower study
            cmeSong2.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.Song2);
            cmeWatchtowerStudy.MeetingElement = Meeting.MeetingElements.Single(x =>
                x.Key == MeetingElementKey.WatchtowerStudy);
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
            foreach (UctMeetingElement uctMeetingElement in flpMeetingWeekend.Controls.OfType<UctMeetingElement>())
            {
                uctMeetingElement.Number = number++;
                uctMeetingElement.OnEditPersonEvent += UctMeetingElement_OnEditPersonEvent;
                CmeList.Add(uctMeetingElement);
            }
        }
    }
}
