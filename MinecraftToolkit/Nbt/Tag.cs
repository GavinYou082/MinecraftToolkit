using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace MinecraftToolkit.Nbt
{
    public enum TagType 
    { 
        TagEnd,
        TagByte,
        TagShort,
        TagInt,
        TagLong,
        TagFloat,
        TagDouble,
        TagByteArray,
        TagString,
        TagList,
        TagCompound,
        TagIntArray,
        TagLongArray
    }

    public interface INbtTag : ICloneable, IEquatable<INbtTag>
    {
        TagType TagType { get; }
        new INbtTag Clone();
        T GetValue<T>();
        object GetValue();
    }

    public abstract class Tag<T> : INbtTag
    {
        //Tag type and id used by minecraft
        public static readonly byte ID;
        public TagType TagType  { get => (TagType)ID; }

        public T Value { get; set; }
        //public TagCompound Parent { get; protected set; }

        protected Tag(T value = default)
        {
            Value = value;
        }

        public static implicit operator T(Tag<T> tag) => tag.Value;

        #region ICloneable Members
        protected abstract Tag<T> CloneTag();
        public Tag<T> Clone() => CloneTag();

        object ICloneable.Clone() => CloneTag();
        INbtTag INbtTag.Clone() => CloneTag();
        #endregion

        #region INbtTag Members
        public object GetValue() => Value;
        public TValue GetValue<TValue>()
        {
            if (Value is TValue t) return t;
            else throw new InvalidCastException($"Cannot cast the value of {typeof(Tag<T>)} to {typeof(TValue)}");
        }
        #endregion

        #region IEquatable Members
        public virtual bool Equals([AllowNull] INbtTag other) => Value.Equals(other.GetValue());

        public sealed override bool Equals(object obj)
        {
            if(obj is INbtTag t) return Value.Equals(t);
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        #endregion
    }
}
