using System.Collections.Generic;

namespace MinecraftToolkit.Nbt
{
    public class TagList<T> : Tag<IList<T>>
    {
        public static new readonly byte ID = 9;

        public TagList(IList<T> value = default)
        {
            Value = value;
        }

        protected override Tag<IList<T>> CloneTag()
        {
            T[] arr = new T[Value.Count];
            Value.CopyTo(arr, 0);
            return new TagList<T>(arr);
        }
        public new TagList<T> Clone() => CloneTag() as TagList<T>;
    }
}
