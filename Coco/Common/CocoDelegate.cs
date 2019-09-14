using Coco.UI;
using System;

namespace Coco.Common
{
    // Common
    public delegate void SaveControl(object sender, EventArgs e);
    public delegate void CancelControl(object sender, EventArgs e);

    // Persons
    public delegate void SavePersons(object sender, EventArgs e);

    // Documents
    public delegate void OpenMeeting(UctDocumentElement sender, EventArgs e);
    public delegate void EditPerson(UctMeetingElement sender, EditPersonEventArgs e);
    public delegate void SelectPerson(UctPersonTile sender, EventArgs e);

    // Event arguments
    public class EditPersonEventArgs
    {
        public EditPersonEventArgs(bool isPartner)
        {
            IsPartner = isPartner;
        }

        public bool IsPartner { get; private set; }
    }
}
