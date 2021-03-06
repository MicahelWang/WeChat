﻿using System.Xml.Serialization;

namespace WeChat.Model.Entities.XmlModels.Request
{
    [XmlRoot(ElementName = "xml")]
    public class RequestImage : RequestBaseMessage
    {
        public string PicUrl { get; set; }
        public string MediaId { get; set; }
    }
}