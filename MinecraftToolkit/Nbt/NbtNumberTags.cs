namespace MinecraftToolkit.Nbt
{
    public class NbtTagByte : NbtTag<sbyte>
    {
        public NbtTagByte(sbyte value = default) : base(value) { }

        protected override NbtTag<sbyte> CloneTag() => new NbtTagByte(Value);
        public new NbtTagByte Clone() => CloneTag() as NbtTagByte;

        public static implicit operator NbtTagShort(NbtTagByte tag) => new NbtTagShort(tag.Value);
        public static implicit operator NbtTagInt(NbtTagByte tag) => new NbtTagInt(tag.Value);
        public static implicit operator NbtTagLong(NbtTagByte tag) => new NbtTagLong(tag.Value);
    }

    public class NbtTagShort : NbtTag<short>
    {
        public NbtTagShort(short value = default) : base(value) { }

        protected override NbtTag<short> CloneTag() => new NbtTagShort(Value);
        public new NbtTagShort Clone() => CloneTag() as NbtTagShort;

        public static implicit operator NbtTagInt(NbtTagShort tag) => new NbtTagInt(tag.Value);
        public static implicit operator NbtTagLong(NbtTagShort tag) => new NbtTagLong( tag.Value);
    }

    public class NbtTagInt : NbtTag<int>
    {
        public NbtTagInt(int value = default) : base(value) { }

        protected override NbtTag<int> CloneTag() => new NbtTagInt(Value);
        public new NbtTagInt Clone() => CloneTag() as NbtTagInt;

        public static implicit operator NbtTagLong(NbtTagInt tag) => new NbtTagLong(tag.Value);
    }

    public class NbtTagLong : NbtTag<long>
    {
        public NbtTagLong(long value = default) : base(value) { }

        protected override NbtTag<long> CloneTag() => new NbtTagLong(Value);
        public new NbtTagLong Clone() => CloneTag() as NbtTagLong;
    }


    public class NbtTagFloat : NbtTag<float>
    {
        public NbtTagFloat(float value = default) : base(value) { }

        protected override NbtTag<float> CloneTag() => new NbtTagFloat(Value);
        public new NbtTagFloat Clone() => CloneTag() as NbtTagFloat;

        public static implicit operator NbtTagDouble(NbtTagFloat tag) => new NbtTagDouble(tag.Value);
    }

    public class NbtTagDouble : NbtTag<double>
    {
        public NbtTagDouble(double value = default) : base(value) { }

        protected override NbtTag<double> CloneTag() => new NbtTagDouble(Value);
        public new NbtTagDouble Clone() => CloneTag() as NbtTagDouble;
    }
}
