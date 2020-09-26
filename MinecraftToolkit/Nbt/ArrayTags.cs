namespace MinecraftToolkit.Nbt
{
    public abstract class TagArray<T> : Tag<T[]>
    {
        protected TagArray(T[] value = default)
        {
            Value = value;
        }

        public new TagArray<T> Clone() => CloneTag() as TagArray<T>;
    }

    public class TagByteArray : TagArray<sbyte>
    {
        public static new readonly byte ID = 7;

        public TagByteArray(sbyte[] value = default) : base(value) { }

        protected override Tag<sbyte[]> CloneTag() => new TagByteArray((sbyte[])Value.Clone());
        public new TagByteArray Clone() => CloneTag() as TagByteArray;
    }

    public class TagIntArray : TagArray<int>
    {
        public static new readonly byte ID = 11;

        public TagIntArray(int[] value = default) : base(value) { }

        protected override Tag<int[]> CloneTag() => new TagIntArray((int[])Value.Clone());
        public new TagIntArray Clone() => CloneTag() as TagIntArray;
    }

    public class TagLongArray : TagArray<long>
    {
        public static new readonly byte ID = 12;

        public TagLongArray(long[] value = default) : base(value) { }

        protected override Tag<long[]> CloneTag() => new TagLongArray((long[])Value.Clone());
        public new TagLongArray Clone() => CloneTag() as TagLongArray;
    }
}
