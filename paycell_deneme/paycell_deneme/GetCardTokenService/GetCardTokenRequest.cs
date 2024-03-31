using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace paycell_deneme.GetCardTokenService
{
    public class GetCardTokenRequest
    {
        public RequestHeader header { get; set; }
        public string creditCardNo { get; set; }

        public string expireDateMonth { get; set; }

        public string expireDateYear { get; set; }

        public string cvcNo { get; set; }

        public string hashData { get; set; }
    }
}