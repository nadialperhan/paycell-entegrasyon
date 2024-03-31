using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace paycell_deneme.Constants
{
    public static class Constant
    {
        public const string APPLICATION_PASSWORD = "Z8T62EW3D0PHC479";
        public const string SECURE_CODE = "Z8T62EW3D0PHC479";
        public const string APPLICATION_NAME = "BULUTTAHSILAT";
        public const string MERCHANT_CODE = "206198";

        public const string API_BASE_URL = "https://omccstb.turkcell.com.tr/";
        public const string GET_CARD_TOKEN_URL= "paymentmanagement/rest/getCardTokenSecure";
    }
}