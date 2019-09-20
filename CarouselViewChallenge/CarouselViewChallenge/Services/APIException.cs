using System;
using System.Runtime.Serialization;

namespace CarouselViewChallenge.Services
{
    [Serializable]
    public class APIException : Exception
    {
        public int? StatusCode { get; }

        public APIException()
        {
        }

        public APIException(string message) : base(message)
        {
        }

        public APIException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected APIException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public APIException(string message, int? code) : base(message)
        {
            StatusCode = code;
        }

        public APIException(string message, Exception innerException, int? code) : base(message, innerException)
        {
            StatusCode = code;
        }
    }
}
