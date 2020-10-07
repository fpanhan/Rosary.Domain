namespace Rosary.Domain.Utils
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public static class Extensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }

        public static void LoadJson(string jsonPath)
        {
            using (var r = new StreamReader(jsonPath))
            {
                var json = r.ReadToEnd();
                var mysterys = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

                foreach (var item in mysterys)
                {
                    var a = item.Key;
                    var decades = JsonConvert.DeserializeObject<Dictionary<string, object>>(item.Value.ToString());
                    foreach (var pray in decades)
                    {
                        var b = pray.Key;
                        var teste = ((JContainer)pray.Value).First;
                        var i = ((JProperty)((JContainer)teste).First).Name;
                    }
                }
            }
        }

        public static void GetClassDescription()
        {
            //// Gets the attributes for the property.
            //var attributes = TypeDescriptor.GetProperties(this)["Chaplet"].Attributes;

            //// Prints the description by retrieving the DescriptionAttribute from the AttributeCollection.
            //var myAttribute = (DescriptionAttribute)attributes[typeof(DescriptionAttribute)];
            //Console.WriteLine(myAttribute.Description);
        }

        public static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace) => assembly.GetTypes().Where(t => string.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
    }
}
