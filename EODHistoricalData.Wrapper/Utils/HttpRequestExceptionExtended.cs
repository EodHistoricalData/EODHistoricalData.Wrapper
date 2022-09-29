using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace EODHistoricalData.Wrapper.Utils
{
    /// <summary>
    /// Custom class for exceptions thrown in BaseAPI
    /// </summary>
    public class HttpRequestExceptionExtended : HttpRequestException
    {
        /// <summary>
        /// Initializes a new instance of the HttpRequestExceptionExtended class with a specific message that describes the current exception and HTTP status code.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="statusCode"></param>
        public HttpRequestExceptionExtended(string message, HttpStatusCode? statusCode) : base(message)
        {
            StatusCode = statusCode;
        }
        /// <summary>
        /// 
        /// </summary>
        public HttpStatusCode? StatusCode
        {
            get => _statusCode;
            set
            {
                _statusCode = value;
            }
        }
        private HttpStatusCode? _statusCode;
    }
}
