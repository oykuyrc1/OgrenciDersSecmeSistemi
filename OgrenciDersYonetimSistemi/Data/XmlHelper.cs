using System.IO;
using System.Xml.Serialization;

namespace OgrenciDersYonetimSistemi.Data
{
    public static class XmlHelper
    {
        public static void SerializeToXml<T>(T data, string filePath)
        {
            XmlSerializer serializer = new(typeof(T));
            using StreamWriter writer = new(filePath);
            serializer.Serialize(writer, data);
        }

        public static T DeserializeFromXml<T>(string filePath)
        {
            XmlSerializer serializer = new(typeof(T));
            using StreamReader reader = new(filePath);
            return (T)serializer.Deserialize(reader);
        }
    }
}
