using System.Collections.Generic;

namespace MinecraftToolkit.Nbt
{
    public class NbtTagList<T> : NbtTag<IList<T>>
    {
        public NbtTagList(IList<T> value = default)
        {
            T[] arr = new T[value.Count];
            value.CopyTo(arr, 0);
            Value = arr;
        }

        protected override NbtTag<IList<T>> CloneTag() => new NbtTagList<T>(Value);
        public new NbtTagList<T> Clone() => CloneTag() as NbtTagList<T>;
    }
}
