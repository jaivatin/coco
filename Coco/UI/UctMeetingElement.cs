using Coco.Common;
using Coco.Data;
using System;
using System.Windows.Forms;

namespace Coco.UI
{
    public partial class UctMeetingElement : UserControl
    {
        public UctMeetingElement()
        {
            InitializeComponent();
            InitializeControl();
        }

        public event EditPerson OnEditPersonEvent;

        public MeetingElement MeetingElement { get; set; }

        private int number;
        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                miCmeNumber.Text = string.Concat(number.ToString(), ".");
            }
        }

        public bool IsStartUpToDurationVisible
        {
            get { return dtpStart.Visible && cbxIsUpTo.Visible && nudDuration.Visible; }
            set
            {
                dtpStart.Visible = value;
                cbxIsUpTo.Visible = value;
                nudDuration.Visible = value;
            }
        }

        public bool IsComboBoxTitleVisible
        {
            get { return cmbTitle.Visible; }
            set
            {
                cmbTitle.Visible = value;
                tbxTitle.Visible = !value;
            }
        }

        public bool IsTextBoxTitleVisible
        {
            get { return tbxTitle.Visible; }
            set
            {
                tbxTitle.Visible = value;
                cmbTitle.Visible = !value;
            }
        }

        public bool IsPersonVisible
        {
            get { return tbxPerson.Visible && btnEditPerson.Visible; }
            set
            {
                tbxPerson.Visible = value;
                btnEditPerson.Visible = value;
            }
        }

        public bool IsPartnerVisible
        {
            get { return tbxPartner.Visible && btnEditPartner.Visible; }
            set
            {
                tbxPartner.Visible = value;
                btnEditPartner.Visible = value;
            }
        }

        #region Public methods

        public void ShowMeetingElement()
        {
            if (MeetingElement == null)
                return;

            if (IsStartUpToDurationVisible)
                ShowStartUpToDuration();

            ShowTitle();

            if (IsPersonVisible)
                ShowPerson();

            if (IsPartnerVisible)
                ShowPartner();
        }

        public void SaveMeetingElement()
        {
            if (MeetingElement == null)
                return;

            if (IsStartUpToDurationVisible)
                SaveStartUpToDuration();

            SaveTitle();

            if (IsPersonVisible)
                SavePerson();

            if (IsPartnerVisible)
                SavePartner();
        }

        #endregion

        #region Private methods

        private void InitializeControl()
        {
            cmbTitle.Items.AddRange(SettingsManager.Settings.Songs.ToArray());
            cmbTitle.SelectedIndex = 0;
            cmbTitle.MouseWheel += CmbTitle_MouseWheel;
        }

        private void ShowStartUpToDuration()
        {
            dtpStart.Value = MeetingElement.Start;
            cbxIsUpTo.Checked = MeetingElement.IsUpTo;
            nudDuration.Value = MeetingElement.Duration;
        }

        private void ShowTitle()
        {
            if (MeetingElement.Title != default(string))
            {
                if (IsComboBoxTitleVisible)
                {
                    // Only use the number
                    string number = MeetingElement.Title.Split(CocoConstant.SeparatorSong)[0];
                    cmbTitle.SelectedIndex = cmbTitle.FindString(number);
                }
                else
                    tbxTitle.Text = MeetingElement.Title;
            }
        }

        private void ShowPerson()
        {
            if (MeetingElement.PersonKey == null)
                tbxPerson.Text = "-";
            else
            {
                Person person = PersonManager.Persons[MeetingElement.PersonKey];
                tbxPerson.Tag = person;
                tbxPerson.Text = person.ToString();
            }
        }

        private void ShowPartner()
        {
            if (MeetingElement.PartnerKey == null)
                tbxPartner.Text = "-";
            else
            {
                Person partner = PersonManager.Persons[MeetingElement.PartnerKey];
                tbxPartner.Tag = partner;
                tbxPartner.Text = partner.ToString();
            }
        }

        private void SaveStartUpToDuration()
        {
            MeetingElement.Start = dtpStart.Value;
            MeetingElement.IsUpTo = cbxIsUpTo.Checked;
            MeetingElement.Duration = nudDuration.Value;
        }

        private void SaveTitle()
        {
            if (IsComboBoxTitleVisible)
                MeetingElement.Title = cmbTitle.SelectedItem.ToString();
            else
                MeetingElement.Title = tbxTitle.Text;
        }

        private void SavePerson()
        {
            if ((tbxPerson.Tag as Person) == null)
                MeetingElement.PersonKey = null;
            else
                MeetingElement.PersonKey = (tbxPerson.Tag as Person).Key;
        }

        private void SavePartner()
        {
            if ((tbxPartner.Tag as Person) == null)
                MeetingElement.PartnerKey = null;
            else
                MeetingElement.PartnerKey = (tbxPartner.Tag as Person).Key;
        }

        #endregion

        #region Events

        private void UctMeetingElement_Load(object sender, EventArgs e)
        {
            // ToolTips
            var toolTip = new ToolTip();
            if (IsStartUpToDurationVisible)
            {
                toolTip.SetToolTip(dtpStart, "Startuhrzeit");
                toolTip.SetToolTip(cbxIsUpTo, "Dauer \"bis zu\"");
                toolTip.SetToolTip(nudDuration, "Dauer [min]");
            }

            if (IsComboBoxTitleVisible)
                toolTip.SetToolTip(cmbTitle, "Titel");

            if (IsTextBoxTitleVisible)
                toolTip.SetToolTip(tbxTitle, "Titel");

            if (IsPersonVisible)
                toolTip.SetToolTip(tbxPerson, "Person");

            if (IsPartnerVisible)
                toolTip.SetToolTip(tbxPartner, "Partner");
        }

        private void MICmeAddAbove_Click(object sender, EventArgs e)
        {
            // TODO
            MessageBox.Show("Not yet implemented.", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MICmeAddBelow_Click(object sender, EventArgs e)
        {
            // TODO
            MessageBox.Show("Not yet implemented.", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MICmeRemove_Click(object sender, EventArgs e)
        {
            // TODO
            MessageBox.Show("Not yet implemented.", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmbTitle_MouseWheel(object sender, MouseEventArgs e)
        {
            var cmb = (ComboBox)sender;
            if (!cmb.DroppedDown)
                ((HandledMouseEventArgs)e).Handled = true;
        }

        private void BtnEditPerson_Click(object sender, EventArgs e)
        {
            OnEditPersonEvent?.Invoke(this, new EditPersonEventArgs(false));
        }

        private void BtnEditPartner_Click(object sender, EventArgs e)
        {
            OnEditPersonEvent?.Invoke(this, new EditPersonEventArgs(true));
        }

        #endregion
    }
}
