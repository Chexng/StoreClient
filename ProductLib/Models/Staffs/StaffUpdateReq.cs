namespace ProductLib;

public class StaffUpdateReq
    : StaffBase
    , IUpdateReq
{
    public string Key { get; set; } = default!;
    public string? Position { get; set; } = default;
    public DateTime? EffectedFrom { get; set; } = default;
}