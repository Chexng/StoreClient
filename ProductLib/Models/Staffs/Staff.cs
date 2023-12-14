namespace ProductLib;
public class Staff
    : StaffBase
    , IKey
{
    public string Id { get; set; } = default!;
    public string StaffId { get; set; } = default!;
    public Position Position { get; set; } = Position.None;
    public DateTime? CreatedOn { get; set; } = default;
    public DateTime? LastUpdatedOn { get; set; } = default;
    public DateTime EffectedFrom { get; set; } = default!;

    
}
