using System.Xml.Serialization;
using WeChat.Core.XmlModels;

namespace WeChat.Model.Entities.XmlModels.Request
{
    [XmlRoot(ElementName = "xml")]
    public class RequestBaseMessage: BaseMessage
    {
        public long MsgId { get; set; }
    }
}