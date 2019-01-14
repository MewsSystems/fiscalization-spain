using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Mews.Fiscalization.Spain
{
    public class XmlManipulator
    {
        public static T Deserialize<T>(XmlElement xmlElement)
            where T : class, new()
        {
            using (var reader = new StringReader(xmlElement.OuterXml))
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                return xmlSerializer.Deserialize(reader) as T;
            }
        }

        public static XmlElement Serialize<T>(T value)
            where T : class
        {
            var xmlDocument = new XmlDocument();
            var navigator = xmlDocument.CreateNavigator();
            using (var writer = navigator.AppendChild())
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(writer, value);
            }
            return xmlDocument.DocumentElement;
        }
    }
}
