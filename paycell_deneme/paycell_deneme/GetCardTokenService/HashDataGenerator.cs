using paycell_deneme.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace paycell_deneme.GetCardTokenService
{
    public class HashDataGenerator
    {
        public static string GenerateForRequest(string transactionid,string transactiondateteime)
        {
            string securityData = Constant.APPLICATION_PASSWORD.ToUpper() + Constant.APPLICATION_NAME.ToUpper();
            securityData = Sha256(securityData);

            string hashdata = Constant.APPLICATION_NAME.ToUpper() + transactionid.ToUpper() + transactiondateteime.ToUpper() + Constant.SECURE_CODE.ToUpper() + securityData;
            hashdata = Sha256(hashdata);
            return hashdata;
        }
        public static string GenerateForResponse(string transactionid,string responsedatetime,string responsecode,string cardtoken)
        {
            string securitydata = Constant.APPLICATION_PASSWORD.ToUpper() + Constant.APPLICATION_NAME.ToUpper();
            securitydata = Sha256(securitydata);

            string hash = Constant.APPLICATION_NAME.ToUpper() + transactionid.ToUpper() + responsedatetime.ToUpper() + responsecode.ToUpper() + cardtoken.ToUpper() + Constant.SECURE_CODE.ToUpper() + securitydata;

            hash = Sha256(hash);

            return hash;

        }
        static string Sha256(string originalString)
        {
            try
            {
                SHA256 sha256 = SHA256.Create();
                return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(originalString)));
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}