using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace paycell_deneme.GetCardTokenService
{
    public class RequestHeader
    {
        public string applicationName { get; set; }
        public string transactionId { get; set; }
        public string transactionDateTime { get; set; }
    }
}