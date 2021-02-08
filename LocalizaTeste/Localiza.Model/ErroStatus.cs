using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Localiza.Model
{
    public class ErroStatus
    {
        public HttpStatusCode statusCode { get; set; }
        public string mensagem { get; set; }
    }
}
