using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace epms.WebAPI.Infrastructure
{
    public class JsonContentNegotiation : IContentNegotiator
    {
        private readonly JsonMediaTypeFormatter _jsonMediaTypeFormatter;

        public JsonContentNegotiation(JsonMediaTypeFormatter jsonMediaTypeFormatter)
        {
            _jsonMediaTypeFormatter = jsonMediaTypeFormatter;
        }

        public ContentNegotiationResult Negotiate(Type type, HttpRequestMessage request,
            IEnumerable<MediaTypeFormatter> formatters)
        {
            return new ContentNegotiationResult(_jsonMediaTypeFormatter, new MediaTypeHeaderValue("application/json"));
        }
    }
}