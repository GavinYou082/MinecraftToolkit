using System.Collections.Generic;

namespace MinecraftToolkit.Nbt
{
    public class TagList<T> : Tag<IList<T>>
    {
        public TagList(IList<T> value = default)
        {
            T[] arr = new T[value.Count];
            value.CopyTo(arr, 0);
            Value = arr;
        }

        protected override Tag<IList<T>> CloneTag() => new TagList<T>(Value);
        public new TagList<T> Clone() => CloneTag() as TagList<T>;
    }
}
