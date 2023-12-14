namespace ProductLib;
public class StaffResponse
    : StaffBase
    , IResponse
{
    public string? Id { get; set; } = default;
    public string StaffCode { get; set; } = default!;
    public string? Position { get; set; } = default;
    public DateTime? EffectedFrom { get; set; } = default;

}