using Inspection_of_Measuring_Instruments.Shared.Models.UserModels;

namespace Inspection_of_Measuring_Instruments.Shared.Models.InstrumentModels;

public class BaseInstrumentModel
{
    public Guid Id { get; set; }
    public string? Brand { get; set; }
    public string? TypeOrModel { get; set; }
    public string? SerialNumber { get; set; }
    public UserOfInstrumentModel? UserOfInstrument { get; set; }
    public int LastInspectionYear { get; set; }
    public bool IsActive { get; set; }
}