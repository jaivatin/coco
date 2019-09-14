using Coco.Common;
using Coco.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using static Coco.Common.CocoEnum;

namespace Coco.UI
{
    public partial class FrmCoco : Form
    {
        private FrmSettings frmSettings;

        public FrmCoco()
        {
            InitializeComponent();

            frmSettings = new FrmSettings();

            InitializeForm();
        }

        #region Private methods

        private void InitializeForm()
        {
            Text = string.Concat(Text, " Alpha ", Application.ProductVersion);

            tabMain.SelectedIndex = 1;

            UpdateCongregation();
            UpdatePersons();

            // Tab persons
            PersonManager.OnSavePersonsEvent += PersonManager_OnSavePersonsEvent;

            // Tab documents
            foreach (UctDocumentElement uctDocumentElement in uctDocument.CdeList)
                uctDocumentElement.OnOpenMeetingEvent += UctDocumentElement_OnOpenMeetingEvent;
        }

        private void UpdateCongregation()
        {
            // TODO: Update congregation...
        }

        private void UpdatePersons()
        {
            int ministerialServants = PersonManager.Persons.Count(x =>
                x.Value.Appointments[Appointment.MinisterialServant]);
            int overseers = PersonManager.Persons.Count(x =>
                x.Value.Appointments[Appointment.Overseer]);
            int pioneers = PersonManager.Persons.Count(x =>
                x.Value.Appointments[Appointment.Pioneer]);
            var space = "    ";

            lblPublishers.Text = string.Concat("Verkündiger: ", PersonManager.Persons.Count, space);
            lblMinisterialServants.Text = string.Concat("Dienstamtgehilfen: ", ministerialServants, space);
            lblOverseers.Text = string.Concat("Älteste: ", overseers, space);
            lblPioneers.Text = string.Concat("Pioniere: ", pioneers);
        }

        private void RemoveTabPage(string key)
        {
            if (tabMain.TabPages.ContainsKey(key))
            {
                tabMain.TabPages.RemoveByKey(key);
                tabMain.SelectedIndex = 1;
            }
        }

        #endregion

        #region Events

        private void PersonManager_OnSavePersonsEvent(object sender, EventArgs e)
        {
            UpdatePersons();
        }

        private void UctDocumentElement_OnOpenMeetingEvent(UctDocumentElement sender, EventArgs e)
        {
            // Initialize UctMeeting
            UctMeeting uctMeeting;
            if (sender.Meeting.GetType() == typeof(MeetingMidweek))
                uctMeeting = new UctMeetingMidweek() { Meeting = (MeetingMidweek)sender.Meeting };
            else
                uctMeeting = new UctMeetingWeekend() { Meeting = (MeetingWeekend)sender.Meeting };

            uctMeeting.Dock = DockStyle.Fill;
            uctMeeting.OnSaveControlEvent += UctMeeting_OnSaveControlEvent;
            uctMeeting.OnCancelControlEvent += UctMeeting_OnCancelControlEvent;

            // Initialize TabPage
            var tpMeeting = new TabPage()
            {
                BackColor = uctMeeting.BackColor,
                Name = uctMeeting.Meeting.Date.ToString(CocoConstant.FormatMeetingDate),
                Padding = new Padding(3, 3, 3, 3),
                Text = uctMeeting.Meeting.Date.ToString(CocoConstant.FormatMeetingDate)
            };
            tpMeeting.Controls.Add(uctMeeting);

            tabMain.TabPages.Add(tpMeeting);
        }

        private void UctMeeting_OnSaveControlEvent(object sender, EventArgs e)
        {
            var uctMeeting = sender as UctMeeting;
            if (uctMeeting == null || uctMeeting.Meeting == null)
                return;

            uctDocument.SaveMeeting(uctMeeting.Meeting);
            RemoveTabPage(uctMeeting.Meeting.Date.ToString(CocoConstant.FormatMeetingDate));
        }

        private void UctMeeting_OnCancelControlEvent(object sender, EventArgs e)
        {
            var uctMeeting = sender as UctMeeting;
            if (uctMeeting == null || uctMeeting.Meeting == null)
                return;

            RemoveTabPage(uctMeeting.Meeting.Date.ToString(CocoConstant.FormatMeetingDate));
        }

        private void MIExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MISwitchCongregation_Click(object sender, EventArgs e)
        {
            UpdateCongregation();
            MessageBox.Show("Not yet implemented.", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MIShowSettings_Click(object sender, EventArgs e)
        {
            frmSettings.ShowSettings();
            if (frmSettings.ShowDialog() == DialogResult.OK)
            {
                // TODO: Apply settings (nothing to do here yet)
            }
        }

        #endregion
    }
}
