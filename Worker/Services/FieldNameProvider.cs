using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Core.Services;
using Microsoft.Extensions.Caching.Memory;
using Worker.Models;

namespace Worker.Services
{
    public class FieldNameProvider : IFieldNameProvider
    {
        private static Dictionary<Type, Dictionary<string, string>>? _fieldsDict;

        public FieldNameProvider()
        {
            _fieldsDict = new Dictionary<Type, Dictionary<string, string>>();

            var types = typeof(Person).Assembly.GetTypes().Where(t => t.Namespace == "Worker.Models");
            foreach (var type in types)
            {
                var props = type.GetProperties();
                var valueDict = new Dictionary<string, string>();

                foreach (var propertyInfo in props)
                {
                    var attr = propertyInfo.GetCustomAttribute<ColumnAttribute>()?.Name;

                    if (attr != null)
                        valueDict.Add(propertyInfo.Name.ToLower(), attr);

                }

                _fieldsDict.Add(type, valueDict);

            }

        }

        public Dictionary<string, string>? GetFieldName(Type type)
        {
            //var dict = new Dictionary<string, string>();

            _fieldsDict.TryGetValue(type, out var dict);

            //var dict = _fieldsDict[type];

            return dict;
        }
    }
}
