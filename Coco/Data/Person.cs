using Coco.Common;
using static Coco.Common.CocoEnum;

namespace Coco.Data
{
    public class Person
    {
        /// <summary>
        /// Parameterless constructor needed for XML serialization. Must be empty.
        /// </summary>
        private Person()
        {
        }

        public Person(
            string key,
            string firstName,
            string lastName,
            Gender gender,
            SerializableDictionary<Appointment, bool> appointments,
            bool isPartner,
            SerializableDictionary<MeetingElementKey, bool> properties)
        {
            Key = key;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Appointments = appointments;
            IsPartner = isPartner;
            Properties = properties;
        }

        public string Key { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public SerializableDictionary<Appointment, bool> Appointments { get; set; }
        public bool IsPartner { get; set; }
        public SerializableDictionary<MeetingElementKey, bool> Properties { get; set; }

        public override string ToString()
        {
            return string.Concat(FirstName, " ", LastName);
        }
    }
}
