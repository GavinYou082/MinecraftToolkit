using System;
using System.Text;

namespace MinecraftToolkit.Nbt
{
    public abstract class Tag<T> : ICloneable
    {
        public T Value { get; set; }

        protected Tag(T value = default)
        {
            Value = value;
        }

        public static implicit operator T(Tag<T> tag) => tag.Value;

        public override bool Equals(object obj)
        {
            return Value.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        #region Implement Clone
        public Tag<T> Clone() => CloneTag();
        protected abstract Tag<T> CloneTag();
        object ICloneable.Clone() => CloneTag();
        #endregion
    }
}
