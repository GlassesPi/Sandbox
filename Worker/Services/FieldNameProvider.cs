using Core.Services;
using Microsoft.Extensions.Caching.Memory;

namespace Worker.Services
{
    public class FieldNameProvider : IFieldNameProvider
    {
        private readonly IMemoryCache _memoryCache;

        public FieldNameProvider(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }


    }
}
