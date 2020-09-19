namespace MinecraftToolkit.Nbt
{
    public class NbtTagBool : NbtTag<bool>
    {
        public NbtTagBool(bool value = default) : base(value) { }

        protected override NbtTag<bool> CloneTag() => new NbtTagBool(Value);
        public new NbtTagBool Clone() => CloneTag() as NbtTagBool;

    }
}
