using System;
using System.Collections.Generic;

namespace FirstC_AdvancedAssignment
{
    public class CacheItem<TKey, Tval>
    {
        public TKey Key { get; set; }
        public Tval Value { get; set; }
        public DateTime Expire { get; set; }
    }

    public class Cache<TKey, Tval>
    {
        private List<CacheItem<TKey, Tval>> items = new List<CacheItem<TKey, Tval>>();
        // el method de m4 ht5ly ay key mtkrr
        public void Add(TKey key, Tval value, int seconds)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Key.Equals(key))
                {
                    items.RemoveAt(i);
                    break;
                }
            }

            CacheItem<TKey, Tval> item = new CacheItem<TKey, Tval>();
            item.Key = key;
            item.Value = value;
            item.Expire = DateTime.Now.AddSeconds(seconds);

            items.Add(item);
        }

        public void Remove(TKey key)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Key.Equals(key))
                {
                    items.RemoveAt(i);
                    break;
                }
            }
        }

        public bool Contains(TKey key) 
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Key.Equals(key))
                {
                    if (items[i].Expire > DateTime.Now)
                        return true;
                    else
                        return false;
                }
            }

            return false; 
        }

        public Tval Get(TKey key)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Key.Equals(key))
                {
                    if (items[i].Expire > DateTime.Now)
                    {
                        return items[i].Value;
                    }
                    else
                    {
                        items.RemoveAt(i);
                        break;
                    }
                }
            }

            return default(Tval); 
        }
    }
}