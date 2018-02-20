using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MainScreen.Model
{
    public class Joke
    {
        
        public object category { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string value { get; set; }

        private const string queryUrl = "https://api.chucknorris.io/jokes/random";

        public async static Task<string> GetJoke()
        {
            string strJoke;

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(queryUrl);
                var json = await response.Content.ReadAsStringAsync();

                var chuckJoke = JsonConvert.DeserializeObject<Joke>(json);

                strJoke = chuckJoke.value;
            }


            return strJoke;
        }
    
    }
}
