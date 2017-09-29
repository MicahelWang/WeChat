using System.Xml.Serialization;
using WeChat.Infrastructure.Constants;
using WeChat.Model.Entities.Data;

namespace WeChat.Model.Entities.XmlModels.Response
{
    [XmlRoot(ElementName = "xml")]
    public class ResponseVideo : BaseMessage
    {
        public ResponseVideo()
        {
            MsgType = ResponseType.Video.ToString().ToLower();
        }

        public ResponseVideo(BaseMessage info) : this()
        {
            this.FromUserName = info.ToUserName;
            this.ToUserName = info.FromUserName;
        }


        public VideoEntity Video { get; set; }

        //public override string ToXml()
        //{
        //    this.CreateTime = DateTime.Now.ConvertToInt();//重新更新
        //    return this.SerializerToXml();
        //}
    }
}