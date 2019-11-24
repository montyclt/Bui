namespace MontyClt.Bui.Components.Popovers
{
    public sealed class Placement
    {
        public readonly Placement Right = new Placement("right");
        public readonly Placement Left = new Placement("left");
        public readonly Placement Top = new Placement("top");
        public readonly Placement Bottom = new Placement("bottom");

        private readonly string _value;

        private Placement(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }
    }
}
