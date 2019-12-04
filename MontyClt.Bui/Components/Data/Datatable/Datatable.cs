using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace MontyClt.Bui.Components.Data.Datatable
{
    public partial class Datatable<TItem>
    {
        [Inject]
        private IJSRuntime Js { get; set; }

        [Parameter]
        public IEnumerable<TItem> Items { get; set; }

        [Parameter]
        public bool IsSelectable { get; set; } = false;

        [Parameter]
        public RenderFragment Header { get; set; }

        [Parameter]
        public RenderFragment<TItem> Content { get; set; }

        public Guid Guid { get; set; } = Guid.NewGuid();
        public IEnumerable<Row<TItem>> Rows { get; set; }
        public IEnumerable<Row<TItem>> SelectedRows => Rows.Where(x => x.IsSelected);

        protected override void OnInitialized()
        {
            Rows = Items.Select(item => new Row<TItem>(item)).ToList();
        }

        public void SelectAll()
        {
            foreach (var row in Rows)
                row.IsSelected = true;
        }

        public void UnselectAll()
        {
            foreach (var row in Rows)
                row.IsSelected = false;
        }

        private async Task OnChangeMainCheckbox(MouseEventArgs e)
        {
            bool selected = await Js.InvokeAsync<bool>("Bui.datatable.checkSelectAll", Guid.ToString());

            if (selected)
                SelectAll();
            else
                UnselectAll();
        }

        private bool AreAllRowsSelected => SelectedRows.Count() == Rows.Count();
    }
}
