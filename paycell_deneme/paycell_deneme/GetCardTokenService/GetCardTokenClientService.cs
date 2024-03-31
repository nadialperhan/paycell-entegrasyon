using paycell_deneme.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace paycell_deneme.GetCardTokenService
{
    public class GetCardTokenClientService:BaseApiClientServiceImpl<GetCardTokenRequest,GetCardTokenResponse>
    {
        public GetCardTokenResponse GetCardToken(GetCardTokenRequest request)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            GetCardTokenResponse response = RestClient(Constant.GET_CARD_TOKEN_URL, request);
            if (response.cardToken==null|| response.hashData==null)
            {
                throw new Exception(response.header.responseDescription);
            }
            if (response.hashData!=GenerateHashData(response))
            {
                throw new Exception("Token Doğrulanamadı");
            }
            return response;

        }
        private string GenerateHashData(GetCardTokenResponse response)
        {
            string transactionId = response.header.transactionId;
            string responseDateTime = response.header.responseDateTime;
            string responseCode = response.header.responseCode;
            string cardToken = response.cardToken;

            return HashDataGenerator.GenerateForResponse(transactionId, responseDateTime, responseCode, cardToken);
        }
    }
}