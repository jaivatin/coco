using Coco.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Coco.UI
{
    public partial class FrmSettings : Form
    {
        private List<Song> songs;

        public FrmSettings()
        {
            InitializeComponent();
            InitializeForm();
        }

        public Settings Settings { get; private set; }

        #region Public methods

        public void ShowSettings(bool showDefault = false)
        {
            if (showDefault)
                SettingsManager.LoadSettings(true);
            else
                SettingsManager.LoadSettings();

            tabMain.SelectedIndex = 0;

            // General
            cmbMeetingMidweek.SelectedIndex = cmbMeetingMidweek.FindStringExact(
                SettingsManager.Settings.DayMeetingMidweek.ToString());
            cmbMeetingWeekend.SelectedIndex = cmbMeetingWeekend.FindStringExact(
                SettingsManager.Settings.DayMeetingWeekend.ToString());
            dtpMeetingMidweek.Value = SettingsManager.Settings.TimeMeetingMidweek;
            dtpMeetingWeekend.Value = SettingsManager.Settings.TimeMeetingWeekend;

            // Songs
            songs = SettingsManager.Settings.Songs.ToList();
            SortAndUpdateListBoxSongs();
            //nudSongNumber.ResetText();
            //tbxSongName.ResetText();
        }

        #endregion

        #region Private methods

        private void InitializeForm()
        {
            cmbMeetingMidweek.Items.AddRange(new[]
            {
                new CocoDay(DayOfWeek.Monday),
                new CocoDay(DayOfWeek.Tuesday),
                new CocoDay(DayOfWeek.Wednesday),
                new CocoDay(DayOfWeek.Thursday),
                new CocoDay(DayOfWeek.Friday)
            });
            cmbMeetingWeekend.Items.AddRange(new[]
            {
                new CocoDay(DayOfWeek.Saturday),
                new CocoDay(DayOfWeek.Sunday)
            });

            cmbMeetingMidweek.SelectedIndex = 0;
            cmbMeetingWeekend.SelectedIndex = 0;
        }

        private void SortAndUpdateListBoxSongs()
        {
            songs = songs.OrderBy(x => x.Number).ToList();
            lstSongs.DataSource = songs;
        }

        private void SaveSettings()
        {
            // General
            SettingsManager.Settings.DayMeetingMidweek = cmbMeetingMidweek.SelectedItem as CocoDay;
            SettingsManager.Settings.DayMeetingWeekend = cmbMeetingWeekend.SelectedItem as CocoDay;
            SettingsManager.Settings.TimeMeetingMidweek = dtpMeetingMidweek.Value;
            SettingsManager.Settings.TimeMeetingWeekend = dtpMeetingWeekend.Value;

            // Songs
            SettingsManager.Settings.Songs = songs.ToList();

            SettingsManager.SaveSettings();
        }

        #endregion

        #region Events

        private void LstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstSongs.SelectedIndex;
            if (index < 0 || index >= songs.Count)
                return;

            Song song = songs[index];

            // Call the up button to show the value properly
            nudSongNumber.UpButton();
            nudSongNumber.Value = song.Number;
            tbxSongName.Text = song.Name;
        }

        private void BtnSongUpdate_Click(object sender, EventArgs e)
        {
            int index = lstSongs.SelectedIndex;
            if (index < 0 || index >= songs.Count)
                return;

            Song song = songs[index];

            var number = (int)nudSongNumber.Value;
            if (songs.Any(x => x.Number == number) && number != song.Number)
            {
                string m = string.Concat("Das Lied mit der Nummer ", number, " existiert bereits!");
                MessageBox.Show(m, "Aktion nicht möglich!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            song.Number = number;
            song.Name = tbxSongName.Text.Trim();
            SortAndUpdateListBoxSongs();
        }

        private void BtnSongAdd_Click(object sender, System.EventArgs e)
        {
            var number = (int)nudSongNumber.Value;
            if (songs.Any(x => x.Number == number))
            {
                string m = string.Concat("Das Lied mit der Nummer ", number, " existiert bereits!");
                MessageBox.Show(m, "Aktion nicht möglich!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            string name = tbxSongName.Text.Trim();

            songs.Add(new Song(number, name));
            SortAndUpdateListBoxSongs();
        }

        private void BtnSongRemove_Click(object sender, System.EventArgs e)
        {
            int index = lstSongs.SelectedIndex;
            if (index < 0 || index >= songs.Count)
                return;

            songs.RemoveAt(index);
            SortAndUpdateListBoxSongs();
        }

        private void BtnReset_Click(object sender, System.EventArgs e)
        {
            ShowSettings(true);
        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {
            SaveSettings();
        }

        #endregion
    }
}
