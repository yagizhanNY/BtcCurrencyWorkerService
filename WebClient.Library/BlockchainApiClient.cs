using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text;

namespace ApiClient.Library
{
    public class BlockchainApiClient
    {
        string url = "https://blockchain.info/ticker";

        public double GetCurrentCurrency(string currencyString)
        {
            using(WebClient webClient = new WebClient())
            {
                try
                {
                    string response = webClient.DownloadString(url);

                    JObject jsonObject = JObject.Parse(response);
                    string value = jsonObject[currencyString]["15m"].ToString();

                    return Convert.ToDouble(value);
                }
                catch
                {
                    throw new ArgumentException("API Client Error");
                }
            }
        }
    }
}
