using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace MontyClt.Bui.Components.Buttons
{
    public partial class Button
    {
        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        [Parameter]
        public State State { get; set; }

        [Parameter]
        public bool Loading { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string Icon { get; set; }

        [Parameter]
        public string AdditionalClasses { get; set; }
    }
}
