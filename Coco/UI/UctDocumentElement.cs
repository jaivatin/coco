using Coco.Common;
using Coco.Data;
using System;
using System.Windows.Forms;

namespace Coco.UI
{
    public partial class UctDocumentElement : UserControl
    {
        public UctDocumentElement()
        {
            InitializeComponent();
        }

        public event OpenMeeting OnOpenMeetingEvent;

        private Meeting meeting;
        public Meeting Meeting
        {
            get { return meeting; }
            set
            {
                meeting = value;
                ShowMeeting();
            }
        }

        private void ShowMeeting()
        {
            if (meeting == null)
            {
                lblTitle.Text = "-";
                lblLastEdited.Text = "Bearbeitet: -";
                btnOpenMeeting.Enabled = false;
            }
            else
            {
                lblTitle.Text = (meeting.Date == default(DateTime)) ?
                    "-" : meeting.Date.ToString(CocoConstant.FormatMeetingDate);
                lblLastEdited.Text = (meeting.LastEdited == default(DateTime)) ?
                    "Bearbeitet: -" : string.Concat("Bearbeitet: ", meeting.LastEdited.ToShortDateString());
                btnOpenMeeting.Enabled = true;
            }
        }

        private void BtnOpenMeeting_Click(object sender, EventArgs e)
        {
            OnOpenMeetingEvent?.Invoke(this, new EventArgs());
        }
    }
}
