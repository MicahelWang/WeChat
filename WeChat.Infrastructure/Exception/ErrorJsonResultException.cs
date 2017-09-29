using System;
using System.Runtime.Serialization;

namespace WeChat.Infrastructure.Exception
{
    [Serializable]
    public class ErrorJsonResultException : System.Exception
    {

        public string  Url { get; set; }        
        public ErrorJsonResultException()
        {
        }

        public ErrorJsonResultException(string message) : base(message)
        {
        }

        public ErrorJsonResultException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected ErrorJsonResultException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}