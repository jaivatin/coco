using System.IO;
using System.Xml.Serialization;

namespace Coco.Common
{
    public static class Serializer
    {
        public static void Serialize(string fileFullPath, object o)
        {
            using (var writer = new StreamWriter(fileFullPath))
            {
                var serializer = new XmlSerializer(o.GetType());
                serializer.Serialize(writer, o);
            }
        }

        public static void Serialize(string dirFullPath, string fileFullPath, object o)
        {
            Directory.CreateDirectory(dirFullPath);
            Serialize(fileFullPath, o);
        }

        public static T Deserialize<T>(string fileFullPath)
        {
            object result = null;
            using (var reader = new StreamReader(fileFullPath))
            {
                var serializer = new XmlSerializer(typeof(T));
                result = serializer.Deserialize(reader);
            }
            return (T)result;
        }
    }
}
