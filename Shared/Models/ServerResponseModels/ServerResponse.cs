namespace Inspection_of_Measuring_Instruments.Shared.Models.ServerResponseModels;

public class ServerResponse<T> : BaseResponse
{
    public T? Value { get; set; }
}