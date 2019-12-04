using Microsoft.AspNetCore.Components;

namespace MontyClt.Bui.Components.Cards
{
    public partial class Card
    {
        [Parameter]
        public RenderFragment Header { get; set; }

        [Parameter]
        public RenderFragment Body { get; set; }

        [Parameter]
        public bool FitBody { get; set; }

        [Parameter]
        public RenderFragment Footer { get; set; }
    }
}
