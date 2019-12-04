using Microsoft.AspNetCore.Components;

namespace MontyClt.Bui.Components.Cards
{
    public partial class Alert
    {
        [Parameter]
        public State State { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Icon { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
