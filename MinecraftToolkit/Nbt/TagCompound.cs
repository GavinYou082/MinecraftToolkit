using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MinecraftToolkit.Nbt
{
    public class TagCompound : Tag<Dictionary<string, INbtTag>>, IDictionary<string, INbtTag>
    {
        public static new readonly byte ID = 10;

        public TagCompound(Dictionary<string, INbtTag> value = null)
        {
            if (value is null) Value = new Dictionary<string, INbtTag>();
            else Value = value;
        }

        //TODO: override Equals()
        protected override Tag<Dictionary<string, INbtTag>> CloneTag()
        {
            var dict = new Dictionary<string, INbtTag>();
            foreach (var item in Value)
            {
                dict.Add(item.Key, (Tag<Dictionary<string, INbtTag>>)item.Value.Clone());
            }
            return new TagCompound(Value);
        }
        public new TagCompound Clone() => CloneTag() as TagCompound;

        public T GetChild<T>(string key) where T: Tag<T> => Value[key] as T;
        public bool TryGetChild<T>(string key, [MaybeNullWhen(false)] out T child) where T : Tag<T>
        {
            child = null;
            if (!Value.ContainsKey(key)) return false;
            if (Value[key] is Tag<T> tag)
            {
                child = tag;
                return true;
            }

            return false;
        }

        #region IDictionary<string, NbtINbtTag> Members
        public ICollection<string> Keys => Value.Keys;

        public ICollection<INbtTag> Values => Value.Values;

        public int Count => Value.Count;

        bool ICollection<KeyValuePair<string, INbtTag>>.IsReadOnly => false;

        public INbtTag this[string key] { get => Value[key]; set => Value[key] = value; }


        public void Add(string key, INbtTag value) => Value.Add(key, value);

        public bool ContainsKey(string key) => Value.ContainsKey(key);

        public bool Remove(string key) => Value.Remove(key);

        public bool TryGetValue(string key, [MaybeNullWhen(false)] out INbtTag value) => Value.TryGetValue(key, out value);

        void ICollection<KeyValuePair<string, INbtTag>>.Add(KeyValuePair<string, INbtTag> item) 
            => ((ICollection<KeyValuePair<string, INbtTag>>)Value).Add(item);

        public void Clear() => Value.Clear();

        bool ICollection<KeyValuePair<string, INbtTag>>.Contains(KeyValuePair<string, INbtTag> item)
            => ((ICollection<KeyValuePair<string, INbtTag>>)Value).Contains(item);

        void ICollection<KeyValuePair<string, INbtTag>>.CopyTo(KeyValuePair<string, INbtTag>[] array, int arrayIndex)
            => ((ICollection<KeyValuePair<string, INbtTag>>)Value).CopyTo(array, arrayIndex);

        bool ICollection<KeyValuePair<string, INbtTag>>.Remove(KeyValuePair<string, INbtTag> item)
            => ((ICollection<KeyValuePair<string, INbtTag>>)Value).Remove(item);

        public IEnumerator<KeyValuePair<string, INbtTag>> GetEnumerator() => Value.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Value.GetEnumerator();
        #endregion
    }
}
