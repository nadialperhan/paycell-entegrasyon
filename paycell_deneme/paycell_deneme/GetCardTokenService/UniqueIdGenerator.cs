using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace paycell_deneme.GetCardTokenService
{
    public static class UniqueIdGenerator
    {
        public static string GenerateTransactionId()
        {
            Random random = new Random();
            string transactionId = "";

            for (int i = 0; i < 20; i++)
            {
                // Rastgele bir sayı oluştur ve transactionId'e ekle
                transactionId += random.Next(10); // 0 ile 9 arasında rastgele bir sayı oluşturur.
            }

            return transactionId;
        }
    }
}