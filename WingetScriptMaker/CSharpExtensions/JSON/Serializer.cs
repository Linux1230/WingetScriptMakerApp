using System.Web.Script.Serialization;

namespace CSharpExtensions.JSON
{
    public static class JSONSerializer
    {
        public static string Serialize(this object _object)
        {
            return new JavaScriptSerializer().Serialize(_object);
        }

        public static T Deserialize<T>(this string json)
        {
            return new JavaScriptSerializer().Deserialize<T>(json);
        }
    }
}
