using Coco.Common;
using System.IO;

namespace Coco.Data
{
    public static class DocumentManager
    {
        private static SerializableDictionary<string, Document> documents;
        public static SerializableDictionary<string, Document> Documents
        {
            get
            {
                if (documents == null)
                    LoadDocuments();

                return documents;
            }
            set { documents = value; }
        }

        public static void LoadDocuments()
        {
            if (File.Exists(CocoConstant.DocumentsXmlFullPath))
            {
                Documents = Serializer.Deserialize<SerializableDictionary<string, Document>>(CocoConstant.DocumentsXmlFullPath);
                return;
            }

            Documents = new SerializableDictionary<string, Document>();
        }

        public static void SaveDocuments()
        {
            Serializer.Serialize(CocoConstant.ConfigDirFullPath, CocoConstant.DocumentsXmlFullPath, Documents);
        }

        public static string GenerateDocumentKey(int year, int month)
        {
            return string.Concat(year, month);
        }
    }
}
