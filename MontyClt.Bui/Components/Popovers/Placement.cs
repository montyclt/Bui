namespace MontyClt.Bui.Components.Popovers
{
    public sealed class Placement
    {
        public static readonly Placement Right = new Placement("right");
        public static readonly Placement RightStart = new Placement("right-start");
        public static readonly Placement RightEnd = new Placement("right-end");

        public static readonly Placement Left = new Placement("left");
        public static readonly Placement LeftStart = new Placement("left-start");
        public static readonly Placement LeftEnd = new Placement("left-end");

        public static readonly Placement Top = new Placement("top");
        public static readonly Placement TopStart = new Placement("top-start");
        public static readonly Placement TopEnd = new Placement("top-end");

        public static readonly Placement Bottom = new Placement("bottom");
        public static readonly Placement BottomStart = new Placement("bottom-start");
        public static readonly Placement BottomEnd = new Placement("bottom-end");

        public static readonly Placement Auto = new Placement("auto");
        public static readonly Placement AutoStart = new Placement("auto-start");
        public static readonly Placement AutoEnd = new Placement("auto-end");

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
