using Microsoft.Extensions.Caching.Memory;

namespace Core.Services
{
    public interface IFieldNameProvider
    {
        Dictionary<string, string>? GetFieldName(Type type);
    }
}
