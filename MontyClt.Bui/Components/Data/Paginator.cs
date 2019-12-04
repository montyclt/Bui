using System;
using Microsoft.AspNetCore.Components;

namespace MontyClt.Bui.Components.Data
{
    public partial class Paginator
    {
        [Parameter]
        public int Items { get; set; }

        [Parameter]
        public int ItemsPerPage { get; set; }

        [Parameter]
        public int CurrentPage { get; set; }

        private int Pages => (int)Math.Ceiling((double)Items / (double)ItemsPerPage);

        void SetPage(int page)
        {
            CurrentPage = page;
        }
    }
}
