using Coco.Common;
using Coco.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Coco.Common.CocoEnum;

namespace Coco.UI
{
    public partial class UctPerson : UserControl
    {
        private string showPersonKey;

        public UctPerson()
        {
            InitializeComponent();
            InitializeControl();
        }

        #region Private methods

        private void InitializeControl()
        {
            tvwPersons.Nodes.Add(CocoConstant.KeyPersons, "Personen");

            cmbPresets.Items.AddRange(new[]
            {
                "Keine Voreinstellung",
                Appointment.Publisher.GetDescription(),
                Appointment.MinisterialServant.GetDescription(),
                Appointment.Overseer.GetDescription()
            });

            UpdateTreeView();
            SwitchPersonVisible(false);
        }

        private void UpdateTreeView()
        {
            tvwPersons.Nodes[CocoConstant.KeyPersons].Nodes.Clear();
            foreach (KeyValuePair<string, Person> person in PersonManager.Persons)
            {
                tvwPersons.Nodes[CocoConstant.KeyPersons].Nodes.Add(new TreeNode()
                {
                    Tag = person.Key,
                    Text = string.Concat(person.Value.LastName, " ", person.Value.FirstName)
                });
            }

            tvwPersons.ExpandAll();
            tvwPersons.Sort();
        }

        private void SwitchPersonVisible(bool isVisible)
        {
            btnAdd.Enabled = !isVisible;

            cmbPresets.SelectedIndex = 0;
            cmbPresets.Visible = isVisible;

            btnSave.Visible = isVisible;
            btnCancel.Visible = isVisible;

            foreach (Control control in pnlPerson.Controls)
                control.Visible = isVisible;
        }

        private void AddPerson()
        {
            ShowPerson(null);
            SwitchPersonVisible(true);
        }

        private void EditPerson()
        {
            if (tvwPersons.SelectedNode == null ||
                tvwPersons.SelectedNode == tvwPersons.Nodes[CocoConstant.KeyPersons])
                return;

            var personKey = tvwPersons.SelectedNode.Tag as string;
            ShowPerson(personKey);
            SwitchPersonVisible(true);
        }

        private void RemovePerson()
        {
            if (tvwPersons.SelectedNode == null ||
                tvwPersons.SelectedNode == tvwPersons.Nodes[CocoConstant.KeyPersons])
                return;

            var personKey = tvwPersons.SelectedNode.Tag as string;

            if (!PersonManager.Persons.ContainsKey(personKey))
                return;

            PersonManager.Persons.Remove(personKey);
            PersonManager.SavePersons();
            UpdateTreeView();

            if (personKey == showPersonKey)
            {
                ShowPerson(null);
                SwitchPersonVisible(false);
            }
        }

        private void ShowPerson(string personKey)
        {
            if (personKey == null ||
                !PersonManager.Persons.ContainsKey(personKey))
            {
                showPersonKey = null;
                ClearPersonControls(true);
            }
            else
            {
                showPersonKey = personKey;

                Person person = PersonManager.Persons[showPersonKey];

                tbxFirstName.Text = person.FirstName;
                tbxLastName.Text = person.LastName;

                // Gender
                if (person.Gender == Gender.Female)
                    rbnIsFemale.Checked = true;
                else
                    rbnIsMale.Checked = true;

                // Appointment
                cbxIsMinisterialServant.Checked = person.Appointments[Appointment.MinisterialServant];
                cbxIsOverseer.Checked = person.Appointments[Appointment.Overseer];
                cbxIsPioneer.Checked = person.Appointments[Appointment.Pioneer];

                // Apply yourself to the field ministry
                cbxIsPartner.Checked = person.IsPartner;
                cbxIsBibleReading.Checked = person.Properties[MeetingElementKey.BibleReading];
                cbxIsInitialCall.Checked = person.Properties[MeetingElementKey.InitialCall];
                cbxIsFirstReturnVisit.Checked = person.Properties[MeetingElementKey.FirstReturnVisit];
                cbxIsSecondReturnVisit.Checked = person.Properties[MeetingElementKey.SecondReturnVisit];
                cbxIsThirdReturnVisit.Checked = person.Properties[MeetingElementKey.ThirdReturnVisit];
                cbxIsBibleStudy.Checked = person.Properties[MeetingElementKey.BibleStudy];
                cbxIsMidweekLecture.Checked = person.Properties[MeetingElementKey.MidweekLecture];

                // Service plan
                cbxIsPrayer.Checked = person.Properties[MeetingElementKey.Prayer1];
                cbxIsMicrophoneService.Checked = person.Properties[MeetingElementKey.MicrophoneService];
                cbxIsReading.Checked = person.Properties[MeetingElementKey.Reader];
                cbxIsSecurityService.Checked = person.Properties[MeetingElementKey.SecurityService];
                cbxIsSoundSystemService.Checked = person.Properties[MeetingElementKey.SoundSystemService];
                cbxIsStageService.Checked = person.Properties[MeetingElementKey.StageService];

                // Midweek
                cbxIsMidweekChairman.Checked = person.Properties[MeetingElementKey.MidweekChairman];
                cbxIsTreasuresFromGodsWord.Checked = person.Properties[MeetingElementKey.TreasuresFromGodsWord];
                cbxIsDiggingForSpiritualGems.Checked = person.Properties[MeetingElementKey.DiggingForSpiritualGems];
                cbxIsLivingAsChristians.Checked = person.Properties[MeetingElementKey.LivingAsChristians];
                cbxIsCongregationBibleStudy.Checked = person.Properties[MeetingElementKey.CongregationBibleStudy];

                // Weekend
                cbxIsWeekendChairman.Checked = person.Properties[MeetingElementKey.WeekendChairman];
                cbxIsWeekendLecture.Checked = person.Properties[MeetingElementKey.WeekendLecture];
                cbxIsWatchtowerStudy.Checked = person.Properties[MeetingElementKey.WatchtowerStudy];
            }
        }

