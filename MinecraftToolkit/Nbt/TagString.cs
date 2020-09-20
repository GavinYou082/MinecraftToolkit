namespace MinecraftToolkit.Nbt
{
    public class TagString : Tag<string>
    {
        public TagString(string value = default) : base(value) { }

        protected override Tag<string> CloneTag() => new TagString(Value);
        public new TagString Clone() => CloneTag() as TagString;
    }
}
