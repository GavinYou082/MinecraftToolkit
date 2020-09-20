namespace MinecraftToolkit.Nbt
{
    public class TagByte : Tag<sbyte>
    {
        public TagByte(sbyte value = default) : base(value) { }

        protected override Tag<sbyte> CloneTag() => new TagByte(Value);
        public new TagByte Clone() => CloneTag() as TagByte;

        public static implicit operator TagShort(TagByte tag) => new TagShort(tag.Value);
        public static implicit operator TagInt(TagByte tag) => new TagInt(tag.Value);
        public static implicit operator TagLong(TagByte tag) => new TagLong(tag.Value);
    }

    public class TagShort : Tag<short>
    {
        public TagShort(short value = default) : base(value) { }

        protected override Tag<short> CloneTag() => new TagShort(Value);
        public new TagShort Clone() => CloneTag() as TagShort;

        public static implicit operator TagInt(TagShort tag) => new TagInt(tag.Value);
        public static implicit operator TagLong(TagShort tag) => new TagLong( tag.Value);
    }

    public class TagInt : Tag<int>
    {
        public TagInt(int value = default) : base(value) { }

        protected override Tag<int> CloneTag() => new TagInt(Value);
        public new TagInt Clone() => CloneTag() as TagInt;

        public static implicit operator TagLong(TagInt tag) => new TagLong(tag.Value);
    }

    public class TagLong : Tag<long>
    {
        public TagLong(long value = default) : base(value) { }

        protected override Tag<long> CloneTag() => new TagLong(Value);
        public new TagLong Clone() => CloneTag() as TagLong;
    }


    public class TagFloat : Tag<float>
    {
        public TagFloat(float value = default) : base(value) { }

        protected override Tag<float> CloneTag() => new TagFloat(Value);
        public new TagFloat Clone() => CloneTag() as TagFloat;

        public static implicit operator TagDouble(TagFloat tag) => new TagDouble(tag.Value);
    }

    public class TagDouble : Tag<double>
    {
        public TagDouble(double value = default) : base(value) { }

        protected override Tag<double> CloneTag() => new TagDouble(Value);
        public new TagDouble Clone() => CloneTag() as TagDouble;
    }
}
