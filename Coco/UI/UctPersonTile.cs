using Coco.Common;
using Coco.Data;
using System;
using System.Windows.Forms;

namespace Coco.UI
{
    public partial class UctPersonTile : UserControl
    {
        private string[] allocations;

        public UctPersonTile()
        {
            InitializeComponent();

            allocations = new string[5];

            Dock = DockStyle.Top;
            Margin = new Padding(3, 0, 3, 3);
        }

        public UctPersonTile(Person person, bool isPartner)
            : this()
        {
            Person = person;
            IsPartner = isPartner;
        }

        public event SelectPerson OnSelectPersonEvent;

        private Person person;
        public Person Person
        {
            get { return person; }
            set
            {
                person = value;
                lblName.Text = person.ToString();
            }
        }

        public bool IsPartner { get; set; }

        public void AddAllocation(MeetingElement meetingElement)
        {
            int i = Array.FindIndex(allocations, x => string.IsNullOrEmpty(x));
            if (i >= 0)
                allocations[i] = string.Concat(meetingElement.Start.ToString("yyyy-MM-dd"), " - ", meetingElement.Title);
        }

        #region Events

        private void UctPersonTile_Load(object sender, EventArgs e)
        {
            tbxAllocations.Text = "";

            for (int i = 0; i < allocations.Length; i++)
            {
                string allocation = allocations[i];
                tbxAllocations.Text += string.IsNullOrEmpty(allocation) ? "-" : allocation;

                if (i < allocations.Length - 1)
                    tbxAllocations.Text += Environment.NewLine;
            }
        }

        private void LblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnSelectPersonEvent?.Invoke(this, new EventArgs());
        }

        #endregion
    }
}
