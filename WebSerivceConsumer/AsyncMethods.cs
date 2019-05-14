using System.Threading.Tasks;

namespace WebSerivceConsumer
{
    public static class AsyncMethods
    {
        private static localhost.ChallengeWebService webService = new localhost.ChallengeWebService();

        public static async Task<int> FibonacciToAsync(int n)
        {
            return await Task.Run(() => webService.Fibonacci(n));
        }

        public static async Task<string> ConvertXmlToAsync(string xml)
        {
            return await Task.Run(() => webService.XmlToJson(xml));
        }
    }
}
