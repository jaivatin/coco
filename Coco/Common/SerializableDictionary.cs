using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Coco.Common
{
    [Serializable]
    [XmlRoot("Dictionary")]
    public class SerializableDictionary<TKey, TValue>
        : Dictionary<TKey, TValue>, IXmlSerializable
    {
        private const string defaultTagItem = "Item";
        private const string defaultTagKey = "Key";
        private const string defaultTagValue = "Value";
        private static readonly XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
        private static readonly XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

        public SerializableDictionary()
            : base()
        {
        }

        protected SerializableDictionary(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        protected virtual string ItemTagName
        {
            get { return defaultTagItem; }
        }

        protected virtual string KeyTagName
        {
            get { return defaultTagKey; }
        }

        protected virtual string ValueTagName
        {
            get { return defaultTagValue; }
        }

        #region IXmlSerializable

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            bool wasEmpty = reader.IsEmptyElement;

            reader.Read();

            if (wasEmpty)
                return;

            try
            {
                while (reader.NodeType != XmlNodeType.EndElement)
                {
                    reader.ReadStartElement(ItemTagName);
                    try
                    {
                        TKey tKey;
                        TValue tValue;

                        reader.ReadStartElement(KeyTagName);
                        try
                        {
                            tKey = (TKey)keySerializer.Deserialize(reader);
                        }
                        finally
                        {
                            reader.ReadEndElement();
                        }

                        reader.ReadStartElement(ValueTagName);
                        try
                        {
                            tValue = (TValue)valueSerializer.Deserialize(reader);
                        }
                        finally
                        {
                            reader.ReadEndElement();
                        }

                        Add(tKey, tValue);
                    }
                    finally
                    {
                        reader.ReadEndElement();
                    }

                    reader.MoveToContent();
                }
            }
            finally
            {
                reader.ReadEndElement();
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            foreach (KeyValuePair<TKey, TValue> keyValuePair in this)
            {
                writer.WriteStartElement(ItemTagName);
                try
                {
                    writer.WriteStartElement(KeyTagName);
                    try
                    {
                        keySerializer.Serialize(writer, keyValuePair.Key);
                    }
                    finally
                    {
                        writer.WriteEndElement();
                    }

                    writer.WriteStartElement(ValueTagName);
                    try
                    {
                        valueSerializer.Serialize(writer, keyValuePair.Value);
                    }
                    finally
                    {
                        writer.WriteEndElement();
                    }
                }
                finally
                {
                    writer.WriteEndElement();
                }
            }
        }

        #endregion
    }
}
