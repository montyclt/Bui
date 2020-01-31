using System;
using Microsoft.AspNetCore.Components;

namespace MontyClt.Bui
{
    public abstract class BuiComponent : ComponentBase
    {
        protected Guid Guid { get; } = Guid.NewGuid();

        [Parameter]
        public string Id { get; set; }
    }
}
