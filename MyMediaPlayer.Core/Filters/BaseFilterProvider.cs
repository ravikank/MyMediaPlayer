using MyMediaPlayer.Abstractions;
using System.Collections.Generic;

namespace MyMediaPlayer.Core.Filters
{
    public abstract class BaseFilterProvider
    {
        public Dictionary<string, IMediaFilterProvider> _filters = new Dictionary<string, IMediaFilterProvider>();
        protected string Key { get; }

        public BaseFilterProvider(string key)
        {
            Key = key;
        }

        public void AddFilter(IMediaFilterProvider filter)
        {
            _filters.Add(Key, filter);
        }
    }
}