        private void ClearPersonControls(bool withName)
        {
            if (withName)
            {
                tbxFirstName.Text = "";
                tbxLastName.Text = "";
            }

            foreach (var rbn in gbxGender.Controls.OfType<RadioButton>())
                rbn.Checked = false;
            foreach (var cbx in gbxAppointments.Controls.OfType<CheckBox>())
                cbx.Checked = false;
            foreach (var cbx in gbxApplyYourselfToTheFieldMinistry.Controls.OfType<CheckBox>())
                cbx.Checked = false;
            foreach (var cbx in gbxServicePlan.Controls.OfType<CheckBox>())
                cbx.Checked = false;
            foreach (var cbx in gbxMidweek.Controls.OfType<CheckBox>())
                cbx.Checked = false;
            foreach (var cbx in gbxWeekend.Controls.OfType<CheckBox>())
                cbx.Checked = false;
        }

        private void SavePerson(string personKey)
        {
            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;

            // Gender
            Gender gender = rbnIsFemale.Checked ? Gender.Female : Gender.Male;

            // Appointment
            var appointments = new SerializableDictionary<Appointment, bool>()
            {
                { Appointment.MinisterialServant, cbxIsMinisterialServant.Checked },
                { Appointment.Overseer, cbxIsOverseer.Checked },
                { Appointment.Pioneer, cbxIsPioneer.Checked }
            };

            // Apply yourself to the field ministry
            bool isPartner = cbxIsPartner.Checked;
            var properties = new SerializableDictionary<MeetingElementKey, bool>()
            {
                { MeetingElementKey.BibleReading, cbxIsBibleReading.Checked },
                { MeetingElementKey.InitialCall, cbxIsInitialCall.Checked },
                { MeetingElementKey.FirstReturnVisit, cbxIsFirstReturnVisit.Checked },
                { MeetingElementKey.SecondReturnVisit, cbxIsSecondReturnVisit.Checked },
                { MeetingElementKey.ThirdReturnVisit, cbxIsThirdReturnVisit.Checked },
                { MeetingElementKey.BibleStudy, cbxIsBibleStudy.Checked },
                { MeetingElementKey.MidweekLecture, cbxIsMidweekLecture.Checked },
                { MeetingElementKey.ApplyYourselfToTheFieldMinistry, cbxIsMidweekChairman.Checked },

                // Service plan
                { MeetingElementKey.Prayer1, cbxIsPrayer.Checked },
                { MeetingElementKey.Prayer2, cbxIsPrayer.Checked },
                { MeetingElementKey.MicrophoneService, cbxIsMicrophoneService.Checked },
                { MeetingElementKey.Reader, cbxIsReading.Checked },
                { MeetingElementKey.SecurityService, cbxIsSecurityService.Checked },
                { MeetingElementKey.SoundSystemService, cbxIsSoundSystemService.Checked },
                { MeetingElementKey.StageService, cbxIsStageService.Checked },

                // Midweek
                { MeetingElementKey.MidweekChairman, cbxIsMidweekChairman.Checked },
                { MeetingElementKey.OpeningComments, cbxIsMidweekChairman.Checked },
                { MeetingElementKey.TreasuresFromGodsWord, cbxIsTreasuresFromGodsWord.Checked },
                { MeetingElementKey.DiggingForSpiritualGems, cbxIsDiggingForSpiritualGems.Checked },
                { MeetingElementKey.LivingAsChristians, cbxIsLivingAsChristians.Checked },
                { MeetingElementKey.CongregationBibleStudy, cbxIsCongregationBibleStudy.Checked },
                { MeetingElementKey.ReviewPreviewAnnouncements, cbxIsMidweekChairman.Checked },

                // Weekend
                { MeetingElementKey.WeekendChairman, cbxIsWeekendChairman.Checked },
                { MeetingElementKey.WeekendLecture, cbxIsWeekendLecture.Checked },
                { MeetingElementKey.WatchtowerStudy, cbxIsWatchtowerStudy.Checked }
            };

            var person = new Person(personKey, firstName, lastName, gender, appointments, isPartner, properties);

            if (personKey == showPersonKey)
                PersonManager.Persons[personKey] = person;
            else
                PersonManager.Persons.Add(personKey, person);

            PersonManager.SavePersons();
            UpdateTreeView();

            ShowPerson(null);
            SwitchPersonVisible(false);
        }

