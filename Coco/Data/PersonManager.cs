using Coco.Common;
using System;
using System.IO;

namespace Coco.Data
{
    public static class PersonManager
    {
        public static event SavePersons OnSavePersonsEvent;

        private static SerializableDictionary<string, Person> persons;
        public static SerializableDictionary<string, Person> Persons
        {
            get
            {
                if (persons == null)
                    LoadPersons();

                return persons;
            }
            set { persons = value; }
        }

        public static void LoadPersons()
        {
            if (File.Exists(CocoConstant.PersonsXmlFullPath))
            {
                Persons = Serializer.Deserialize<SerializableDictionary<string, Person>>(CocoConstant.PersonsXmlFullPath);
                return;
            }

            Persons = new SerializableDictionary<string, Person>();
        }

        public static void SavePersons()
        {
            Serializer.Serialize(CocoConstant.ConfigDirFullPath, CocoConstant.PersonsXmlFullPath, Persons);

            OnSavePersonsEvent?.Invoke(null, new EventArgs());
        }

        public static string GeneratePersonKey()
        {
            return DateTime.Now.ToString();
        }
    }
}
