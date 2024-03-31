using paycell_deneme.GetCardTokenService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace paycell_deneme
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TokenButton_Click(object sender, EventArgs e)
        {
            //var requestheader = new RequestHeader()
            //{
            //    applicationName = Constants.Constant.APPLICATION_NAME,
            //    transactionDateTime = DateTime.Now.ToString("yyyyMMddHHmmss") + "000",
            //    transactionId = UniqueIdGenerator.GenerateTransactionId()
            //};
            //string hashdata = HashDataGenerator.GenerateForRequest(requestheader.transactionId,requestheader.transactionDateTime);
            //var requestbody = new GetCardTokenRequest()
            //{
            //    creditCardNo = "4355084355084358",
            //    cvcNo = "000",
            //    expireDateMonth = "12",
            //    expireDateYear = "26",
            //    hashData = hashdata,
            //    header = requestheader
            //};
            GetCardTokenRequestFactory factory = new GetCardTokenRequestFactory();
            factory.AddCreditCardNo("4355084355084358");

            // Son kullanma tarihini ve CVC numarasını ekle
            factory.AddExpireDate("12", "26");
            factory.AddCvcNo("000");
            factory.Build();
            GetCardTokenRequest request = factory.Build(); 
            try
            {
                GetCardTokenClientService service = new GetCardTokenClientService();
                var response = service.GetCardToken(request);
                //if (response.)
                //{

                //}
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                throw;
            }

        }
    }
}