using Blazored.Modal;
using Blazored.Modal.Services;
using Inspection_of_Measuring_Instruments.Client.CustomComponents.ModalComponents;

namespace Inspection_of_Measuring_Instruments.Client.Utils;

public class ModalManager
{
    private readonly IModalService _modalService;

    public ModalManager(IModalService modalService)
    {
        _modalService = modalService;
    }

    public async Task ShowMessageModalAsync(string title, string message)
    {
        ModalParameters mParams = new()
        {
            { "Message", message }
        };
        _ = await _modalService.Show<MessageModalComponent>(title, mParams).Result;
    }

    public async Task<bool> ShowConfirmModalAsync(string title, string message)
    {
        ModalOptions options = new() { UseCustomLayout = true, AnimationType = ModalAnimationType.None };

        ModalParameters mParams = new() { { "Message", message } };

        var result = await _modalService.Show<ConfirmModalComponent>(title, mParams, options).Result;
        return result.Confirmed;
    }
}
