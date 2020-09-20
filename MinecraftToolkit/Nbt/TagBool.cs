namespace MinecraftToolkit.Nbt
{
    public class TagBool : Tag<bool>
    {
        public TagBool(bool value = default) : base(value) { }

        protected override Tag<bool> CloneTag() => new TagBool(Value);
        public new TagBool Clone() => CloneTag() as TagBool;

    }
}
