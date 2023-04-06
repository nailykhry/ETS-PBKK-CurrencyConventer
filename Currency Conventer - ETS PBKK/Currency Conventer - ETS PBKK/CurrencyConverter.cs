using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace Currency_Conventer___ETS_PBKK
{
    public class CurrencyConverter
    {
        Dictionary<string, string> symbols;
        public Dictionary<string, string> getSymbols()
        {
            if(symbols == null )
            {
                symbols = new Dictionary<string, string>();
                string responseContent = getResponseString($"exchangerates_data/symbols");

                Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);
                if ((bool)responseData["success"])
                {
                    var tempSymbols = (JObject)responseData["symbols"];
                    symbols = tempSymbols.ToObject<Dictionary<string, string>>();
                }
            }
            return symbols;
        }
        private string getResponseString(string relativeURI)
        {
            var client = new RestClient($"https://api.apilayer.com/");

            var request = new RestRequest(relativeURI, Method.Get);
            request.AddHeader("apikey", "o1HPn2KGVObeemCZircFICtKrWCt26Or");

            RestResponse response = client.Execute(request);
            return response.Content;
        }

        public double Convert(string fromCurrency, string toCurrency, double fromCurrencyAmount)
        {
            string responseContent = getResponseString($"exchangerates_data/convert?to={toCurrency}&from={fromCurrency}&amount={fromCurrencyAmount}");

            Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);

            if ((bool)responseData["success"])
            {
                return (double)responseData["result"];
            }
            else
            {
                return -1;
            }

        }
    }
}
