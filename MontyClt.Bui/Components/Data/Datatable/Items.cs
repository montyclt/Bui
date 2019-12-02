using System;

namespace MontyClt.Bui.Components.Data.Datatable
{
    public class Column<T>
    {
        public string Header { get; set; }
        public bool Sortable { get; set; }
        public Func<T, object> Content { get; set; }

        public Column(string header, Func<T, object> content, bool sortable = false)
        {
            Header = header;
            Content = content;
            Sortable = sortable;
        }
    }

    public class Row<T>
    {
        public bool IsSelected { get; set; }
        public T Item { get; set; }

        public Row(T item, bool isSelected = false)
        {
            Item = item;
            IsSelected = isSelected;
        }
    }
}
