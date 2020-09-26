namespace MinecraftToolkit.Nbt
{
    public abstract class TagArray<T> : Tag<T[]>
    {
        protected TagArray(T[] value = default)
        {
            Value = new T[value.Length];
            value.CopyTo(Value, 0);
        }//TODO: Move clone to CloneTag()

        public new TagArray<T> Clone() => CloneTag() as TagArray<T>;
    }

    public class TagArrayInt : TagArray<int>
    {
        public TagArrayInt(int[] value = default) : base(value) { }

        protected override Tag<int[]> CloneTag() => new TagArrayInt(Value);
        public new TagArrayInt Clone() => CloneTag() as TagArrayInt;
    }

    public class TagArrayByte : TagArray<sbyte>
    {
        public TagArrayByte(sbyte[] value = default) : base(value) { }

        protected override Tag<sbyte[]> CloneTag() => new TagArrayByte(Value);
        public new TagArrayByte Clone() => CloneTag() as TagArrayByte;
    }

    public class TagArrayLong : TagArray<long>
    {
        public TagArrayLong(long[] value = default) : base(value) { }

        protected override Tag<long[]> CloneTag() => new TagArrayLong(Value);
        public new TagArrayLong Clone() => CloneTag() as TagArrayLong;
    }
}
