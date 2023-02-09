using Newtonsoft.Json;

namespace LogCore.Utility
{
    public static class JsonConversion
    {
        public static string SerializeObject(Object obj)
        {
            string ser = String.Empty;
            if (obj != null)
            {
                ser = JsonConvert.SerializeObject(obj);
            }
            return ser;
        }
    }
}