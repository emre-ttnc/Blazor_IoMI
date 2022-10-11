namespace Inspection_of_Measuring_Instruments.Shared.ServerResponseModels;

public class BaseResponse
{
    public bool Success { get; set; } = false;
    public string? ErrorMessage { get; set; }
}