using Inspection_of_Measuring_Instruments.Domain.Entities.UserEntities;

namespace Inspection_of_Measuring_Instruments.Domain.Entities.InstrumentEntities;

public class BaseInstrumentEntity : BaseEntity
{
    public string? Brand { get; set; }
    public string? TypeOrModel { get; set; }
    public string? SerialNumber { get; set; }
    public BaseUserEntity? UserOfInstrument { get; set; }
    public int LastInspectionYear { get; set; }
    public bool IsActive { get; set; }
}