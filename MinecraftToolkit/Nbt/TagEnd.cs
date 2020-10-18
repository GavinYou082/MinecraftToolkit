using System.Diagnostics.CodeAnalysis;

namespace MinecraftToolkit.Nbt
{
    public sealed class TagEnd : Tag<object>
    {
        public static new readonly byte ID = 0;
        public static readonly TagEnd TagEndInstance = new TagEnd();

        public new object Value { get => null; }

        private TagEnd() { }

        public override bool Equals([AllowNull] INbtTag other) => other switch
        {
            TagEnd => true,
            _ => false
        };

        protected override Tag<object> CloneTag() => TagEndInstance;
    }
}
