using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace paycell_deneme.GetCardTokenService
{
    public class GetCardTokenResponse
    {
        public ResponseHeader header { get; set; }
        public string cardToken { get; set; }

        public string hashData { get; set; }
    }
}