window.Bui =
{
    alert:
    {
        showAlert: function (message, title, state) {
            console.info(title, message, state);
            alert(title + "\n" + message + "\n");
        },

        showConfirm: function (message, title, state) {
            console.info(title, message, state);
            return confirm(title + "\n" + message + "\n");
        }
    },

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
