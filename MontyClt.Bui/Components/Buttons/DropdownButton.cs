using Microsoft.AspNetCore.Components;
using MontyClt.Bui.Components.Popovers;

namespace MontyClt.Bui.Components.Buttons
{
    public partial class DropdownButton
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public State State { get; set; } = State.Secondary;

        private Popover _popover;

        private void TogglePopover()
        {
            _popover.Toggle();
        }
    }
}
