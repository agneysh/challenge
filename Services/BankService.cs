using Challenge.Domain.Models;
using Challenge.Domain.Repositories;
using Challenge.Domain.Services;
using Challenge.Domain.Services.Communication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Challenge.Services
{
    public class BankService
    {
        public static async Task<BankResponse> TransactionProcess(string ClientID, string Card, int CVV, string CardExpiry, string OrderReference, string OrderDate, Double Amount, string MerchantID)
        {
            var client = new HttpClient();
            var values = new Dictionary<string, string>
            {
            { "ClientID", ClientID},
            { "Card", Card.ToString() },
            { "CVV",  CVV.ToString()},
            { "CardExpiry", CardExpiry },
            { "OrderReference", OrderReference},
            { "OrderDate", OrderDate},
            { "Amount", Amount.ToString() },
            { "MerchantID", MerchantID},

            };

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://bca62f5a-03ed-43f2-a169-5c929088a096.mock.pstmn.io/transactionprocess", content);

            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<BankResponse>(responseString);

            return result;
        }
    }
}
