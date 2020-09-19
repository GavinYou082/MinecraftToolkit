using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MinecraftToolkit.Nbt
{
    //TODO: deep copy child tags
    public class NbtTagCompound : NbtTag<Dictionary<string, NbtTag<object>>>, IDictionary<string, NbtTag<object>>
    {
        public NbtTagCompound(Dictionary<string, NbtTag<object>> value) : base(value) { }

        protected override NbtTag<Dictionary<string, NbtTag<object>>> CloneTag() => new NbtTagCompound(Value);
        public new NbtTagCompound Clone() => CloneTag() as NbtTagCompound;

        #region Implement IDictionary<string, NbtTag<object>>
        public ICollection<string> Keys => Value.Keys;

        public ICollection<NbtTag<object>> Values => Value.Values;

        public int Count => Value.Count;

        bool ICollection<KeyValuePair<string, NbtTag<object>>>.IsReadOnly => false;

        public NbtTag<object> this[string key] { get => Value[key]; set => Value[key] = value; }


        public void Add(string key, NbtTag<object> value) => Value.Add(key, value);

        public bool ContainsKey(string key) => Value.ContainsKey(key);

        public bool Remove(string key) => Value.Remove(key);

        public bool TryGetValue(string key, [MaybeNullWhen(false)] out NbtTag<object> value) => Value.TryGetValue(key, out value);

        public void Add(KeyValuePair<string, NbtTag<object>> item) => Value.Add(item.Key, item.Value);

        public void Clear() => Value.Clear();

        bool ICollection<KeyValuePair<string, NbtTag<object>>>.Contains(KeyValuePair<string, NbtTag<object>> item)
            => ((ICollection<KeyValuePair<string, NbtTag<object>>>)Value).Contains(item);

        void ICollection<KeyValuePair<string, NbtTag<object>>>.CopyTo(KeyValuePair<string, NbtTag<object>>[] array, int arrayIndex)
            => ((ICollection<KeyValuePair<string, NbtTag<object>>>)Value).CopyTo(array, arrayIndex);

        bool ICollection<KeyValuePair<string, NbtTag<object>>>.Remove(KeyValuePair<string, NbtTag<object>> item)
            => ((ICollection<KeyValuePair<string, NbtTag<object>>>)Value).Remove(item);

        public IEnumerator<KeyValuePair<string, NbtTag<object>>> GetEnumerator() => Value.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Value.GetEnumerator();
        #endregion
    }
}
