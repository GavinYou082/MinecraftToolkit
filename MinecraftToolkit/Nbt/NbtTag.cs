using System;
using System.Text;

namespace MinecraftToolkit.Nbt
{
    public abstract class NbtTag<T> : ICloneable
    {
        public T Value { get; set; }

        protected NbtTag(T value = default)
        {
            Value = value;
        }

        public static implicit operator T(NbtTag<T> tag) => tag.Value;

        public override bool Equals(object obj)
        {
            return Value.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        #region Implement Clone
        public NbtTag<T> Clone() => CloneTag();
        protected abstract NbtTag<T> CloneTag();
        object ICloneable.Clone() => CloneTag();
        #endregion
    }
}
