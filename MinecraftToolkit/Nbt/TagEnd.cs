namespace MinecraftToolkit.Nbt
{
    public sealed class TagEnd : Tag<object>
    {
        public static new readonly byte ID = 0;
        public static readonly TagEnd TagEndInstance = new TagEnd();

        public new object Value { get => null; }

        private TagEnd() { }

        protected override Tag<object> CloneTag() => TagEndInstance;
    }
}
