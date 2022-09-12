using System.Collections.Generic;

namespace AutoMapper.CollectionExtensions
{
    internal static class DictionaryEx
    {
        public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (dict == null || key == null || dict.ContainsKey(key) || value == null) return false;
            dict[key] = value;
            return true;
        }

        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key)
        {
            if (dict == null || !dict.ContainsKey(key)) return default;
            return dict[key];
        }

    }
}
