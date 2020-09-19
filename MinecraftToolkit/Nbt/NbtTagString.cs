namespace MinecraftToolkit.Nbt
{
    public class NbtTagString : NbtTag<string>
    {
        public NbtTagString(string value = default) : base(value) { }

        protected override NbtTag<string> CloneTag() => new NbtTagString(Value);
        public new NbtTagString Clone() => CloneTag() as NbtTagString;
    }
}
