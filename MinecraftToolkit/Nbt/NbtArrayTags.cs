using System;
using System.Collections.Generic;
using System.Text;

namespace MinecraftToolkit.Nbt
{
    public abstract class NbtTagArray<T> : NbtTag<T[]>
    {
        protected NbtTagArray(T[] value = default)
        {
            Value = new T[value.Length];
            value.CopyTo(Value, 0);
        }

        public new NbtTagArray<T> Clone() => CloneTag() as NbtTagArray<T>;
    }

    public class NbtTagArrayInt : NbtTagArray<int>
    {
        public NbtTagArrayInt(int[] value = default) : base(value) { }

        protected override NbtTag<int[]> CloneTag() => new NbtTagArrayInt(Value);
        public new NbtTagArrayInt Clone() => CloneTag() as NbtTagArrayInt;
    }

    public class NbtTagArrayByte : NbtTagArray<sbyte>
    {
        public NbtTagArrayByte(sbyte[] value = default) : base(value) { }

        protected override NbtTag<sbyte[]> CloneTag() => new NbtTagArrayByte(Value);
        public new NbtTagArrayByte Clone() => CloneTag() as NbtTagArrayByte;
    }

    public class NbtTagArrayLong : NbtTagArray<long>
    {
        public NbtTagArrayLong(long[] value = default) : base(value) { }

        protected override NbtTag<long[]> CloneTag() => new NbtTagArrayLong(Value);
        public new NbtTagArrayLong Clone() => CloneTag() as NbtTagArrayLong;
    }
}
