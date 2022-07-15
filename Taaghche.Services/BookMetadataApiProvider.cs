using Taaghche.Core;
using Taaghche.Application;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;

namespace Taaghche.Services
{
    public class BookMetadataApiProvider : DataProvider<BookMetadata>
    {
        /// <summary>
        /// get data from taaghche api
        /// </summary>
        /// <param name="Args">Must contain id as Key with integer value</param>
        /// <returns></returns>
        public override async Task<BookMetadata> Get(Dictionary<string, object> Args)
        {
            int id = 0;
            if ((!Args?.ContainsKey("id") ?? true) || !int.TryParse(Args["id"].ToString(), out id)
                || _notFound.Contains(Args["id"].ToString()))
                return null;

            using (var response = await _httpClient.GetAsync(_url + Args["id"]))
            {
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (responseString == null || responseString == "")
                    {
                        _notFound.Add(Args["id"].ToString());
                        return null;
                    }

                    var result = await BookMetadata.FromJson(responseString);

                    if (result != null) result.Id = id;

                    return result;
                }
            }
            return null;
        }

        private readonly List<string> _notFound = new List<string>();
        private readonly HttpClient _httpClient = new HttpClient();
        private const string _url = "https://get.taaghche.com/v2/book/";
    }
}
