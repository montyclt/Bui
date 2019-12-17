using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace MontyClt.Bui.Components.Modal
{
    public class Alert
    {
        private readonly IJSRuntime _js;

        public Alert(IJSRuntime js)
        {
            _js = js;
        }

        public async Task ShowAlertAsync(string message, string title = null, State state = null)
        {
            title ??= string.Empty;
            state ??= State.Primary;

            await _js.InvokeVoidAsync("Bui.alert.showAlert", message, title, state.ToString());
        }

        public async Task<bool> ShowConfirmAsync(string message, string title = null, State state = null)
        {
            title ??= string.Empty;
            state ??= State.Primary;

            return await _js.InvokeAsync<bool>("Bui.alert.showConfirm", message, title, state.ToString());
        }
    }
}
