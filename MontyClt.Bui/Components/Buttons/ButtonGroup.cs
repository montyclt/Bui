using System;
using Microsoft.AspNetCore.Components;

namespace MontyClt.Bui.Components.Buttons
{
    public partial class ButtonGroup
    {
        public enum ButtonGroupOrientation
        {
            Vertial, Horizontal
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public ButtonGroupOrientation Orientation { get; set; } = ButtonGroupOrientation.Horizontal;

        private string GetOrientationClass()
        {
            return Orientation switch
            {
                ButtonGroupOrientation.Vertial => "vertical",
                ButtonGroupOrientation.Horizontal => "horizontal",
                _ => throw new ArgumentOutOfRangeException(nameof(Orientation))
            };
        }
    }
}
