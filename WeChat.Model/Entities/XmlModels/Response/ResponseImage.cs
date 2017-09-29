using System.Xml.Serialization;
using WeChat.Infrastructure.Constants;
using WeChat.Model.Entities.Data;

namespace WeChat.Model.Entities.XmlModels.Response
{
    [XmlRoot(ElementName = "xml")]
    public class ResponseImage : BaseMessage
    {
        public ResponseImage()
        {
            MsgType = ResponseType.Image.ToString().ToLower();
        }
        public ResponseImage(BaseMessage info) : this()
        {
            this.FromUserName = info.ToUserName;
            this.ToUserName = info.FromUserName;
        }
        public ImageEntity Image { get; set; }
        //public override string ToXml()
        //{
        //    CreateTime = DateTime.Now.ConvertToInt();//重新更新
        //    return this.SerializerToXml();
        //}
    }
}