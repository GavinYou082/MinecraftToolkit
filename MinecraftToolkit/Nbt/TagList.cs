using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace MinecraftToolkit.Nbt
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class TagList<T> : Tag<IList<T>>, IList<T>
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public static new readonly byte ID = 9;

        public TagList(IList<T> value = default)
        {
            Value = value;
        }

        public override bool Equals(INbtTag obj)
        {
            if (obj is not TagList<T> lst || lst.Count != Count) return false;

            for (int i = 0; i < Count; i++)
            {
                if (!lst[i].Equals(Value[i])) return false;
            }

            return true;
        }

        protected override Tag<IList<T>> CloneTag()
        {
            T[] arr = new T[Value.Count];
            Value.CopyTo(arr, 0);
            return new TagList<T>(arr);
        }
        public new TagList<T> Clone() => CloneTag() as TagList<T>;

        #region IList<T> Members
        public int Count => Value.Count;

        bool ICollection<T>.IsReadOnly => Value.IsReadOnly;

        public T this[int index] { get => Value[index]; set => Value[index] = value; }

        public int IndexOf(T item) => Value.IndexOf(item);

        public void Insert(int index, T item) => Value.Insert(index, item);

        public void RemoveAt(int index) => Value.RemoveAt(index);

        public void Add(T item) => Value.Add(item);

        public void Clear() => Value.Clear();

        public bool Contains(T item) => Value.Contains(item);

        void ICollection<T>.CopyTo(T[] array, int arrayIndex) => Value.CopyTo(array, arrayIndex);

        public bool Remove(T item) => Value.Remove(item);

        public IEnumerator<T> GetEnumerator() => Value.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Value).GetEnumerator();
        #endregion
    }
}
