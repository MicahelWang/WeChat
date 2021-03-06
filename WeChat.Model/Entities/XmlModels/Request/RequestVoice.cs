using System.Xml.Serialization;

namespace WeChat.Model.Entities.XmlModels.Request
{
    [XmlRoot(ElementName = "xml")]
    public class RequestVoice : RequestBaseMessage
    {
        public string MediaId { get; set; }
        public string Format { get; set; }

        public string Recognition { get; set; }
    }
}