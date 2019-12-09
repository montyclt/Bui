window.Bui =
{
    popper: function (activadorQuerySelector, boxQuerySelector, placement) {
        new Popper(document.querySelector(activadorQuerySelector), document.querySelector(boxQuerySelector), { placement: placement });
    },
    datatable:
    {
        checkSelectAll: function (guid) {
            return document.querySelector("#datatable-" + guid + " input[data-selectall]").checked;
        }
    }
};
