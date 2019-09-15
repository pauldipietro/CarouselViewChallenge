using System;
using System.Runtime.Serialization;

namespace CarouselViewChallenge.Services
{
    [Serializable]
    public class NoNetworkNoCacheException : Exception
    {
        public NoNetworkNoCacheException()
        {
        }

        public NoNetworkNoCacheException(string message) : base(message)
        {
        }

        public NoNetworkNoCacheException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoNetworkNoCacheException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