        #endregion

        #region Events

        private void TvwPersons_Click(object sender, EventArgs e)
        {
            tvwPersons.SelectedNode = null;
        }

        private void TvwPersons_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvwPersons.SelectedNode = tvwPersons.GetNodeAt(e.X, e.Y);
                if (tvwPersons.SelectedNode != null)
                {
                    bool isRoot = tvwPersons.SelectedNode == tvwPersons.Nodes[CocoConstant.KeyPersons];
                    cmsPersonsEdit.Enabled = isRoot ? false : true;
                    cmsPersonsRemove.Enabled = isRoot ? false : true;

                    cmsPersons.Show(tvwPersons, e.Location);
                }
            }
        }

        private void TvwPersons_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            EditPerson();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            RemovePerson();
        }

        private void CmsPersonsAdd_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void CmsPersonsEdit_Click(object sender, EventArgs e)
        {
            EditPerson();
        }

        private void CmsPersonsRemove_Click(object sender, EventArgs e)
        {
            RemovePerson();
        }

        private void CmbPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPresets.SelectedIndex >= 0 &&
                cmbPresets.SelectedIndex <= 3)
                ClearPersonControls(false);

            // Publishers & ministerial servants
            if (cmbPresets.SelectedIndex == 1 ||
                cmbPresets.SelectedIndex == 2)
            {
                // Apply yourself to the field ministry
                cbxIsPartner.Checked = true;
                cbxIsBibleReading.Checked = true;
                cbxIsInitialCall.Checked = true;
                cbxIsFirstReturnVisit.Checked = true;
                cbxIsSecondReturnVisit.Checked = true;
                cbxIsThirdReturnVisit.Checked = true;
                cbxIsBibleStudy.Checked = true;
                cbxIsMidweekLecture.Checked = true;
            }

            // Ministerial servants
            if (cmbPresets.SelectedIndex == 2)
            {
                // Gender
                rbnIsMale.Checked = true;

                // Appointment
                cbxIsMinisterialServant.Checked = true;

                // Service plan
                cbxIsPrayer.Checked = true;
                cbxIsMicrophoneService.Checked = true;
                cbxIsReading.Checked = true;
                cbxIsSecurityService.Checked = true;
                cbxIsSoundSystemService.Checked = true;
                cbxIsStageService.Checked = true;
            }

            // Overseers
            if (cmbPresets.SelectedIndex == 3)
            {
                // Gender
                rbnIsMale.Checked = true;

                // Appointment
                cbxIsOverseer.Checked = true;

                // Service plan
                cbxIsPrayer.Checked = true;

                // Midweek
                cbxIsMidweekChairman.Checked = true;
                cbxIsTreasuresFromGodsWord.Checked = true;
                cbxIsDiggingForSpiritualGems.Checked = true;
                cbxIsLivingAsChristians.Checked = true;
                cbxIsCongregationBibleStudy.Checked = true;

                // Weekend
                cbxIsWeekendChairman.Checked = true;
                cbxIsWeekendLecture.Checked = true;
                cbxIsWatchtowerStudy.Checked = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SavePerson(showPersonKey == null ? PersonManager.GeneratePersonKey() : showPersonKey);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ShowPerson(null);
            SwitchPersonVisible(false);
        }

        #endregion
    }
}
