using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public static class JsonExtension
    {
        public static string ToJson(this object Data)
        {
            string res = JsonConvert.SerializeObject(Data, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            return res;
        }
        public static T JsonToObject<T>(this string Data) where T : class
        {
            return JsonConvert.DeserializeObject<T>(Data, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
        }
        public static T JsonToObjectStruct<T>(this string Data) where T : struct
        {
            return JsonConvert.DeserializeObject<T>(Data, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
        }
        public static T ConvertObject<T>(this object Data) where T : class
        {
            return Data.ToJson().JsonToObject<T>();
        }


    }
}
