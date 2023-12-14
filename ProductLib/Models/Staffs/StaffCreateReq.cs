namespace ProductLib;
public class StaffCreateReq
    : StaffBase
    , ICreateReq
{
    public string StaffKey { get; set; } = default!;
    public string? Position { get; set; } = default;

    public DateTime? EffectedFrom { get; set; } = default;
}
