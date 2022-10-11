namespace Inspection_of_Measuring_Instruments.Shared.ServerResponseModels;

public class ServerResponse<T> : BaseResponse
{
    public T? Value { get; set; }
}