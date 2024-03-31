using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace paycell_deneme.GetCardTokenService
{
    public class ResponseHeader
    {
        public string transactionId { get; set; }
        public string responseDateTime { get; set; }
        public string responseCode { get; set; }
        public string responseDescription { get; set; }
    }
}