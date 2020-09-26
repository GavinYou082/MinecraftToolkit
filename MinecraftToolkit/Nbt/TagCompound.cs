using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MinecraftToolkit.Nbt
{
    public class TagCompound : Tag<Dictionary<string, Tag<object>>>, IDictionary<string, Tag<object>>
    {
        public static new readonly byte ID = 10;

        public TagCompound(Dictionary<string, Tag<object>> value) 
        {
            Value = new Dictionary<string, Tag<object>>();
            foreach (var item in value)
            {
                Value.Add(item.Key, item.Value.Clone());
            }
        }//TODO: Move clone to CloneTag()
        //TODO: override Equals()
        protected override Tag<Dictionary<string, Tag<object>>> CloneTag() => new TagCompound(Value);
        public new TagCompound Clone() => CloneTag() as TagCompound;

        #region IDictionary<string, NbtTag<object>> Members
        public ICollection<string> Keys => Value.Keys;

        public ICollection<Tag<object>> Values => Value.Values;

        public int Count => Value.Count;

        bool ICollection<KeyValuePair<string, Tag<object>>>.IsReadOnly => false;

        public Tag<object> this[string key] { get => Value[key]; set => Value[key] = value; }//


        public void Add(string key, Tag<object> value) => Value.Add(key, value);

        public bool ContainsKey(string key) => Value.ContainsKey(key);

        public bool Remove(string key) => Value.Remove(key);

        public bool TryGetValue(string key, [MaybeNullWhen(false)] out Tag<object> value) => Value.TryGetValue(key, out value);

        public void Add(KeyValuePair<string, Tag<object>> item) => Value.Add(item.Key, item.Value);//

        public void Clear() => Value.Clear();

        bool ICollection<KeyValuePair<string, Tag<object>>>.Contains(KeyValuePair<string, Tag<object>> item)
            => ((ICollection<KeyValuePair<string, Tag<object>>>)Value).Contains(item);

        void ICollection<KeyValuePair<string, Tag<object>>>.CopyTo(KeyValuePair<string, Tag<object>>[] array, int arrayIndex)
            => ((ICollection<KeyValuePair<string, Tag<object>>>)Value).CopyTo(array, arrayIndex);

        bool ICollection<KeyValuePair<string, Tag<object>>>.Remove(KeyValuePair<string, Tag<object>> item)
            => ((ICollection<KeyValuePair<string, Tag<object>>>)Value).Remove(item);

        public IEnumerator<KeyValuePair<string, Tag<object>>> GetEnumerator() => Value.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Value.GetEnumerator();
        #endregion
    }
}
