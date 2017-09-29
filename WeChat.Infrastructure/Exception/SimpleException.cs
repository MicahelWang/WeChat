using System;

namespace WeChat.Infrastructure.Exception
{
    [Serializable]
    public class SimpleException : System.Exception
    {
        public int ErrorCode { get; set; }

        public SimpleException() : this(-10000)
        {
        }

        public SimpleException(int errorCode) : this(errorCode, "不明确的异常")
        {

        }

        public SimpleException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        public SimpleException(System.Exception inner) : this(inner.Message, inner)
        {
        }

        public SimpleException(string message, System.Exception inner) : this(-10000, message, inner)
        {
        }
        public SimpleException(int errorCode, string message, System.Exception inner) : base(message, inner)
        {
            ErrorCode = errorCode;
        }
    }
}