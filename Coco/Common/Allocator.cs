using Coco.Data;
using Coco.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using static Coco.Common.CocoEnum;

namespace Coco.Common
{
    public class Allocator
    {
        public Allocator()
        {
        }

        public List<UctPersonTile> SortPersons(DateTime dateTime, List<MeetingElementKey> properties)
        {
            var cpts = new List<UctPersonTile>();

            var possiblePersons =
                from x in PersonManager.Persons
                where properties.Any(y => x.Value.Properties[y])
                orderby x.Value.LastName descending
                select x;

            List<MeetingElement> sortedMeetingElements = SortMeetingElements(dateTime, properties);
            foreach (MeetingElement meetingElement in sortedMeetingElements)
            {
                UctPersonTile uctPersonTile = cpts.Find(x => x.Person.Key == meetingElement.PersonKey);
                if (uctPersonTile == null)
                {
                    // Insert possible persons allocated in the past
                    Person person = PersonManager.Persons[meetingElement.PersonKey];
                    uctPersonTile = new UctPersonTile(person, false);
                    uctPersonTile.AddAllocation(meetingElement);

                    cpts.Insert(0, uctPersonTile);
                }
                else
                {
                    // Skip already inserted persons
                    uctPersonTile.AddAllocation(meetingElement);
                }
            }

            foreach (KeyValuePair<string, Person> person in possiblePersons)
            {
                // Skip already inserted persons
                if (cpts.Any(x => x.Person.Key == person.Key))
                    continue;

                // Insert possible persons allocated never before
                var uctPersonTile = new UctPersonTile(person.Value, false);
                cpts.Insert(0, uctPersonTile);
            }

            return cpts;
        }

        public List<UctPersonTile> SortPartners(DateTime dateTime)
        {
            var cpts = new List<UctPersonTile>();

            var possiblePartners =
                from x in PersonManager.Persons
                where x.Value.IsPartner
                orderby x.Value.LastName descending
                select x;

            List<MeetingElement> sortedMeetingElements = SortMeetingElements(dateTime);
            foreach (MeetingElement meetingElement in sortedMeetingElements)
            {
                UctPersonTile uctPartnerTile = cpts.Find(x => x.Person.Key == meetingElement.PartnerKey);
                if (uctPartnerTile == null)
                {
                    // Insert possible partners allocated in the past
                    Person partner = PersonManager.Persons[meetingElement.PartnerKey];
                    uctPartnerTile = new UctPersonTile(partner, true);
                    uctPartnerTile.AddAllocation(meetingElement);

                    cpts.Insert(0, uctPartnerTile);
                }
                else
                {
                    // Skip already inserted partners
                    uctPartnerTile.AddAllocation(meetingElement);
                }
            }

            foreach (KeyValuePair<string, Person> partner in possiblePartners)
            {
                // Skip already inserted partners
                if (cpts.Any(x => x.Person.Key == partner.Key))
                    continue;

                // Insert possible partners allocated never before
                var uctPartnerTile = new UctPersonTile(partner.Value, true);
                cpts.Insert(0, uctPartnerTile);
            }

            return cpts;
        }

        private List<MeetingElement> SortMeetingElements(DateTime dateTime, List<MeetingElementKey> meetingElementKeys = null)
        {
            var result = new List<MeetingElement>();

            List<Meeting> sortedMeetings = SortMeetings(dateTime);
            foreach (Meeting meeting in sortedMeetings)
            {
                if (meetingElementKeys != null)
                {
                    // Sort for persons
                    var meetingElementsWithPersons =
                        from x in meeting.MeetingElements
                        where meetingElementKeys.Contains(x.Key) && x.PersonKey != null
                        select x;
                    result.AddRange(meetingElementsWithPersons);
                }
                else
                {
                    // Sort for partners
                    var meetingElementsWithPartners =
                        from x in meeting.MeetingElements
                        where x.PartnerKey != null
                        select x;
                    result.AddRange(meetingElementsWithPartners);
                }
            }

            // Sort from new to old
            result.Sort((x, y) => y.Start.CompareTo(x.Start));
            return result;
        }

        private List<Meeting> SortMeetings(DateTime dateTime)
        {
            var result = new List<Meeting>();

            var documents =
                from x in DocumentManager.Documents
                where x.Value.Year <= dateTime.Year && x.Value.Month <= dateTime.Month
                select x;
            foreach (KeyValuePair<string, Document> document in documents)
            {
                var meetings =
                    from x in document.Value.Meetings
                    where x.Date <= dateTime
                    select x;
                result.AddRange(meetings);
            }

            return result;
        }
    }
}
