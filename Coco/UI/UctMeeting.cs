using Coco.Common;
using Coco.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Coco.Common.CocoEnum;

namespace Coco.UI
{
    public partial class UctMeeting : UserControl
    {
        private const int widthHack = 25;

        private Allocator allocator;

        private Panel currentPnl;
        private UctMeetingElement currentCme;

        public UctMeeting()
        {
            InitializeComponent();

            allocator = new Allocator();
            CmeList = new List<UctMeetingElement>();
        }

        public event SaveControl OnSaveControlEvent;
        public event CancelControl OnCancelControlEvent;

        private Meeting meeting;
        public Meeting Meeting
        {
            get { return meeting; }
            set
            {
                meeting = value;
                if (meeting != null)
                {
                    SetMeetingElements();
                    ShowMeetingElements();
                }
            }
        }

        protected List<UctMeetingElement> CmeList { get; set; }

        protected virtual void SetMeetingElements()
        {
        }

        private void ShowMeetingElements()
        {
            foreach (UctMeetingElement cme in CmeList)
            {
                if (cme.MeetingElement == null)
                {
                    // Hide unneeded controls
                    cme.Visible = false;
                }
                else
                    cme.ShowMeetingElement();
            }
        }

        private void SaveMeeting()
        {
            foreach (UctMeetingElement cme in CmeList)
                cme.SaveMeetingElement();

            meeting.LastEdited = DateTime.Now;
        }

        private void UpdatePanelPersonTiles(List<UctPersonTile> cpts)
        {
            flpPersonTiles.Controls.Clear();

            // HACK: Add a most upper panel in the flow layout panel for docking
            currentPnl = new Panel()
            {
                Margin = new Padding(3, 0, 3, 0),
                Size = new Size(flpPersonTiles.Width - widthHack, 3)
            };
            flpPersonTiles.Controls.Add(currentPnl);

            foreach (UctPersonTile uctPersonTile in cpts)
            {
                uctPersonTile.OnSelectPersonEvent += UctPersonTile_OnSelectPersonEvent;
                flpPersonTiles.Controls.Add(uctPersonTile);
            }
        }

        #region Events

        protected void UctMeetingElement_OnEditPersonEvent(UctMeetingElement sender, EditPersonEventArgs e)
        {
            currentCme = sender;
            if (!e.IsPartner)
            {
                List<UctPersonTile> cpts = allocator.SortPersons(currentCme.MeetingElement.Start,
                    new List<MeetingElementKey>() { currentCme.MeetingElement.Key });
                UpdatePanelPersonTiles(cpts);
            }
            else
            {
                List<UctPersonTile> cpts = allocator.SortPartners(currentCme.MeetingElement.Start);
                UpdatePanelPersonTiles(cpts);
            }
        }

        private void UctPersonTile_OnSelectPersonEvent(UctPersonTile sender, EventArgs e)
        {
            if (currentCme == null ||
                currentCme.MeetingElement == null ||
                sender == null ||
                sender.Person == null)
                return;

            if (!sender.IsPartner)
                currentCme.MeetingElement.PersonKey = sender.Person.Key;
            else
                currentCme.MeetingElement.PartnerKey = sender.Person.Key;

            currentCme.ShowMeetingElement();
            flpPersonTiles.Controls.Clear();
        }

        private void FlpPersonTiles_Layout(object sender, LayoutEventArgs e)
        {
            // HACK: Adjust the most upper panel in the flow layout panel accordingly for docking
            if (currentPnl != null)
                currentPnl.Width = flpPersonTiles.Width - widthHack;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveMeeting();
            OnSaveControlEvent?.Invoke(this, new EventArgs());
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            OnCancelControlEvent?.Invoke(this, new EventArgs());
        }

        #endregion
    }
}
