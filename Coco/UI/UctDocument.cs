using ClosedXML.Excel;
using Coco.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Coco.UI
{
    public partial class UctDocument : UserControl
    {
        private string currentDocumentKey;

        public UctDocument()
        {
            InitializeComponent();

            CdeList = new List<UctDocumentElement>();
            CdeList.Add(cdeMidweek1);
            CdeList.Add(cdeWeekend1);
            CdeList.Add(cdeMidweek2);
            CdeList.Add(cdeWeekend2);
            CdeList.Add(cdeMidweek3);
            CdeList.Add(cdeWeekend3);
            CdeList.Add(cdeMidweek4);
            CdeList.Add(cdeWeekend4);
            CdeList.Add(cdeMidweek5);
            CdeList.Add(cdeWeekend5);

            InitializeControl();
        }

        public List<UctDocumentElement> CdeList { get; private set; }

        public void SaveMeeting(Meeting meeting)
        {
            int index;
            if (CdeList.Any(x => x.Meeting.Date == meeting.Date))
            {
                index = CdeList.FindIndex(x => x.Meeting.Date == meeting.Date);
                CdeList[index].Meeting = meeting;
            }
            if (DocumentManager.Documents[currentDocumentKey].Meetings.Any(x => x.Date == meeting.Date))
            {
                index = DocumentManager.Documents[currentDocumentKey].Meetings.FindIndex(x => x.Date == meeting.Date);
                DocumentManager.Documents[currentDocumentKey].Meetings[index] = meeting;
            }
            DocumentManager.SaveDocuments();
        }

        #region Private methods

        private void InitializeControl()
        {
            string[] years = Enumerable.Range(2017, DateTime.Now.Year - 2015).Select(x => x.ToString()).ToArray();
            cmbYear.DataSource = years;
            cmbYear.SelectedIndex = cmbYear.Items.Count - 2;

            string[] months = CultureInfo.CurrentUICulture.DateTimeFormat.MonthNames.Take(12).ToArray();
            cmbMonth.DataSource = months;
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void ShowDocument()
        {
            int year = Convert.ToInt32(cmbYear.Items[cmbYear.SelectedIndex]);
            int month = DateTime.ParseExact((string)cmbMonth.Items[cmbMonth.SelectedIndex],
                "MMMM", CultureInfo.CurrentUICulture).Month;

            currentDocumentKey = DocumentManager.GenerateDocumentKey(year, month);

            Document document;
            if (DocumentManager.Documents.ContainsKey(currentDocumentKey))
                document = DocumentManager.Documents[currentDocumentKey];
            else
            {
                document = CreateDocument(year, month);
                DocumentManager.Documents.Add(currentDocumentKey, document);
            }

            if (document.Meetings.Count > 0)
            {
                for (int i = 0; i < CdeList.Count; i++)
                    CdeList[i].Meeting = document.Meetings.ElementAtOrDefault(i);
            }
            else
            {
                foreach (UctDocumentElement cde in CdeList)
                    cde.Meeting = null;
            }
        }

        private Document CreateDocument(int year, int month)
        {
            var document = new Document(year, month);

            var date = new DateTime(document.Year, document.Month, 1);
            while (date < new DateTime(document.Year, document.Month, DateTime.DaysInMonth(document.Year, document.Month)))
            {
                if (date.DayOfWeek == SettingsManager.Settings.DayMeetingMidweek.Value)
                {
                    // Set the correct time for midweek meetings
                    date = date.Date + SettingsManager.Settings.TimeMeetingMidweek.TimeOfDay;
                    document.Meetings.Add(new MeetingMidweek(date));
                }
                else if (date.DayOfWeek == SettingsManager.Settings.DayMeetingWeekend.Value && document.Meetings.Count > 0)
                {
                    // Set the correct time for weekend meetings
                    date = date.Date + SettingsManager.Settings.TimeMeetingWeekend.TimeOfDay;
                    document.Meetings.Add(new MeetingWeekend(date));
                }

                date = date.AddDays(1);
            }

            while (document.Meetings.Last().GetType() == typeof(MeetingMidweek))
            {
                if (date.DayOfWeek == SettingsManager.Settings.DayMeetingWeekend.Value)
                {
                    // Set the correct time for weekend meetings
                    date = date.Date + SettingsManager.Settings.TimeMeetingWeekend.TimeOfDay;
                    document.Meetings.Add(new MeetingWeekend(date));
                }

                date = date.AddDays(1);
            }

            return document;
        }

        #endregion

        #region Events

        private void CmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex >= 0 && cmbMonth.SelectedIndex >= 0)
                ShowDocument();
        }

        private void CmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex >= 0 && cmbMonth.SelectedIndex >= 0)
                ShowDocument();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            // TODO: Import data...
            MessageBox.Show("Not yet implemented.", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            // TODO: Export data with ClosedXML

            var wb = new XLWorkbook(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Test.xlsx"));
            IXLWorksheet ws;
            wb.TryGetWorksheet("Tabelle1", out ws);
            ws.Cell(1, 1).Value = "Krobylos";
            wb.Save();
        }

        #endregion
    }
}
